using System.Collections.Generic;

namespace Mirzipan.Extensions.Collections
{
    public static class DictionaryExtensions
    {
        public static bool IsNullOrEmpty<TKey, TValue>(this IDictionary<TKey, TValue> @this) => @this == null || @this.Count == 0;
        
        public static bool NotNullOrEmpty<TKey, TValue>(this IDictionary<TKey, TValue> @this) => !@this.IsNullOrEmpty();

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

        public static TValue GetOrAddValue<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue @default)
        {
            if (@this.TryGetValue(key, out var value))
            {
                return value;
            }

            @this[key] = @default;
            return @default;
        }

        public static bool ChangeKey<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey oldKey, TKey newKey)
        {
            if (!@this.TryGetValue(oldKey, out var value))
            {
                return false;
            }

            @this.Remove(oldKey);
            @this[newKey] = value;
            return true;
        }
    }
}