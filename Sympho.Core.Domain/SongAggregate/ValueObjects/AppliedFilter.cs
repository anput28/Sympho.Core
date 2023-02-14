using Sympho.Core.Domain.Common.Models;

namespace Sympho.Core.Domain.SongAggregate.ValueObjects {
    public sealed class AppliedFilter : ValueObject {

        public FilterId FilterId { get; private set; }
        public AudioTiming Start { get; private set; }
        public AudioTiming End { get; private set; }

        private AppliedFilter(FilterId filterId, AudioTiming start, AudioTiming end ) {
            FilterId = filterId;
            Start = start;
            End = end;
        }

        public static AppliedFilter Create(FilterId filterId, AudioTiming start, AudioTiming end) {
            if(start >= end) {
                throw new ArgumentException("The start time must be less than the end time.");
            }

            return new AppliedFilter(filterId, start, end);
        }

        public override IEnumerable<object> GetEqualityComponents() {
            yield return FilterId;
            yield return Start;
            yield return End;
        }
    }
}
