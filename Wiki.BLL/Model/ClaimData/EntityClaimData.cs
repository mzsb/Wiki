using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wiki.BLL.Helpers;
using Wiki.BLL.Model.Entity;

namespace Wiki.BLL.Model.ClaimData
{
    public class EntityClaimData : IClaimData
    {
        public string Label 
        {
            get => Labels.GetStringValue();

            set { }
        }

        public string Rank { get; set; }

        public string Id { get; set; }

        public Dictionary<string, Label> Labels { get; set; } = new Dictionary<string, Label>();

        public Dictionary<IClaimData, List<IClaimData>> Qualifiers { get; set; }
            = new Dictionary<IClaimData, List<IClaimData>>();

        public List<Dictionary<IClaimData, List<IClaimData>>> References { get; set; }
            = new List<Dictionary<IClaimData, List<IClaimData>>>();
    }
}
