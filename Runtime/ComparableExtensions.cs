using System;

namespace Mirzipan.Extensions
{
    public static class ComparableExtensions
    {
        /// <summary>
        /// Returns this sign of this.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static int Sign(this IComparable @this) => @this.CompareTo(0);
        
        public static bool IsBetweenInclusive<T>(this T @this, T lower, T upper) where T: IComparable<T>
        {
            return @this.CompareTo(lower) >= 0 && @this.CompareTo(upper) <= 0;
        }
        
        public static bool IsBetweenExclusive<T>(this T @this, T lower, T upper) where T: IComparable<T>
        {
            return @this.CompareTo(lower) > 0 && @this.CompareTo(upper) < 0;
        }
    }
}