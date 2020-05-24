using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity.DataValueModel
{
    public class QuantityValue : DataValue
    {
        public static new readonly string Type = "quantity";

        public string Amount { get; set; }
        public string Unit { get; set; }

        public string UnitId => !string.IsNullOrEmpty(Unit) &&
                                Unit.Contains("Q") &&
                                Unit.Split('Q')[1] is string str &&
                                int.TryParse(str, out int number) ?
                                                     $"Q{number}" :
                                                     string.Empty;
        public override string GetValue() => $"{Amount} [{UnitId}]";
    }
}
