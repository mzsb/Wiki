using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity
{
    public class Claim
    {
        public Snak Mainsnak { get; set; }

        public string Rank { get; set; }

        public Dictionary<string, List<Snak>> Qualifiers { get; set; } 
            = new Dictionary<string, List<Snak>>();

        public List<Reference> References { get; set; } = new List<Reference>();
    }
}
