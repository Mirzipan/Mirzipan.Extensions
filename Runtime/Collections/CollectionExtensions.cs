using System.Collections.Generic;

namespace Mirzipan.Extensions.Collections
{
    public static class CollectionExtensions
    {
        #region Queries

        /// <summary>
        /// Returns null if this <see cref="ICollection{T}"/> is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static ICollection<T> NullIfEmpty<T>(this ICollection<T> @this) => @this == null || @this.Count == 0 ? null : @this;

        #endregion Queries
    }
}