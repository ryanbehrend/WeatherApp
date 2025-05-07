using System;

namespace FinalProject.Models
{
    public class CityLocation : Location
    {
        public CityLocation(string city, string country = "US") : base(country)
        {
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City must be provided", nameof(city));
            City = city;
        }

        public override string GetQueryString() => $"q={City},{Country}";

        public override string ToString() => City;
    }
}
