using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity.DataValueModel
{
    public class StringValue : DataValue
    {
        public static new readonly string Type = "string";

        public string Value { get; set; }

        public override string GetValue() => Value;
    }
}
