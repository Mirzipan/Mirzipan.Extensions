using System;

namespace Mirzipan.Extensions.Collections
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Returns true if this <see cref="Array"/> is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this T[] @this) => @this == null || @this.Length == 0;
        
        /// <summary>
        /// Returns true if this <see cref="Array"/> is not null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool NotNullOrEmpty<T>(this T[] @this) => !@this.IsNullOrEmpty();

        /// <summary>
        /// Returns an empty <see cref="Array"/> if this is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] EmptyIfNull<T>(this T[] @this) => @this ?? Array.Empty<T>();

        /// <summary>
        /// Returns null if this <see cref="Array"/> is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] NullIfEmpty<T>(this T[] @this) => @this == null || @this.Length == 0 ? null : @this;

        /// <summary>
        /// Gets the first index of the specified value.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="value">Value to look for</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static int IndexOf<T>(this T[] @this, T value) => Array.IndexOf(@this, value);

        /// <summary>
        /// Gets the first index of the specified value.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="value">Value to look for</param>
        /// <param name="startIndex">Start search at this index</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static int IndexOf<T>(this T[] @this, T value, int startIndex) => Array.IndexOf(@this, value, startIndex);

        /// <summary>
        /// Gets the first index of the specified value.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="value">Value to look for</param>
        /// <param name="startIndex">Start search at this index</param>
        /// <param name="count">Count of elements to search in</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static int IndexOf<T>(this T[] @this, T value, int startIndex, int count) => Array.IndexOf(@this, value, startIndex, count);

        /// <summary>
        /// Returns true if index is not valid for this <see cref="Array"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsOutOfBounds<T>(this T[] @this, int index) => index < 0 || index >= @this.Length;
        
        /// <summary>
        /// Returns true if index is valid for this <see cref="Array"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsIndexInRange<T>(this T[] @this, int index) => index >= 0 && index < @this.Length;

        /// <summary>
        /// Returns true if a value exists at the specified index.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <param name="value">Value at the specified index, default value if index is out of bounds</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool TryGetValue<T>(this T[] @this, int index, out T value)
        {
            if (@this.IsOutOfBounds(index))
            {
                value = default;
                return false;
            }

            value = @this[index];
            return true;
        }

        /// <summary>
        /// Fill this <see cref="Array"/> with values returned by the valueFactory function.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="valueFactory">Function for getting a value for the specified index</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] FillBy<T>(this T[] @this, Func<int, T> valueFactory)
        {
            for (int i = 0; i < @this.Length; i++)
            {
                @this[i] = valueFactory(i);
            }

            return @this;
        }

        /// <summary>
        /// Swaps elements at the specified indices.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] Swap<T>(this T[] @this, int index1, int index2)
        {
            (@this[index1], @this[index2]) = (@this[index2], @this[index1]);
            return @this;
        }

        /// <summary>
        /// Swaps elements at the specified indices.
        /// No swapping occurs if indices are out of bounds.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] SafeSwap<T>(this T[] @this, int index1, int index2)
        {
            if (@this.IsOutOfBounds(index1) || @this.IsOutOfBounds(index2))
            {
                return @this;
            }
            
            (@this[index1], @this[index2]) = (@this[index2], @this[index1]);
            return @this;
        }
    }
}