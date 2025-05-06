using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Models
{
    public class ZipCodeLocation : Location
    {
        public ZipCodeLocation(string zipCode, string country = "US") : base(country)
        {
            ZipCode = zipCode;
        }

        public override string GetQueryString() => $"zip={ZipCode},{Country}";
    }
}
