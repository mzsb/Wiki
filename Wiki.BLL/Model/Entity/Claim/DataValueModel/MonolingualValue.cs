using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity.DataValueModel
{
    public class MonolingualValue : DataValue
    {
        public static new readonly string Type = "monolingualtext";

        public string Text { get; set; }

        public string Language { get; set; }

        public override string GetValue() => $"{Text}({Language})";
    }
}
