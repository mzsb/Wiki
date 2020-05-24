using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Wiki.BLL.Model.Entity
{
    public class Entity
    {
        public int Pageid { get; set; }
        public int Ns { get; set; }
        public string Title { get; set; }
        public int Lastrevid { get; set; }
        public DateTime Modified { get; set; }
        public string Type { get; set; }
        public string Id { get; set; }
        public Dictionary<string, Label> Labels { get; set; } = new Dictionary<string, Label>();
        public Dictionary<string, Description> Descriptions { get; set; } = new Dictionary<string, Description>();
        public Dictionary<string, List<Alias>> Aliases { get; set; } = new Dictionary<string, List<Alias>>();
        public Dictionary<string, List<Claim>> Claims { get; set; } = new Dictionary<string, List<Claim>>();
        public Dictionary<string, SiteLink> SiteLinks { get; set; } = new Dictionary<string, SiteLink>();
    }
}
