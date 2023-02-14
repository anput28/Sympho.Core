using Sympho.Core.Domain.Common.Models;

namespace Sympho.Core.Domain.SongAggregate.ValueObjects {
    public sealed class AudioTiming : ValueObject {
        private static readonly ushort MAX_MINUTES = 1440;
        private static readonly byte MAX_SECONDS = 60;
        public ushort Minutes { get; private set; }
        public byte Seconds { get; private set; }

        private AudioTiming(ushort minutes, byte seconds) {
            Minutes = minutes;
            Seconds = seconds;
        }

        public static AudioTiming Create(ushort minutes, byte seconds) {
            if(minutes > MAX_MINUTES) {
                throw new ArgumentException("Too many minutes.");
            }

            if(seconds > MAX_SECONDS) {
                throw new ArgumentException("Too many seconds.");
            }

            return new AudioTiming(minutes, seconds);
        }

        public static AudioTiming Create(ushort seconds) {
            return new AudioTiming((ushort)(seconds / 60), (byte)(seconds % 60));
        }

        public override IEnumerable<object> GetEqualityComponents() {
            yield return Minutes;
            yield return Seconds;
        }

        public override string ToString() {
            return $"{Minutes}:{Seconds}";
        }

        public static bool operator >(AudioTiming left, AudioTiming right) {
            if(left.Minutes > right.Minutes) {
                return true;
            } else if (left.Minutes == right.Minutes) {
                return left.Seconds > right.Seconds;
            }
            return false;
        }

        public static bool operator <(AudioTiming left, AudioTiming right) {
            if (left.Minutes < right.Minutes) {
                return true;
            } else if (left.Minutes == right.Minutes) {
                return left.Seconds < right.Seconds;
            }
            return false;
        }

        public static bool operator >=(AudioTiming left, AudioTiming right) {
            if (left.Minutes > right.Minutes) {
                return true;
            } else if (left.Minutes == right.Minutes) {
                return left.Seconds >= right.Seconds;
            }
            return false;
        }

        public static bool operator <=(AudioTiming left, AudioTiming right) {
            if (left.Minutes < right.Minutes) {
                return true;
            } else if (left.Minutes == right.Minutes) {
                return left.Seconds <= right.Seconds;
            }
            return false;
        }
    }
}
