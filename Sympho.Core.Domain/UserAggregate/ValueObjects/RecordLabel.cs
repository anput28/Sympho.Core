using Sympho.Core.Domain.Common.Models;

namespace Sympho.Core.Domain.UserAggregate.ValueObjects
{
    public sealed class RecordLabel : ValueObject
    {

        public string Name { get; }

        public RecordLabel(string name)
        {
            Name = name;
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
        }
    }
}
