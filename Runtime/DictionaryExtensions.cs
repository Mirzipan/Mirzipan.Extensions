using System.Collections.Generic;

namespace Mirzipan.Extensions
{
    public static class DictionaryExtensions
    {
        public static bool IsNullOrEmpty<TKey, TValue>(this IDictionary<TKey, TValue> @this)
        {
            return @this == null || @this.Count == 0;
        }
    }
}