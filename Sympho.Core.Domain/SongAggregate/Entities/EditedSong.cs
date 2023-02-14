using Sympho.Core.Domain.Common.Models;
using Sympho.Core.Domain.SongAggregate.ValueObjects;
using Sympho.Core.Domain.UserAggregate.ValueObjects;

namespace Sympho.Core.Domain.SongAggregate.Entities {
    public sealed class EditedSong : Entity<SongId> {

        private readonly List<GenreId> _genres;
        private readonly List<AppliedFilter> _appliedFilters;

        public EditedSongTitle Title { get; private set; }
        public UserId EditorId { get; private set; }
        public AudioTiming Length { get; private set; }
        public DateOnly ReleaseDate { get; private set; }
        public IReadOnlyList<GenreId> Genres => _genres.AsReadOnly();
        public IReadOnlyList<AppliedFilter> AppliedFilters => _appliedFilters.AsReadOnly();
        public ulong Likes { get; private set; }
        public Uri SongUrl { get; private set; }
        public SongId OriginalSongId { get; private set; }

        private EditedSong(
            SongId id,
            EditedSongTitle title,
            UserId editorId,
            AudioTiming length,
            DateOnly releaseDate,
            List<GenreId> genres,
            List<AppliedFilter> appliedFilters,
            ulong likes,
            Uri songUrl,
            SongId originalSongId) : base(id) {

            Title = title;
            EditorId = editorId;
            Length = length;
            ReleaseDate = releaseDate;
            _genres = genres;
            _appliedFilters = appliedFilters;
            Likes = likes;
            SongUrl = songUrl;
            OriginalSongId = originalSongId;
        }

        public static EditedSong Create(
            EditedSongTitle title,
            UserId editorId,
            AudioTiming length,
            DateOnly releaseDate,
            List<GenreId> genres,
            List<AppliedFilter> appliedFilters,
            ulong likes,
            Uri songUrl,
            SongId originalSongId) {

            return new EditedSong(
                SongId.CreateUnique(),
                title,
                editorId,
                length,
                releaseDate,
                genres,
                appliedFilters,
                likes,
                songUrl,
                originalSongId);
        }

    }
}
