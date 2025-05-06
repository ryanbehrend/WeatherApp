using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Location
    {
        public string City { get; protected set; }
        public string ZipCode { get; protected set; }
        public string Country { get; protected set; }

        protected Location(string country)
        {
            Country = country;
        }

        public abstract string GetQuereyString();
    }
}
