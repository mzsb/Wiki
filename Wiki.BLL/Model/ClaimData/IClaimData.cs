using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.ClaimData
{
    public interface IClaimData
    {
        string Label { get; set; }
        string Rank { get; set; }
        Dictionary<IClaimData, List<IClaimData>> Qualifiers { get; set; }
        List<Dictionary<IClaimData, List<IClaimData>>> References { get; set; }
    }
}
