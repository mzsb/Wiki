using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Wiki.BLL.Model.Entity.DataValueModel
{
    public class TimeValue : DataValue
    {
        public static new readonly string Type = "time";

        private string _formattedTime;

        public string Time { get; set; }

        public int Timezone { get; set; }
        public int Precision { get; set; }

        #region Precisions

        private const int _billionYearsPrecision = 0;
        private const int _hundredMillionYearsPrecision = 1;
        private const int _tenMillionYearsPrecision = 2;
        private const int _millionYearsPrecision = 3;
        private const int _hundredThousandYearsPrecision = 4;
        private const int _tenThousandYearsPrecision = 5;
        private const int _millenniumPrecision = 6;
        private const int _centuryPrecision = 7;
        private const int _decadePrecision = 8;
        private const int _yearsPrecision = 9;
        private const int _monthsPrecision = 10;
        private const int _daysPrecision = 11;
        private const int _hoursPrecision = 12;
        private const int _minutesPrecision = 13;
        private const int _secondsPrecision = 14;

        #endregion

        private string GetFormattedTime(string time)
        {
            if (string.IsNullOrEmpty(time))
            {
                return "-";
            }

            time = time.Replace("T", " ").Replace("Z", "");

            try
            {
                string AD_BC = "AD/BC";

                if (time[0] == '+' || time[0] == '-')
                {
                    var timelist = time.ToList();
                    AD_BC = timelist.First().ToString() == "+" ? "AD" : "BC";
                    timelist.RemoveAt(0);
                    time = new string(timelist.ToArray());
                }

                var splittedTime = time.Split(' ');
                var years0_mounths1_days2 = splittedTime[0].Split('-');
                var hours0_minutes1_seconds2 = splittedTime[1].Split(':');

                switch (Precision)
                {
                    case _secondsPrecision:
                        return $"{years0_mounths1_days2[0]}. {years0_mounths1_days2[1]}. {years0_mounths1_days2[2]}. " +
                               $"{hours0_minutes1_seconds2[0]}:{hours0_minutes1_seconds2[1]}:{hours0_minutes1_seconds2[2]} {AD_BC}";

                    case _minutesPrecision:
                        return $"{years0_mounths1_days2[0]}. {years0_mounths1_days2[1]}. {years0_mounths1_days2[2]}. " +
                               $"{hours0_minutes1_seconds2[0]}:{hours0_minutes1_seconds2[1]} {AD_BC}";

                    case _hoursPrecision:
                        return $"{years0_mounths1_days2[0]}. {years0_mounths1_days2[1]}. {years0_mounths1_days2[2]}. " +
                               $"{hours0_minutes1_seconds2[0]}:00 {AD_BC}";

                    case _daysPrecision:
                        return $"{years0_mounths1_days2[0]}. {years0_mounths1_days2[1]}. {years0_mounths1_days2[2]}. {AD_BC}";

                    case _monthsPrecision:
                        return $"{years0_mounths1_days2[0]}. {years0_mounths1_days2[1]}. {AD_BC}";

                    case _yearsPrecision:
                        return $"{years0_mounths1_days2[0]}. {AD_BC}";

                    case _decadePrecision:
                        var decade = years0_mounths1_days2[0].ToCharArray();
                        decade[decade.Length - 1] = '0';
                        return $"{new string(decade)}s {AD_BC}";

                    case _centuryPrecision:
                        var century = years0_mounths1_days2[0].ToCharArray();
                        if(century[century.Length - 1] == '0')
                        {
                            return $"{century[0]}{century[1]}. century {AD_BC}";
                        }
                        else 
                        {
                            return $"{int.Parse($"{century[0]}{century[1]}") + 1}. century {AD_BC}";
                        }

                    case _millenniumPrecision:
                        var millenium = years0_mounths1_days2[0].ToCharArray();
                        if (millenium[millenium.Length - 1] == '0')
                        {
                            return $"{millenium[0]}. millennium {AD_BC}";
                        }
                        else
                        {
                            return $"{int.Parse($"{millenium[0]}") + 1}. millennium {AD_BC}";
                        }

                    case _tenThousandYearsPrecision:
                        return $"{double.Parse(years0_mounths1_days2[0]) / 1000.0:F3} thousend years {AD_BC}";

                    case _hundredThousandYearsPrecision:
                        return $"{double.Parse(years0_mounths1_days2[0]) / 1000.0:F3} thousend years {AD_BC}";

                    case _millionYearsPrecision:
                        return $"{double.Parse(years0_mounths1_days2[0]) / 1000000.0:F3} million years {AD_BC}";

                    case _tenMillionYearsPrecision:
                        return $"{double.Parse(years0_mounths1_days2[0]) / 1000000.0:F3} million years {AD_BC}";

                    case _hundredMillionYearsPrecision:
                        return $"{double.Parse(years0_mounths1_days2[0]) / 1000000.0:F3} million years {AD_BC}";

                    case _billionYearsPrecision:
                        return $"{double.Parse(years0_mounths1_days2[0]) / 1000000000.0:F3} billion years {AD_BC}";

                    default:
                        return time;
                }
            }
            catch
            {
                return time;
            }
        }

        public override string GetValue()
        {
            if(_formattedTime is null)
            {
                _formattedTime = GetFormattedTime(Time);
            }

            return _formattedTime;
        }
    }
}
