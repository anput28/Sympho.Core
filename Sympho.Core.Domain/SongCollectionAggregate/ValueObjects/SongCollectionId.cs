using Sympho.Core.Domain.Common.Models;

namespace Sympho.Core.Domain.SongCollectionAggregate.ValueObjects {
    public sealed class SongCollectionId: ValueObject {

        public Guid Value { get; }

        private SongCollectionId(Guid value) { Value = value; }

        public static SongCollectionId CreateUnique() {
            return new SongCollectionId(Guid.NewGuid());
        }

        public static SongCollectionId Create(string userId) {
            return new SongCollectionId(Guid.Parse(userId));
        }

        public override IEnumerable<object> GetEqualityComponents() {
            yield return Value;

        }
    }
}
