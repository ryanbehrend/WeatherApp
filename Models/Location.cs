using System;

namespace FinalProject.Models
{
    public abstract class Location
    {
        public string City { get; protected set; }

        public string ZipCode { get; protected set; }

        public string Country { get; protected set; }

        protected Location(string country)
        {
            if (string.IsNullOrWhiteSpace(country))
                throw new ArgumentException("Country code must be provided", nameof(country));
            Country = country;
        }

        public abstract string GetQueryString();

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(City))
                return City;
            return ZipCode;
        }
    }
}
