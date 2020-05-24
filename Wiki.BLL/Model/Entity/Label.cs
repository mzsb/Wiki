using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity
{
    public class Label
    {
        public string Value { get; set; }

        public override string ToString() => Value;
    }
}
