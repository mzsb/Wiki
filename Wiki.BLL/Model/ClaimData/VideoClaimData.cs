using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.ClaimData
{
    public class VideoClaimData : IClaimData
    {
        public string Label { get; set; }
        public string Rank { get; set; }

        public static List<string> IDS { get; } = new List<string>
        {
            "P10", //video
            //TODO
        };

        public string Source { get; set; }

        public Dictionary<IClaimData, List<IClaimData>> Qualifiers { get; set; }
            = new Dictionary<IClaimData, List<IClaimData>>();

        public List<Dictionary<IClaimData, List<IClaimData>>> References { get; set; }
            = new List<Dictionary<IClaimData, List<IClaimData>>>();

    }
}
