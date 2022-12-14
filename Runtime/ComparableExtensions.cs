using System;

namespace Mirzipan.Extensions
{
    public static class ComparableExtensions
    {
        public static bool IsBetweenInclusive<T>(this T @this, T lower, T upper) where T: IComparable<T>
        {
            return @this.CompareTo(lower) >= 0 && @this.CompareTo(upper) <= 0;
        }
        
        public static bool IsBetweenExclusive<T>(this T @this, T lower, T upper) where T: IComparable<T>
        {
            return @this.CompareTo(lower) >= 0 && @this.CompareTo(upper) < 0;
        }
    }
}