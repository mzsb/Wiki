using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity
{
    public class Alias
    {
        public string Language { get; set; }
        public string Value { get; set; }

        public override string ToString() => Value;
    }
}
