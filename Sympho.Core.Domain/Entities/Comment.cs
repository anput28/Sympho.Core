using Sympho.Core.Domain.Models;

namespace Sympho.Core.Domain.Entities {
    public class Comment {

        public string Id { get; set; } = string.Empty;
        public string AuthorId { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string AudioUrl { get; set; } = string.Empty;
        public SongId SongId { get; set; } = default!;
        public int Likes { get; set; } = 0;
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }

    }
}
