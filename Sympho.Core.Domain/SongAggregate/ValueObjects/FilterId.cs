using Sympho.Core.Domain.Common.Models;

namespace Sympho.Core.Domain.SongAggregate.ValueObjects {
    public sealed class FilterId : ValueObject{
        public Guid Value { get; }

        private FilterId(Guid value) { Value = value; }

        public static FilterId CreateUnique() {
            return new FilterId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents() {
            yield return Value;
        }
    }
}
