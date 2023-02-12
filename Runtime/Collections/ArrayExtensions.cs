using System;

namespace Mirzipan.Extensions.Collections
{
    public static class ArrayExtensions
    {
        public static bool IsNullOrEmpty<T>(this T[] @this)
        {
            return @this == null || @this.Length == 0;
        }

        public static T[] EmptyIfNull<T>(this T[] @this)
        {
            return @this ?? Array.Empty<T>();
        }
    }
}