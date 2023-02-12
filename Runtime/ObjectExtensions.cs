using System;
using System.Collections.Generic;
using System.Linq;

namespace Mirzipan.Extensions
{
    public static class ObjectExtensions
    {
        public static bool Is<T>(this object @this) => @this is T;
        
        public static T As<T>(this object @this) where T : class => @this as T;
        
        public static T[] AsArray<T>(this T @this) => new[] { @this };

        public static IList<T> AsList<T>(this T @this) => new List<T> { @this };

        public static HashSet<T> AsHashSet<T>(this T @this) => new HashSet<T> { @this };

        public static IDictionary<TKey, TValue> AsDictionary<TKey, TValue>(this TValue @this,
            Func<TValue, TKey> keySelector)
        {
            return new Dictionary<TKey, TValue>
            {
                [keySelector(@this)] = @this
            };
        }

        public static T Do<T>(this T @this, Action<T> action)
        {
            if (EqualityComparer<T>.Default.Equals(@this, default))
            {
                return default;
            }

            action(@this);
            return @this;
        }

        public static TResult DoIfNotNull<T, TResult>(this T @this, Func<T, TResult> f)
        {
            return !EqualityComparer<T>.Default.Equals(@this, default) ? f(@this) : default;
        }

        public static TResult Return<T, TResult>(this T @this, Func<T, TResult> f, TResult @default)
        {
            return !EqualityComparer<T>.Default.Equals(@this, default) ? f(@this) : @default;
        }

        public static bool IsNull<T>(this T @this)
        {
            return EqualityComparer<T>.Default.Equals(@this, default);
        }

        public static bool IsNotNull<T>(this T @this)
        {
            return !EqualityComparer<T>.Default.Equals(@this, default);
        }

        public static bool Validate<T>(this T @this, params Predicate<T>[] predicates)
        {
            return predicates.All(e => e(@this));
        }
    }
}