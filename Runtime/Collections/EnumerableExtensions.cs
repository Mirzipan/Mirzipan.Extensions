using System;
using System.Collections.Generic;
using System.Linq;

namespace Mirzipan.Extensions.Collections
{
    public static class EnumerableExtensions
    {
        #region Value Checking

        public static bool IsNullOrEmpty<T>(IEnumerable<T> @this)
        {
            return @this == null || !@this.Any();
        }

        public static IEnumerable<T> EmptyIfNull<T>(IEnumerable<T> @this)
        {
            return @this ?? Enumerable.Empty<T>();
        }

        public static IEnumerable<T> ValueOrDefault<T>(IEnumerable<T> @this, IEnumerable<T> @default)
        {
            return !IsNullOrEmpty(@this) ? @this : @default;
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

        public static bool None<T>(this IEnumerable<T> @this, Func<T, bool> predicate)
        {
            return !@this.Any(predicate);
        }

        public static void ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            foreach (var entry in @this)
            {
                action(entry);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> @this, Action<T, int> action)
        {
            int index = 0;
            foreach (var entry in @this)
            {
                action(entry, index++);
            }
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