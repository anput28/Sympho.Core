using Sympho.Core.Domain.Common.Models;
using Sympho.Core.Domain.PlaylistAggregate.ValueObjects;
using Sympho.Core.Domain.UserAggregate.ValueObjects;

namespace Sympho.Core.Domain.PlaylistAggregate.Entities {
    public sealed class Playlist : Entity<PlaylistId> {
        private readonly List<PlaylistItem> _items;
        public UserId AuthorId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public Uri ImgUrl { get; private set; }
        public IReadOnlyList<PlaylistItem> Items => _items.AsReadOnly();
        public ulong Likes { get; private set; }
        public bool IsPrivate { get; private set; }

        private Playlist(
            PlaylistId id,
            UserId authorId,
            string title,
            string description,
            Uri imgUrl,
            List<PlaylistItem> items,
            ulong likes,
            bool isPrivate) : base(id) {

            AuthorId = authorId;
            Title = title;
            Description = description;
            ImgUrl = imgUrl;
            _items = items;
            Likes = likes;
            IsPrivate = isPrivate;
        }

        public static Playlist Create(
            UserId authorId,
            string title,
            string? description,
            Uri imgUrl,
            List<PlaylistItem> items,
            ulong likes,
            bool isPrivate) {

            return new Playlist(
                PlaylistId.CreateUnique(),
                authorId,
                title,
                description ?? string.Empty,
                imgUrl,
                items,
                likes,
                isPrivate);
        }
    }
}
