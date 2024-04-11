using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanning
{
    public class Address
    {
        private string streetAddress;
        private string city;
        private string state;
        private string country;

        public Address(string streetAddress, string city, string state, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
            this.country = country;
        }

        public override string ToString()
        {
            return $"{streetAddress}, {city}, {state}, {country}";
        }
    }
}