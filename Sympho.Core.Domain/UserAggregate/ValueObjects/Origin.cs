using Sympho.Core.Domain.Common.Models;

namespace Sympho.Core.Domain.UserAggregate.ValueObjects
{
    public class Origin : ValueObject
    {

        public string Nation { get; private set; }
        public string City { get; private set; }

        public Origin(string nation, string city)
        {
            Nation = nation;
            City = city;
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Nation;
            yield return City;
        }
    }
}
