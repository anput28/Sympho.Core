using Sympho.Core.Domain.Common.Models;
using Sympho.Core.Domain.SongAggregate.ValueObjects;

namespace Sympho.Core.Domain.SongAggregate.Entities
{
    public sealed class Genre : Entity<GenreId>
    {

        private readonly List<GenreId> _parentIds;
        public string Name { get; private set; }
        public IReadOnlyList<GenreId> ParentIds => _parentIds.AsReadOnly();

        private Genre(GenreId id, string name, List<GenreId> parentIds) : base(id)
        {
            Name = name;
            _parentIds = parentIds;
        }

        public static Genre Create(string name, List<GenreId>? parentIds)
        {
            return new Genre(GenreId.CreateUnique(), name, parentIds ?? new());
        }


    }
}
