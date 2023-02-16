using System;

namespace Mirzipan.Extensions.Collections
{
    public static class ArrayExtensions
    {
        public static bool IsNullOrEmpty<T>(this T[] @this) => @this == null || @this.Length == 0;
        
        public static bool NotNullOrEmpty<T>(this T[] @this) => !@this.IsNullOrEmpty();

        public static T[] EmptyIfNull<T>(this T[] @this) => @this ?? Array.Empty<T>();

        public static T[] NullIfEmpty<T>(this T[] @this) => @this == null || @this.Length == 0 ? null : @this;

        public static int IndexOf<T>(this T[] @this, T value) => Array.IndexOf(@this, value);

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

        public static T[] FillBy<T>(this T[] @this, Func<int, T> valueFactory)
        {
            for (int i = 0; i < @this.Length; i++)
            {
                @this[i] = valueFactory(i);
            }

            return @this;
        }

        public static T[] Swap<T>(this T[] @this, int index1, int index2)
        {
            (@this[index1], @this[index2]) = (@this[index2], @this[index1]);
            return @this;
        }
    }
}