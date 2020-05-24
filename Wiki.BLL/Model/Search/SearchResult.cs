using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiki.BLL.Model
{

    public class SearchResult
    {
        public string Id { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string[] Aliases { get; set; }
    }
}

