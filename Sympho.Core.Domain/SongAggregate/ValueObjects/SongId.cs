using Sympho.Core.Domain.Common.Models;

namespace Sympho.Core.Domain.SongAggregate.ValueObjects {
    public sealed class SongId : ValueObject {

        public Guid Value { get; }

        private SongId(Guid value) { Value = value; }

        public static SongId CreateUnique() {
            return new SongId(Guid.NewGuid());
        }

        public static SongId Create(string songId) {
            return new SongId(Guid.Parse(songId));
        }

        public override IEnumerable<object> GetEqualityComponents() {
            yield return Value;
        }
    }
}
