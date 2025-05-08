using System;

namespace FinalProject.Models
{
    public class WeatherReport
    {
        public string City { get; set; }
        public DateTime DateTime { get; set; }
        public double Temperature { get; set; }
        public double MinTemperature { get; set; }
        public double MaxTemperature { get; set; }
        public int Humidity { get; set; }
        public double WindSpeed { get; set; }
        public string Condition { get; set; }
        public string Precipitation { get; set; }
    }
}
