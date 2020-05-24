using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.ClaimData
{
    public class ImageClaimData : IClaimData
    {
        public string Label { get; set; }
        public string Rank { get; set; }

        public static List<string> IDS { get; } = new List<string>
        {
            "P14", //traffic sign
            "P15", //route map
            "P18", //image
            "P41", //flag image
            "P2910", //icon
            "P181", //taxon range map image
            "P154" //logo
            //TODO
        };

        public string Source { get; set; }

        public Dictionary<IClaimData, List<IClaimData>> Qualifiers { get; set; }
            = new Dictionary<IClaimData, List<IClaimData>>();

        public List<Dictionary<IClaimData, List<IClaimData>>> References { get; set; }
            = new List<Dictionary<IClaimData, List<IClaimData>>>();

    }
}
