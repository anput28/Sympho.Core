using System.Runtime.InteropServices;

namespace Sympho.Core.Domain.UserAggregate.ValueObjects {
    public sealed class CreatorId : UserId {
        private CreatorId(Guid value) : base(value) { }

        public static CreatorId CreateUnique() {
            return new CreatorId(Guid.NewGuid());
        }

        public static CreatorId Create(string value) {
            return new CreatorId(Guid.Parse(value));
        }
    }
}
