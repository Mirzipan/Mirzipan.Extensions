using System;
using System.Collections.Generic;
using System.Linq;

namespace Mirzipan.Extensions.Collections
{
    public static partial class EnumerableExtensions
    {
        /// <summary>
        /// Returns true if no element matches the predicate.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="predicate"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool None<T>(this IEnumerable<T> @this, Func<T, bool> predicate) => !@this.Any(predicate);

        /// <summary>
        /// Applies the specified action to each element.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            foreach (T entry in @this)
            {
                action(entry);
                yield return entry;
            }
        }

        /// <summary>
        /// Applies the specified action to each element. The action can work with the index of the element.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
        {
            int index = 0;
            foreach (T entry in @this)
            {
                action(entry, index++);
                yield return entry;
            }
        }

        /// <summary>
        /// Transforms each element using the specified function.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="function"></param>
        /// <typeparam name="TValue">Old element type</typeparam>
        /// <typeparam name="TResult">New element type</typeparam>
        /// <returns></returns>
        public static IEnumerable<TResult> ForEach<TValue, TResult>(this IEnumerable<TValue> @this,
            Func<TValue, TResult> function)
        {
            foreach (TValue entry in @this)
            {
                yield return function(entry);
            }
        }

        /// <summary>
        /// Transforms each element using the specified function. The function can work with the index of the element.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="function"></param>
        /// <typeparam name="TValue">Old element type</typeparam>
        /// <typeparam name="TResult">New element type</typeparam>
        /// <returns></returns>
        public static IEnumerable<TResult> ForEach<TValue, TResult>(this IEnumerable<TValue> @this,
            Func<TValue, int, TResult> function)
        {
            int index = 0;
            foreach (TValue entry in @this)
            {
                yield return function(entry, index++);
            }
        }

        /// <summary>
        /// Returns every other element of the sequence, starting with the first even element.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> Even<T>(this IEnumerable<T> @this)
        {
            int index = 0;
            foreach (T entry in @this)
            {
                if (index % 2 == 0)
                {
                    yield return entry;
                }

                index++;
            }
        }

        /// <summary>
        /// Returns every other element of the sequence, starting with the first odd element.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> Odd<T>(this IEnumerable<T> @this)
        {
            int index = 0;
            foreach (T entry in @this)
            {
                if (index % 2 != 0)
                {
                    yield return entry;
                }

                index++;
            }
        }

        /// <summary>
        /// Returns every n-th element of the sequence, starting with the first n-th element.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="count"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> Every<T>(this IEnumerable<T> @this, int count)
        {
            int index = 0;
            foreach (T entry in @this)
            {
                index++;
                if (index == count)
                {
                    index = 0;
                    yield return entry;
                }
            }
        }

        /// <summary>
        /// Orders the sequence ascending or descending, and based on the selector provided.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="selector"></param>
        /// <param name="ascending"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <returns></returns>
        public static IOrderedEnumerable<T> OrderBy<T, TKey>(
            this IEnumerable<T> @this,
            Func<T, TKey> selector,
            bool ascending)
        {
            return ascending ? @this.OrderBy(selector) : @this.OrderByDescending(selector);
        }

        /// <summary>
        /// Orders the sequence ascending or descending, and based on the selector provided.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="selector"></param>
        /// <param name="ascending"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <returns></returns>
        public static IOrderedEnumerable<T> ThenBy<T, TKey>(
            this IOrderedEnumerable<T> @this,
            Func<T, TKey> selector,
            bool ascending)
        {
            return ascending ? @this.ThenBy(selector) : @this.ThenByDescending(selector);
        }

        /// <summary>
        /// Returns the object with the minimum value of the specified function.
        /// </summary>
        /// <returns>The object.</returns>
        /// <param name="this"></param>
        /// <param name="selector">Transforms element into key</param>
        /// <typeparam name="TValue">Type of the enumerable element</typeparam>
        /// <typeparam name="TKey">Type used to determine the key value</typeparam>
        public static TValue MinObject<TValue, TKey>(this IEnumerable<TValue> @this, Func<TValue, TKey> selector)
            where TKey : IComparable<TKey>
        {
            bool isEmpty = true;
            TValue minValue = default;
            TKey minKey = default;

            foreach (TValue item in @this)
            {
                if (isEmpty)
                {
                    minValue = item;
                    minKey = selector(minValue);
                    isEmpty = false;
                }
                else
                {
                    TKey currentKey = selector(item);
                    if (currentKey.CompareTo(minKey) >= 0)
                    {
                        continue;
                    }

                    minKey = currentKey;
                    minValue = item;
                }
            }

            if (isEmpty)
            {
                throw new InvalidOperationException("Sequence is empty.");
            }

            return minValue;
        }

        /// <summary>
        /// Returns the object with the maximum value of the specified function.
        /// </summary>
        /// <returns>The object.</returns>
        /// <param name="this"></param>
        /// <param name="selector">Transforms element into key</param>
        /// <typeparam name="TValue">Type of the enumerable element</typeparam>
        /// <typeparam name="TKey">Type used to determine the key value</typeparam>
        public static TValue MaxObject<TValue, TKey>(this IEnumerable<TValue> @this, Func<TValue, TKey> selector)
            where TKey : IComparable<TKey>
        {
            bool isEmpty = true;
            TValue maxValue = default;
            TKey maxKey = default;

            foreach (TValue item in @this)
            {
                if (isEmpty)
                {
                    maxValue = item;
                    maxKey = selector(maxValue);
                    isEmpty = false;
                }
                else
                {
                    TKey currentKey = selector(item);
                    if (currentKey.CompareTo(maxKey) <= 0)
                    {
                        continue;
                    }

                    maxKey = currentKey;
                    maxValue = item;
                }
            }

            if (isEmpty)
            {
                throw new InvalidOperationException("Sequence is empty.");
            }

            return maxValue;
        }

        /// <summary>
        /// Returns all values of this enumerable, except the one specified.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="valueToExclude"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> Except<T>(this IEnumerable<T> @this, T valueToExclude) =>
            @this.Where(e => !e.Equals(valueToExclude));

        /// <summary>
        /// Returns all non-null values of this enumerable.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> SelectNotNull<T>(this IEnumerable<T> @this) => @this.Where(e => e != null);
    }
}