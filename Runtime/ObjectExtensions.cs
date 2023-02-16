using System;
using System.Collections.Generic;
using System.Linq;

namespace Mirzipan.Extensions
{
    public static class ObjectExtensions
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
        public static T[] AsArray<T>(this T @this) => new[] { @this };

        /// <summary>
        /// Returns an <see cref="IList{T}"/> with this as its element.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IList<T> AsList<T>(this T @this) => new List<T> { @this };

        /// <summary>
        /// Returns a <see cref="HashSet{T}"/> with this as its element.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static HashSet<T> AsHashSet<T>(this T @this) => new HashSet<T> { @this };

        /// <summary>
        /// Returns a <see cref="IDictionary{TKey, TValue}"/> with this as its element.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="keySelector">Function to select the key for this</param>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <returns></returns>
        public static IDictionary<TKey, TValue> AsDictionary<TKey, TValue>(this TValue @this,
            Func<TValue, TKey> keySelector)
        {
            return new Dictionary<TKey, TValue>
            {
                [keySelector(@this)] = @this
            };
        }

        /// <summary>
        /// If this is not null, perform an action on this.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Do<T>(this T @this, Action<T> action)
        {
            if (EqualityComparer<T>.Default.Equals(@this, default))
            {
                return default;
            }

            action(@this);
            return @this;
        }

        /// <summary>
        /// Transform this with a function if this is not null.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="f"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static TResult DoIfNotNull<T, TResult>(this T @this, Func<T, TResult> f)
        {
            return !EqualityComparer<T>.Default.Equals(@this, default) ? f(@this) : default;
        }

        /// <summary>
        /// Transform this with a function if this is not null. If this is null, return the default instance of this
        /// </summary>
        /// <param name="this"></param>
        /// <param name="f"></param>
        /// <param name="default"></param>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        public static TResult Return<T, TResult>(this T @this, Func<T, TResult> f, TResult @default)
        {
            return !EqualityComparer<T>.Default.Equals(@this, default) ? f(@this) : @default;
        }

        /// <summary>
        /// Returns true if this is null.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsNull<T>(this T @this) => EqualityComparer<T>.Default.Equals(@this, default);

        /// <summary>
        /// Returns true if this is not null.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsNotNull<T>(this T @this) => !EqualityComparer<T>.Default.Equals(@this, default);

        /// <summary>
        /// Returns true if this matches all predicates..
        /// </summary>
        /// <param name="this"></param>
        /// <param name="predicates"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool Validate<T>(this T @this, params Predicate<T>[] predicates) => predicates.All(e => e(@this));
    }
}