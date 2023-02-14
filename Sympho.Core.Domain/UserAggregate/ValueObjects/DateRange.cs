using System.Globalization;
using Sympho.Core.Domain.Common.Models;

namespace Sympho.Core.Domain.UserAggregate.ValueObjects
{
    public class DateRange : ValueObject
    {

        public uint Start { get; private set; }
        public uint End { get; private set; }

        public DateRange(uint start, uint end)
        {
            var calendar = new GregorianCalendar();
            if (ChecksValidity(start, end, calendar))
            {
                Start = start;
                End = end;
            }
            else
            {
                throw new ArgumentException("The dates are not valid.");
            }
        }

        public DateRange(uint singleDate)
        {
            var calendar = new GregorianCalendar();
            if (ChecksValidity(singleDate, calendar))
            {
                Start = singleDate;
                End = singleDate;
            }
            else
            {
                throw new ArgumentException("The dates are not valid.");
            }
        }

        private static bool ChecksValidity(uint start, uint end, Calendar calendar)
        {
            return start >= calendar.MinSupportedDateTime.Year && end <= calendar.MaxSupportedDateTime.Year && start < end;
        }

        private static bool ChecksValidity(uint singleDate, Calendar calendar)
        {
            return singleDate >= calendar.MinSupportedDateTime.Year && singleDate <= calendar.MaxSupportedDateTime.Year;
        }

        public override string ToString()
        {
            return Start != End ? $"{Start} - {End}" : $"{Start}";
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Start;
            yield return End;
        }
    }
}
