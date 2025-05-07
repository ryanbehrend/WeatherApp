using System;

namespace FinalProject.Models
{
    public class ZipCodeLocation : Location
    {
        public ZipCodeLocation(string zipCode, string country = "US")
            : base(country)
        {
            if (string.IsNullOrWhiteSpace(zipCode))
                throw new ArgumentException("ZIP code must be provided", nameof(zipCode));
            ZipCode = zipCode;
        }

        public override string GetQueryString() => $"zip={ZipCode},{Country}";

        public override string ToString() => ZipCode;
    }
}