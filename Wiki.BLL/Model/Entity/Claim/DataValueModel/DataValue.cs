using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity.DataValueModel
{
    public class DataValue
    {
        [JsonProperty("value")]
        public object RawValue { get; set; }

        public string Type { get; set; }

        public DataValue CastToSpecific()
        {
            if (Type == EntityValue.Type)
            {
                return JsonConvert.DeserializeObject<EntityValue>(RawValue.ToString());
            }
            else if (Type == StringValue.Type)
            {
                return new StringValue { Value = RawValue.ToString() };
            }
            else if (Type == CoordinateValue.Type)
            {
                return JsonConvert.DeserializeObject<CoordinateValue>(RawValue.ToString());
            }
            else if (Type == QuantityValue.Type)
            {
                return JsonConvert.DeserializeObject<QuantityValue>(RawValue.ToString());
            }
            else if (Type == TimeValue.Type)
            {
                return JsonConvert.DeserializeObject<TimeValue>(RawValue.ToString());
            }
            else if (Type == MonolingualValue.Type)
            {
                return JsonConvert.DeserializeObject<MonolingualValue>(RawValue.ToString());
            }

            return this;
        }

        public virtual string GetValue() => RawValue.ToString();
    }
}
