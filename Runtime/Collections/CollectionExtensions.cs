using System.Collections.Generic;

namespace Mirzipan.Extensions.Collections
{
    public static class CollectionExtensions
    {
        public static bool IsNullOrEmpty<T>(this ICollection<T> @this) => @this == null || @this.Count == 0;

        public static bool NotNullOrEmpty<T>(this ICollection<T> @this) => !@this.IsNullOrEmpty();

        public static ICollection<T> NullIfEmpty<T>(this ICollection<T> @this) => @this == null || @this.Count == 0 ? null : @this;
    }
}