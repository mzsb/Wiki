using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity
{
    public class SiteLink
    {
        public string Site { get; set; }
        public string Title { get; set; }
        public ICollection<string> Badges { get; set; } = new List<string>();
        public string Url { get; set; }

        public override string ToString() => Url;
    }
}
