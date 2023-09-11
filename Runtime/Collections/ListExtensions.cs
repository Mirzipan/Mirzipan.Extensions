using System;
using System.Collections.Generic;

namespace Mirzipan.Extensions.Collections
{
    public static class ListExtensions
    {
        #region Queries

        /// <summary>
        /// Returns true if index is valid for this <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsOutOfBounds<T>(this IList<T> @this, int index) => index < 0 || index >= @this.Count;

        /// <summary>
        /// Returns true if index is valid for this <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsIndexInRange<T>(this IList<T> @this, int index) => index >= 0 && index < @this.Count;

        /// <summary>
        /// Returns true if a value exists at the specified index.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <param name="value">Value at the specified index, default value if index is out of bounds</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
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
        /// Returns the value at the index specified. If out-of-bound, returns default value instead.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <param name="default"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetOrDefault<T>(this IList<T> @this, int index, T @default = default)
        {
            return @this.IsIndexInRange(index) ? @this[index] : @default;
        }

        #endregion Queries

        #region Manipulation

        /// <summary>
        /// Returns the list with item appended to it.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="item"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<T> WithItem<T>(this IList<T> @this, T item)
        {
            @this.Add(item);
            return @this;
        }

        /// <summary>
        /// Returns the list with items appended to it.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="items"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> WithItems<T>(this List<T> @this, params T[] items)
        {
            @this.AddRange(items);
            return @this;
        }

        /// <summary>
        /// Returns the list with items appended to it.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="items"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> WithItems<T>(this List<T> @this, IEnumerable<T> items)
        {
            @this.AddRange(items);
            return @this;
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

        /// <summary>
        /// Fill this <see cref="IList{T}"/> with values returned by the valueFactory function.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="valueFactory">Function for getting a value for the specified index</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<T> FillBy<T>(this IList<T> @this, Func<int, T> valueFactory)
        {
            for (int i = 0; i < @this.Count; i++)
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
        public static IList<T> Swap<T>(this IList<T> @this, int index1, int index2)
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
        public static IList<T> SafeSwap<T>(this IList<T> @this, int index1, int index2)
        {
            if (@this.IsOutOfBounds(index1) || @this.IsOutOfBounds(index2))
            {
                return @this;
            }
            
            (@this[index1], @this[index2]) = (@this[index2], @this[index1]);
            return @this;
        }

        /// <summary>
        /// Swaps specified elements if both of them exist in this <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<T> Swap<T>(this IList<T> @this, T item1, T item2)
        {
            int index1 = @this.IndexOf(item1);
            int index2 = @this.IndexOf(item2);

            if (@this.IsOutOfBounds(index1) || @this.IsOutOfBounds(index2))
            {
                return @this;
            }

            return Swap(@this, index1, index2);
        }

        #endregion Manipulation
    }
}