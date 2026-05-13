using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ValueObj = HIS.Domain.Common.ValueObject;


namespace HIS.Domain.Aggregates.PatientAggregate.ValueObject
{
    public sealed class PhoneNumber : ValueObj
    {
        public string Value { get; }

        public PhoneNumber(string value)
        {
            var regex = @"^\+[1-9]\d{1,14}$";

            if (!Regex.IsMatch(value, regex))
                throw new Exception("Phone number must follow E.164 format.");

            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
