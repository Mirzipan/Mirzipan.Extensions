using System.Collections.Generic;
using System.Linq;

namespace Mirzipan.Extensions
{
    public static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(IEnumerable<T> @this)
        {
            return @this == null || !@this.Any();
        }

        public static IEnumerable<T> EmptyIfNull<T>(IEnumerable<T> @this)
        {
            return @this ?? Enumerable.Empty<T>();
        }

        public static IDictionary<TKey, int> ToCountDictionary<TKey>(this IEnumerable<TKey> @this)
        {
            return @this.GroupBy(e => e).ToDictionary(e => e.Key, e => e.Count());
        }

        public static IDictionary<TKey, List<TValue>> ToDictionary<TKey, TValue>(
            this IEnumerable<IGrouping<TKey, TValue>> @this)
        {
            return @this.ToDictionary(e => e.Key, e => e.ToList());
        }
    }
}