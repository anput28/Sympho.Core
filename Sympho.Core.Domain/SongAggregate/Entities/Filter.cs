using Sympho.Core.Domain.Common.Models;
using Sympho.Core.Domain.SongAggregate.ValueObjects;

namespace Sympho.Core.Domain.SongAggregate.Entities {
    public sealed class Filter : Entity<FilterId>{

        private readonly List<GenreId> _genres;

        public string Name { get; private set; }
        public IReadOnlyList<GenreId> Genres => _genres.AsReadOnly();
        public Uri ImgUrl { get; private set; }

        private Filter(FilterId id, string name, List<GenreId> genres, Uri imgUrl) : base(id) {
            Name = name;
            _genres = genres;
            ImgUrl = imgUrl;
        }

        public static Filter Create(string name, List<GenreId>? genres, Uri imgUrl) {
            return new Filter(
                FilterId.CreateUnique(),
                name,
                genres ?? new(),
                imgUrl);
        }
    }
}
