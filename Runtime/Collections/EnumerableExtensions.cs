using System.Collections.Generic;
using System.Linq;

namespace Mirzipan.Extensions.Collections
{
    public static partial class EnumerableExtensions
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
    }
}