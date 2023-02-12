using System.Collections.Generic;

namespace Mirzipan.Extensions.Collections
{
    public static class CollectionExtensions
    {
        public static bool IsNullOrEmpty<T>(this ICollection<T> @this)
        {
            return @this == null || @this.Count == 0;
        }
    }
}