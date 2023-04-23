using System;
using System.Collections.Generic;
using System.Linq;

namespace Mirzipan.Extensions
{
    public static partial class ObjectExtensions
    {

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
        /// Returns true if this matches all predicates.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="predicates"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool Validate<T>(this T @this, params Predicate<T>[] predicates) => predicates.All(e => e(@this));

        /// <summary>
        /// Returns true if this is equal to at least one of the targets.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="targets"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsOneOf<T>(this T @this, params T[] targets)
        {
            for (int i = 0; i < targets.Length; i++)
            {
                if (@this.Equals(targets[i]))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns true if this is equal to at least one of the targets.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="comparer"></param>
        /// <param name="targets"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool IsOneOf<T>(this T @this, IEqualityComparer<T> comparer, params T[] targets)
        {
            for (int i = 0; i < targets.Length; i++)
            {
                if (comparer.Equals(@this, targets[i]))
                {
                    return true;
                }
            }

            return false;
        }
        
        
    }
}