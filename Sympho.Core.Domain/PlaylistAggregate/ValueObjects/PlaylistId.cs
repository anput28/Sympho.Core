using Sympho.Core.Domain.Common.Models;
using Sympho.Core.Domain.SongAggregate.ValueObjects;

namespace Sympho.Core.Domain.PlaylistAggregate.ValueObjects {
    public sealed class PlaylistId : ValueObject {

        public Guid Value { get; }

        private PlaylistId(Guid value) { Value = value; }

        public static PlaylistId CreateUnique() {
            return new PlaylistId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents() {
            yield return Value;
        }
    }
}
