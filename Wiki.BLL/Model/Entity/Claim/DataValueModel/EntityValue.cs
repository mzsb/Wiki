using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity.DataValueModel
{
    public class EntityValue : DataValue
    {
        public static new readonly string Type = "wikibase-entityid";

        public string Id { get; set; }

        public override string GetValue() => Id;
    }
}
