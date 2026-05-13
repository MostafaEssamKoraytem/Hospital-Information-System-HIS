using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObj = HIS.Domain.Common.ValueObject;

namespace HIS.Domain.Aggregates.PatientAggregate.ValueObject
{
    public class Email : ValueObj
    {
        public string Value { get; }
        private Email() { }

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Email is required");

            if (!value.Contains("@"))
                throw new ArgumentException("Invalid email");

            Value = value.Trim().ToLower();
        }

        public override bool Equals(object? obj)
        {
            return obj is Email email &&
                   Value == email.Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
