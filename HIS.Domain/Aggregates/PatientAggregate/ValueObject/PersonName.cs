using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObj = HIS.Domain.Common.ValueObject;

namespace HIS.Domain.Aggregates.PatientAggregate.ValueObject
{
    public sealed class PersonName : ValueObj
    {
        public string FirstName { get; }
        public string LastName { get; }

        public PersonName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName) || firstName.Length < 2)
                throw new Exception("First name invalid.");

            if (string.IsNullOrWhiteSpace(lastName) || lastName.Length < 2)
                throw new Exception("Last name invalid.");

            FirstName = firstName.Trim();
            LastName = lastName.Trim();
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return FirstName;
            yield return LastName;
        }
    }
}
