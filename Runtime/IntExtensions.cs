using System;

namespace Mirzipan.Extensions
{
    public static class IntExtensions
    {
        public static TimeSpan Days(this int @this)
        {
            return TimeSpan.FromDays(@this);
        }

        public static TimeSpan Hours(this int @this)
        {
            return TimeSpan.FromHours(@this);
        }

        public static TimeSpan Minutes(this int @this)
        {
            return TimeSpan.FromMinutes(@this);
        }

        public static TimeSpan Seconds(this int @this)
        {
            return TimeSpan.FromSeconds(@this);
        }

        public static TimeSpan Milliseconds(this int @this)
        {
            return TimeSpan.FromMilliseconds(@this);
        }
    }
}