using Sympho.Core.Domain.Common.Models;

namespace Sympho.Core.Domain.PlaylistAggregate.ValueObjects {
    public sealed class PlaylistItemId : ValueObject {

        public Guid Value { get; }

        private PlaylistItemId(Guid value) { Value = value; }

        public static PlaylistItemId CreateUnique() {
            return new PlaylistSItemId(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents() {
            yield return Value;
        }
    }
}
