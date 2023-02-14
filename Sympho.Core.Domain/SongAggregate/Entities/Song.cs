using Sympho.Core.Domain.Common.Models;
using Sympho.Core.Domain.SongAggregate.ValueObjects;
using Sympho.Core.Domain.SongCollectionAggregate.ValueObjects;
using Sympho.Core.Domain.UserAggregate.ValueObjects;

namespace Sympho.Core.Domain.SongAggregate.Entities
{
    public sealed class Song : Entity<SongId> {

        private readonly List<Genre> _genres;
        private readonly List<string> _writers;
        private readonly List<string> _producers;
        private readonly List<CreatorId> _creators;
        private readonly List<CreatorId> _featuring;

        public string Title { get; private set; }
        public AudioTiming Length { get; private set; }
        public DateOnly ReleaseDate { get; private set; }
        public SongCollectionId SongCollectionId { get; private set; }
        public IReadOnlyList<Genre> Genres => _genres.AsReadOnly();
        public IReadOnlyList<string> Writers => _writers.AsReadOnly();
        public IReadOnlyList<string> Producers => _producers.AsReadOnly();
        public IReadOnlyList<CreatorId> Creators=> _creators.AsReadOnly();
        public IReadOnlyList<CreatorId> Featuring => _featuring.AsReadOnly();
        public ulong Likes { get; private set; }
        public ulong Plays { get; private set; }
        public Uri SongUrl { get; private set; }

        private Song(
            SongId songId,
            string title,
            AudioTiming length,
            DateOnly releaseDate,
            SongCollectionId songCollectionId,
            List<Genre> genres,
            List<string> writers,
            List<string> producers,
            List<CreatorId> creators,
            List<CreatorId> featuring,
            ulong likes,
            ulong plays,
            Uri songUrl
            ) : base(songId) {

            Title = title;
            Length = length;
            ReleaseDate = releaseDate;
            SongCollectionId = songCollectionId;
            _genres = genres;
            _writers = writers;
            _producers = producers;
            _creators = creators;
            _featuring = featuring;
            Likes = likes;
            Plays = plays;
            SongUrl = songUrl;
        }

        public static Song Create(
            string title,
            AudioTiming length,
            DateOnly releaseDate,
            SongCollectionId songCollectionId,
            List<Genre> genres,
            List<string>? writers,
            List<string>? producers,
            List<CreatorId> creators,
            List<CreatorId>? featuring,
            ulong likes,
            ulong plays,
            Uri songUrl) {

            return new Song(
                SongId.CreateUnique(),
                title,
                length,
                releaseDate,
                songCollectionId,
                genres,
                writers ?? new(),
                producers ?? new(),
                creators ?? new(),
                featuring ?? new(),
                likes,
                plays,
                songUrl);
        }

    }
}
