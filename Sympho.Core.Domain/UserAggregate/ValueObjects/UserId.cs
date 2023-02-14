using Sympho.Core.Domain.Common.Models;

namespace Sympho.Core.Domain.UserAggregate.ValueObjects
{
    public class UserId : ValueObject
    {

        public Guid Value { get; }

        protected UserId(Guid value) { Value = value; }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
