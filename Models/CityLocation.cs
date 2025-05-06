using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class CityLocation : Location
    {
        public CityLocation(string city, string country = "US") : base(country)
        {
            City = city;
        }

        public override string GetQueryString() => $"q={City},{Country}";
    }
}
