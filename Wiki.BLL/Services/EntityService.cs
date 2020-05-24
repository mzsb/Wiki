using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Wiki.BLL.Interfaces;
using Wiki.BLL.Model;
using Wiki.BLL.Model.Entity;
using Wiki.BLL.Model.Entity.DataValueModel;
using Wiki.BLL.Helpers;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using Wiki.BLL.Model.ClaimData;
using System.Runtime.CompilerServices;
using System.Diagnostics;

namespace Wiki.BLL.Services
{
    public class EntityService : ServiceBase, IEntityService
    {
        private const int _parameterLenghtLimit = 50;

        private readonly HttpClient _httpClient;

        public EntityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Entity> GetByIdAsync(string id, List<string> languages = null)
        {
            var response = await _httpClient.GetStringAsync(GetUrl(id, languages));

            return JsonConvert.DeserializeAnonymousType(response, 
                                                        new { Entities = new Dictionary<string, Entity>() })
                              .Entities
                              .TryGetValue(id, out Entity entity) ? 
                                                           entity : 
                                                           new Entity();
        }

        public async Task<Dictionary<IClaimData, List<IClaimData>>> 
            LoadClaimsAsync(Entity entity, List<string> languages = null)
        {
            List<string> idParameters = CreateIdParameters(GetIdsFromClaims(entity.Claims));
             
            var entities = await GetClaimEntites(idParameters,
                async (idParameter) => 
                    await _httpClient.GetStringAsync(GetUrl(idParameter, 
                                                            languages, 
                                                            "labels".ToStringList())));
            return GetClaims(entity.Claims, entities);
        }

        private string GetListParameter<T>(List<T> list, 
                                            int startIndex = 0, 
                                            int limit = 0) =>
            list?.GetRange(startIndex,
                            Math.Min(_parameterLenghtLimit, 
                                    limit < 1 ? 
                                    list.Count : 
                                    limit))
            ?.ToString("|");

        private string GetUrl(string ids, 
                              List<string> languages = null, 
                              List<string> porperties = null) =>
            Uri.EscapeDataString($"{_mediaWikiUrl}?" +
                                 $"action=wbgetentities&" +
                                 $"ids={ids}&" +
                                 (porperties is null ?
                                            $"" :
                                            $"props={GetListParameter(porperties)}&") +
                                 $"languages={GetListParameter(languages) ?? "en"}&" +
                                 $"format=json");

        private List<string> GetIdsFromClaims(Dictionary<string, List<Claim>> claims)
        {
            var ids = new List<string>();
            string unitId;

            void AddDataValueId(DataValue dataValue)
            {
                if (dataValue is EntityValue entityValue)
                {
                    ids.Add(entityValue.GetValue());
                }
                else if (dataValue is QuantityValue quantityValue)
                {
                    unitId = quantityValue.UnitId;
                    if (!string.IsNullOrEmpty(unitId))
                    {
                        ids.Add(unitId);
                    }
                }
            }

            void AddSnakIds(Dictionary<string, List<Snak>> snaks)
            {
                foreach (var snak in snaks)
                {
                    ids.Add(snak.Key);

                    foreach (var item in snak.Value)
                    {
                        AddDataValueId(item.DataValue);
                    }
                }
            }

            foreach (var pair in claims)
            {
                ids.Add(pair.Key);

                foreach (var item in pair.Value)
                {
                    AddDataValueId(item.Mainsnak.DataValue);

                    AddSnakIds(item.Qualifiers);

                    foreach (var reference in item.References)
                    {
                        AddSnakIds(reference.Snaks);
                    }
                }
            }

            return ids.Distinct()
                      .ToList();
        }

        private List<string> CreateIdParameters(List<string> idList)
        {
            var idParameters = new List<string>();
            for (int i = 0; i < idList.Count; i += _parameterLenghtLimit)
            {
                idParameters.Add(GetListParameter(idList, i, idList.Count - i));
            }

            return idParameters;
        }

        private async Task<Dictionary<string, EntityClaimData>> 
            GetClaimEntites(List<string> idParameters, Func<string, Task<string>> getMethod)
        {
            string response;
            var entities = new Dictionary<string, EntityClaimData>();
            foreach (var idParameter in idParameters)
            {
                response = await getMethod(idParameter);

                entities = entities.Concat(JsonConvert.DeserializeAnonymousType(response, new
                {
                    Entities = new Dictionary<string, EntityClaimData>()
                }).Entities).ToDictionary(pair => pair.Key, pair => pair.Value);
            }

            return entities;
        }

        private Dictionary<IClaimData, List<IClaimData>> 
            GetClaims(Dictionary<string, List<Claim>> rawClaims, 
                      Dictionary<string, EntityClaimData> entities)
        {
            IClaimData GetSpecificClaimData(DataValue dataValue, string key)
            {

                IClaimData claimData;
                if (dataValue is EntityValue entityValue)
                {
                    claimData = entities[entityValue.GetValue()];
                }
                else if (dataValue is QuantityValue quantityValue)
                {
                    claimData = new QuantityClaimData
                    {
                        Amount = quantityValue.Amount,
                        Unit = entities.TryGetValue(quantityValue.UnitId,
                            out EntityClaimData entityClaimData) ?
                                                 entityClaimData :
                                                 null,
                        Label = quantityValue.Unit
                    };
                }
                else
                {
                    if (ImageClaimData.IDS.Contains(key))
                    {
                        claimData = new ImageClaimData
                        {
                            Label = dataValue.GetValue(),
                            Source = dataValue.GetValue()
                                              .AsCommonsMediaSource()
                        };
                    }
                    else if (VideoClaimData.IDS.Contains(key))
                    {
                        claimData = new VideoClaimData
                        {
                            Label = dataValue.GetValue(),
                            Source = dataValue.GetValue()
                                              .AsCommonsMediaSource()
                        };
                    }
                    else if (AudioClaimData.IDS.Contains(key))
                    {
                        claimData = new AudioClaimData
                        {
                            Label = dataValue.GetValue(),
                            Source = dataValue.GetValue()
                                              .AsCommonsMediaSource()
                        };
                    }
                    else if (dataValue is null)
                    {
                        claimData = new UnknownClaimData
                        {
                            Label = "unknown"
                        };
                    }
                    else
                    {
                        claimData = new StringClaimData
                        {
                            Label = dataValue.GetValue()
                        };
                    }
                }

                return claimData;
            }

            List<IClaimData> claimDatas;
            var claims = new Dictionary<IClaimData, List<IClaimData>>();
            foreach (var pair in rawClaims)
            {
                IClaimData claimData;
                claimDatas = new List<IClaimData>();
                foreach (var claim in pair.Value)
                {
                    claimData = GetSpecificClaimData(claim.Mainsnak.DataValue, pair.Key);

                    claimData.Qualifiers = claim.Qualifiers.ToDictionary(
                        p => entities[p.Key] as IClaimData,
                        p => p.Value.Select(s => GetSpecificClaimData(s.DataValue, p.Key)).ToList());

                    claimData.References = claim.References.Select(r => r.Snaks.ToDictionary(
                        p => entities[p.Key] as IClaimData,
                        p => p.Value.Select(s => GetSpecificClaimData(s.DataValue, p.Key)).ToList())).ToList();

                    claimData.Rank = claim.Rank;
                    claimDatas.Add(claimData);
                }

                claims.Add(entities[pair.Key], claimDatas);
            }

            return claims;
        }
    }
}
