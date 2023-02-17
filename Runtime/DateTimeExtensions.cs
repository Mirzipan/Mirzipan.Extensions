using System;

namespace Mirzipan.Extensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Returns true if this is between the dates supplied.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="from">Lower bound (inclusive)</param>
        /// <param name="to">Upped bound (exclusive)</param>
        /// <returns></returns>
        public static bool IsBetween(this DateTime @this, DateTime from, DateTime to)
        {
            return @this >= from && @this < to;
        }
        
        /// <summary>
        /// Returns true if this is between the dates supplied.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="from">Lower bound (inclusive)</param>
        /// <param name="to">Upped bound (inclusive)</param>
        /// <returns></returns>
        public static bool IsBetweenInclusive(this DateTime @this, DateTime from, DateTime to)
        {
            return @this >= from && @this <= to;
        }
        
        /// <summary>
        /// Returns true if this is between the dates supplied.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="from">Lower bound (exclusive)</param>
        /// <param name="to">Upped bound (exclusive)</param>
        /// <returns></returns>
        public static bool IsBetweenExclusive(this DateTime @this, DateTime from, DateTime to)
        {
            return @this > from && @this < to;
        }
    }
}