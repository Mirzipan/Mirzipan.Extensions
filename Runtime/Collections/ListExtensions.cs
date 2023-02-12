using System.Collections.Generic;

namespace Mirzipan.Extensions.Collections
{
    public static class ListExtensions
    {
        /// <summary>
        /// Removes element by swapping, will not preserve order!
        /// </summary>
        /// <param name="this"></param>
        /// <param name="item"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static bool FastRemove<T>(this IList<T> @this, T item)
        {
            int index = @this.IndexOf(item);
            if (index < 0)
            {
                return false;
            }

            int lastIndex = @this.Count - 1;
            if (index != lastIndex)
            {
                @this[index] = @this[lastIndex];
            }

            @this.RemoveAt(lastIndex);
            return true;
        }
        
        /// <summary>
        /// Removes element at index swapping, will not preserve order!
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static void FastRemove<T>(this IList<T> @this, int index)
        {
            int lastIndex = @this.Count - 1;
            if (index != lastIndex)
            {
                @this[index] = @this[lastIndex];
            }

            @this.RemoveAt(lastIndex);
        }
    }
}