using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity
{
    public class Reference
    {
        public Dictionary<string, List<Snak>> Snaks { get; set; } = new Dictionary<string, List<Snak>>();
    }
}
