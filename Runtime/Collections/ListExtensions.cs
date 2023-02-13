using System;
using System.Collections.Generic;

namespace Mirzipan.Extensions.Collections
{
    public static class ListExtensions
    {
        public static bool IsNullOrEmpty<T>(this IList<T> @this) => @this == null || @this.Count == 0;
        
        public static bool NotNullOrEmpty<T>(this IList<T> @this) => !@this.IsNullOrEmpty();
        
        public static bool IsIndexInRange<T>(this IList<T> @this, int index)
        {
            return index > 0 && index < @this.Count;
        }

        public static bool TryGetValue<T>(this IList<T> @this, int index, out T value)
        {
            if (!@this.IsIndexInRange(index))
            {
                value = default;
                return false;
            }

            value = @this[index];
            return true;
        }
        
        /// <summary>
        /// Removes element by swapping, will not preserve order!
        /// </summary>
        /// <param name="this"></param>
        /// <param name="item"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool FastRemove<T>(this IList<T> @this, T item)
        {
            int index = @this.IndexOf(item);
            if (index < 0)
            {
                return false;
            }

            int lastIndex = @this.Count - 1;
            if (index != lastIndex)
            {
                @this[index] = @this[lastIndex];
            }

            @this.RemoveAt(lastIndex);
            return true;
        }
        
        /// <summary>
        /// Removes element at index swapping, will not preserve order!
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static void FastRemove<T>(this IList<T> @this, int index)
        {
            int lastIndex = @this.Count - 1;
            if (index != lastIndex)
            {
                @this[index] = @this[lastIndex];
            }

            @this.RemoveAt(lastIndex);
        }

        public static IList<T> FillBy<T>(this IList<T> @this, Func<int, T> valueFactory)
        {
            for (int i = 0; i < @this.Count; i++)
            {
                @this[i] = valueFactory(i);
            }

            return @this;
        }

        public static IList<T> Swap<T>(this IList<T> @this, int index1, int index2)
        {
            (@this[index1], @this[index2]) = (@this[index2], @this[index1]);
            return @this;
        }

        public static IList<T> Swap<T>(this IList<T> @this, T item1, T item2)
        {
            int index1 = @this.IndexOf(item1);
            int index2 = @this.IndexOf(item2);

            if (index1 < 0 || index2 < 0)
            {
                return @this;
            }

            return Swap(@this, index1, index2);
        }
    }
}