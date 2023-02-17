using System.Collections.Generic;

namespace Mirzipan.Extensions.Collections
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Returns true if this <see cref="ICollection{T}"/> is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsNullOrEmpty<T>(this ICollection<T> @this) => @this == null || @this.Count == 0;

        /// <summary>
        /// Returns true if this <see cref="ICollection{T}"/> is not null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool NotNullOrEmpty<T>(this ICollection<T> @this) => !@this.IsNullOrEmpty();

        /// <summary>
        /// Returns null if this <see cref="ICollection{T}"/> is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ICollection<T> NullIfEmpty<T>(this ICollection<T> @this) => @this == null || @this.Count == 0 ? null : @this;
    }
}