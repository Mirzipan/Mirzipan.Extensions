using System;
using System.Collections.Generic;

namespace Mirzipan.Extensions
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        /// Returns true if this is an instance of T.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool Is<T>(this object @this) => @this is T;
        
        /// <summary>
        /// Casts this to T.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T As<T>(this object @this) where T : class => @this as T;
        
        /// <summary>
        /// Returns an <see cref="Array"/> with this as its element.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] InArray<T>(this T @this) => new[] { @this };

        /// <summary>
        /// Returns an <see cref="IList{T}"/> with this as its element.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<T> InList<T>(this T @this) => new List<T> { @this };

        /// <summary>
        /// Returns a <see cref="HashSet{T}"/> with this as its element.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static HashSet<T> InHashSet<T>(this T @this) => new HashSet<T> { @this };

        /// <summary>
        /// Returns a <see cref="IDictionary{TKey, TValue}"/> with this as its element.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="keySelector">Function to select the key for this</param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IDictionary<TKey, TValue> InDictionary<TKey, TValue>(this TValue @this,
            Func<TValue, TKey> keySelector)
        {
            return new Dictionary<TKey, TValue>
            {
                [keySelector(@this)] = @this
            };
        }
    }
}