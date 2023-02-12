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

        public static bool IsIndexInRange<T>(this T[] @this, int index)
        {
            return index > 0 && index < @this.Length;
        }

        public static bool TryGetValue<T>(this T[] @this, int index, out T value)
        {
            if (!@this.IsIndexInRange(index))
            {
                value = default;
                return false;
            }

            value = @this[index];
            return true;
        }
    }
}