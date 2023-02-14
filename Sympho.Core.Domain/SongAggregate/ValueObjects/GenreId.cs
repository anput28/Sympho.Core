using Sympho.Core.Domain.Common.Models;

namespace Sympho.Core.Domain.SongAggregate.ValueObjects {
    public sealed class GenreId : ValueObject {

        public Guid Value { get; }

        private GenreId(Guid value) { Value = value; }

        public static GenreId CreateUnique() {
            return new GenreId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents() {
            yield return Value;
        }
    }
}
