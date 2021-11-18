using System;
using System.Collections.Generic;
using System.Globalization;

namespace WeatherApp
{
    public class Weather
    {
        public string name { get; set; }

        public int dt { get; set; }
        public string time
        {
            get
            {
                DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                return dateTime.AddSeconds(dt).ToLocalTime().ToString();
            }
        }
        public Wind wind { get; set; }
        public double visibility { get; set; }
        public Clouds clouds { get; set; }
        public Temperature main { get; set; }
        public Temperature tempcelcius
        {
            get
            {
                var a = new Temperature
                {
                    temp_max = (main.temp_max - 32) * 5 / 9,
                    temp = (main.temp - 32) * 5 / 9,
                    temp_min = (main.temp_min - 32) * 5 / 9,
                    feels_like = (main.feels_like - 32) * 5 / 9
                };

                return a;
            }
        }

    }

    public class Wind
    {
        public double speed { get; set; }
        public double deg { get; set; }
        public double gust { get; set; }
    }

    public class Clouds
    {
        public string all { get; set; }
    }

    public class Temperature
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_max { get; set; }
        public double temp_min { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
    }
}
