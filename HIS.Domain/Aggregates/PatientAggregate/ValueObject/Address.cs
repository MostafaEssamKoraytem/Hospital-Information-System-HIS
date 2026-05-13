using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObj = HIS.Domain.Common.ValueObject;

namespace HIS.Domain.Aggregates.PatientAggregate.ValueObject
{
    public class Address : ValueObj
    {
        public string City { get; }
        public string Street { get; }
        public string Country { get; }

        private Address() { }
        public Address(string city, string street, string country)
        {
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City is required");

            if (string.IsNullOrWhiteSpace(street))
                throw new ArgumentException("Street is required");

            if (string.IsNullOrWhiteSpace(country))
                throw new ArgumentException("Country is required");

            City = city;    
            Street = street;
            Country = country;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Street;
            yield return City;
            yield return Country;
        }
    }
}
