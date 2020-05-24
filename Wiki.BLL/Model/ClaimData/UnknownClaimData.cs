using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.ClaimData
{
    public class UnknownClaimData : IClaimData
    {
        public string Label { get; set; }
        public string Rank { get; set; }

        public Dictionary<IClaimData, List<IClaimData>> Qualifiers { get; set; }
            = new Dictionary<IClaimData, List<IClaimData>>();

        public List<Dictionary<IClaimData, List<IClaimData>>> References { get; set; }
            = new List<Dictionary<IClaimData, List<IClaimData>>>();
    }
}
