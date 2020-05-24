using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity
{
    public class Description
    {
        public string Value { get; set; }

        public override string ToString() => Value;
    }
}
