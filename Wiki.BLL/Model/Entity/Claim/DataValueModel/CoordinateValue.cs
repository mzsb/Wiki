using System;
using System.Collections.Generic;
using System.Text;

namespace Wiki.BLL.Model.Entity.DataValueModel
{
    public class CoordinateValue : DataValue
    {
        public static new readonly string Type = "globecoordinate";

        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public object Altitude { get; set; }
        public float Precision { get; set; }
        public string Globe { get; set; }

        public override string GetValue() => $"({Latitude};{Longitude})";
    }
}
