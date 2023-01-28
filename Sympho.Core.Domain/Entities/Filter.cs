namespace Sympho.Core.Domain.Entities {
    public class Filter {

        public string Id { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public List<string> Genres { get; set; } = new List<string>();

        public string ImgUrl { get; set; } = string.Empty;

        public DateTime CreatedDateTime { get; set; }

        public DateTime UpdatedDateTime { get; set; }
    }
}
