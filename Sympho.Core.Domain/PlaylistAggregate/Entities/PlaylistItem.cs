using Sympho.Core.Domain.Common.Models;
using Sympho.Core.Domain.PlaylistAggregate.ValueObjects;
using Sympho.Core.Domain.SongAggregate.ValueObjects;

namespace Sympho.Core.Domain.PlaylistAggregate.Entities {
    public sealed class PlaylistItem : Entity<PlaylistItemId> {

        public SongId SongId { get; private set; }
        public bool IsEdited { get; private set; }

        private PlaylistItem(PlaylistItemId id, SongId songId, bool isEdited) : base(id) {
            SongId = songId;
            IsEdited = isEdited;
        }

        public static PlaylistItem Create(SongId songId, bool isEdited) {
            return new PlaylistItem(PlaylistItemId.CreateUnique(), songId, isEdited);
        }
    }
}
