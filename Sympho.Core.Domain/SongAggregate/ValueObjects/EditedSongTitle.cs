using Sympho.Core.Domain.Common.Models;
using Sympho.Core.Domain.SongAggregate.Entities;

namespace Sympho.Core.Domain.SongAggregate.ValueObjects {
    public sealed class EditedSongTitle : ValueObject {

        public string Title { get; private set; }

        private EditedSongTitle(string title) {
            Title = title;
        }

        public static EditedSongTitle Create(Song originalSong) {
            return new EditedSongTitle(string.Format("{0} - Edited - {1}", originalSong.Title, DateTime.UtcNow));
        }

        public override IEnumerable<object> GetEqualityComponents() {
            yield return Title;
        }
    }
}
