using System.Collections.Generic;

namespace Mirzipan.Extensions.Collections
{
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Returns true if this <see cref="IDictionary{TKey,TValue}"/> is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static bool IsNullOrEmpty<TKey, TValue>(this IDictionary<TKey, TValue> @this) => @this == null || @this.Count == 0;
        
        /// <summary>
        /// Returns true if this <see cref="IDictionary{TKey,TValue}"/> is not null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static bool NotNullOrEmpty<TKey, TValue>(this IDictionary<TKey, TValue> @this) => !@this.IsNullOrEmpty();

        /// <summary>
        /// Gets the value associated with the specified key or the default value if no value exists.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="key">The key of the value to get</param>
        /// <param name="default">Value to return if no value at the key was found</param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> @this, TKey key, TValue @default)
        {
            if (@this.TryGetValue(key, out var value))
            {
                return value;
            }

            return @default;
        }

        /// <summary>
        /// Gets the value associated with the specified key or the default value if no value exists.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="key">The key of the value to get</param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> @this, TKey key)
        {
            return @this.GetValueOrDefault(key, default(TValue));
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// If no value was found, the default value is added and returned.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="key">The key of the value to get</param>
        /// <param name="default">Value to add and return if no value at the key was found</param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static TValue GetOrAddValue<TKey, TValue>(this IDictionary<TKey, TValue> @this, TKey key, TValue @default)
        {
            if (@this.TryGetValue(key, out var value))
            {
                return value;
            }

            @this[key] = @default;
            return @default;
        }

        /// <summary>
        /// Replaces the old key with a new key, leaving the value intact.
        /// If there is no value associated with the old key, no change is made.
        /// Returns true if the change succeeded.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="oldKey">The current key</param>
        /// <param name="newKey">The new key</param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
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