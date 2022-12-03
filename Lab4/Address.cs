using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

        public Address(string _streetAddress, string _city, string _state, string _postalCode)
        { 
            StreetAddress = _streetAddress;
            City = _city;
            State = _state;
            PostalCode = _postalCode;
        }

        public override string ToString()
        {
            return StreetAddress + "|" + City + "|" + State + "|" + PostalCode;
        }
    }
}