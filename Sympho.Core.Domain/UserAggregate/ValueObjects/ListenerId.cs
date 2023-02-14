namespace Sympho.Core.Domain.UserAggregate.ValueObjects {
    public sealed class ListenerId : UserId {
        private ListenerId(Guid value) : base(value) { }

        public static ListenerId CreateUnique() {
            return new ListenerId(Guid.NewGuid());
        }

        public static ListenerId Create(string value) {
            return new ListenerId(Guid.Parse(value));
        }
    }
}
