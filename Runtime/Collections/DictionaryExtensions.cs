using System.Collections.Generic;

namespace Mirzipan.Extensions.Collections
{
    public static class DictionaryExtensions
    {
        public static bool IsNullOrEmpty<TKey, TValue>(this IDictionary<TKey, TValue> @this)
        {
            return @this == null || @this.Count == 0;
        }

        public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> @this, TKey key, TValue @default)
        {
            if (@this.TryGetValue(key, out var value))
            {
                return value;
            }

            return @default;
        }

        public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> @this, TKey key)
        {
            return @this.GetValueOrDefault(key, default(TValue));
        }
    }
}