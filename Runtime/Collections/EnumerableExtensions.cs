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

        public static IDictionary<TKey, int> ToCountDictionary<TKey>(this IEnumerable<TKey> @this)
        {
            return @this.GroupBy(e => e).ToDictionary(e => e.Key, e => e.Count());
        }

        public static IDictionary<TKey, List<TValue>> ToDictionary<TKey, TValue>(
            this IEnumerable<IGrouping<TKey, TValue>> @this)
        {
            return @this.ToDictionary(e => e.Key, e => e.ToList());
        }

        #endregion To Collection

        #region Linq

        public static bool None<T>(this IEnumerable<T> @this, Func<T, bool> predicate) => !@this.Any(predicate);

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            foreach (var entry in @this)
            {
                action(entry);
            }

            return @this;
        }
        
        public static IEnumerable<TValue> ForEach<TValue, TResult>(this IEnumerable<TValue> @this,
            Func<TValue, TResult> function)
        {
            foreach (var entry in @this)
            {
                function(entry);
            }

            return @this;
        }

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
        {
            int index = 0;
            foreach (var entry in @this)
            {
                action(entry, index++);
            }
            
            return @this;
        }

        public static IEnumerable<TValue> ForEach<TValue, TResult>(this IEnumerable<TValue> @this, Func<TValue, int, TResult> function)
        {
            int index = 0;
            foreach (var entry in @this)
            {
                function(entry, index++);
            }
            
            return @this;
        }

        public static IEnumerable<T> Return<T>(this IEnumerable<T> @this, Action<T> action)
        {
            foreach (T entry in @this)
            {
                action(entry);
                yield return entry;
            }
        }

        #endregion Linq
    }
}