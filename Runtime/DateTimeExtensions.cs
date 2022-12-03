using System;

namespace Mirzipan.Extensions
{
    public static class DateTimeExtensions
    {
        public static bool IsBetween(this DateTime @this, DateTime from, DateTime to)
        {
            return @this >= from && @this <= to;
        }
    }
}