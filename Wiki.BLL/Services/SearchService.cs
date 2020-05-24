using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Wiki.BLL.Interfaces;
using Wiki.BLL.Model;

namespace Wiki.BLL.Services
{
    public class SearchService : ServiceBase, ISearchService
    {
        private const string _defaultLanguage = "en";

        private readonly HttpClient _httpClient;

        public SearchService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SearchResult>> 
            SearchEntitiesAsync(string searchKey, 
                                string language = _defaultLanguage)
        {
            var response = await _httpClient.GetStringAsync(GetUrl(searchKey, language));

            return JsonConvert.DeserializeAnonymousType(response, 
                                                        new { Search = new List<SearchResult>() })
                              .Search;
        }

        private string GetUrl(string id,
                      string language) =>
           $"{_mediaWikiUrl}?" +
                                 $"action=wbsearchentities&" +
                                 $"search={id}&" +
                                 $"language={language}&" +
                                 $"format=json";
    }
}
