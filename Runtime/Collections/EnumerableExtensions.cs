using System;
using System.Collections.Generic;
using System.Linq;

namespace Mirzipan.Extensions.Collections
{
    public static class EnumerableExtensions
    {
        #region Value Checking

        /// <summary>
        /// Returns true if this <see cref="IEnumerable{T}"/> is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this) => @this == null || !@this.Any();
        
        /// <summary>
        /// Returns true if this <see cref="IEnumerable{T}"/> is not null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool NotNullOrEmpty<T>(this IEnumerable<T> @this) => !@this.IsNullOrEmpty();

        /// <summary>
        /// Returns an empty <see cref="IEnumerable{T}"/> if this is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> @this) => @this ?? Enumerable.Empty<T>();

        /// <summary>
        /// Returns the current value of <see cref="IEnumerable{T}"/> if not null or empty, otherwise returns default.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="default"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ValueOrDefault<T>(this IEnumerable<T> @this, IEnumerable<T> @default)
        {
            // ReSharper disable PossibleMultipleEnumeration
            return !IsNullOrEmpty(@this) ? @this : @default;
            // ReSharper restore PossibleMultipleEnumeration
        }

        #endregion Value Checking

        #region To Collection

        /// <summary>
        /// Counts the occurence of each element and creatures a dictionary with elements as keys and counts as values.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="TKey"></typeparam>
        /// <returns></returns>
        public static IDictionary<TKey, int> ToCountDictionary<TKey>(this IEnumerable<TKey> @this)
        {
            return @this.GroupBy(e => e).ToDictionary(e => e.Key, e => e.Count());
        }

        /// <summary>
        /// Creates a dictionary based on the groupings.
        /// Keys used for grouping are used as keys for the dictionary.
        /// Values are added to each key as a list.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IDictionary<TKey, List<TValue>> ToDictionary<TKey, TValue>(
            this IEnumerable<IGrouping<TKey, TValue>> @this)
        {
            return @this.ToDictionary(e => e.Key, e => e.ToList());
        }

        #endregion To Collection

        #region Linq

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
        public static IEnumerable<TResult> ForEach<TValue, TResult>(this IEnumerable<TValue> @this, Func<TValue, int, TResult> function)
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

        #endregion Linq
    }
}