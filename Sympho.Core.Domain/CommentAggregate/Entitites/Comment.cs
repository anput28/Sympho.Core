using Sympho.Core.Domain.CommentAggregate.Enums;
using Sympho.Core.Domain.CommentAggregate.ValueObjects;
using Sympho.Core.Domain.Common.Models;
using Sympho.Core.Domain.SongAggregate.ValueObjects;
using Sympho.Core.Domain.UserAggregate.ValueObjects;

namespace Sympho.Core.Domain.CommentAggregate.Entitites
{
    public sealed class Comment : Entity<CommentId>
    {
        private readonly List<CommentId> _replies;

        public UserId AuthorId { get; private set; }
        public SongId SongId { get; private set; }
        public string? Message { get; private set; }
        public Uri? AudioUrl { get; private set; }
        public CommentType Type { get; private set; }
        public int Likes { get; private set; }
        public IReadOnlyList<CommentId> Replies => _replies.AsReadOnly();

        private Comment(
            CommentId id,
            UserId authorId,
            SongId songId,
            string message,
            int likes,
            List<CommentId> replies) : base(id) {

            AuthorId = authorId;
            SongId = songId;
            Type = CommentType.TEXT;
            Message = message;
            Likes = likes;
            _replies= replies;
        }

        private Comment(
            CommentId id,
            UserId authorId,
            SongId songId,
            Uri audioUrl,
            int likes,
            List<CommentId> replies) : base(id) {

            AuthorId = authorId;
            SongId = songId;
            Type = CommentType.AUDIO;
            AudioUrl = audioUrl;
            Likes = likes;
            _replies = replies;
        }

        public static Comment Create(
            UserId userId,
            SongId songId,
            string message,
            int likes,
            List<CommentId>? replies) {

            return new Comment(
                CommentId.CreateUnique(),
                userId,
                songId,
                message,
                likes,
                replies ?? new()
                );
        }

        public static Comment Create(
            UserId userId,
            SongId songId,
            Uri audioUrl,
            int likes,
            List<CommentId>? replies) {

            return new Comment(
                CommentId.CreateUnique(),
                userId,
                songId,
                audioUrl,
                likes,
                replies ?? new()
                );
        }

    }
}
