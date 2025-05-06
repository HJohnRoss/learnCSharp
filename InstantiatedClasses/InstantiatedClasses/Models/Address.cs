using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClasses.Models
{
    public class Address
    {
        public string AddressType { get; set; }
        public string City { get; set; }
        public string State {  get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public int ZipCode { get; set; }
        public int PostalCode { get; set; }

        public Address(string addressType, string street, string state, string city, string country, int zipCode, int postalCode)
        {

            AddressType = addressType;
            Street = street;
            State = state;
            City = city;
            Country = country;
            ZipCode = zipCode;
            PostalCode = postalCode;

        }
    }
}
