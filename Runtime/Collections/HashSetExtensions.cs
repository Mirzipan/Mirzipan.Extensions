using System.Collections.Generic;

namespace Mirzipan.Extensions.Collections
{
    public static class HashSetExtensions
    {
        /// <summary>
        /// Adds values from the source.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="source"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>True if all values added were not yet present</returns>
        public static bool AddRange<T>(this HashSet<T> @this, IEnumerable<T> source)
        {
            if (source == null)
            {
                return false;
            }

            bool result = true;
            foreach (var entry in source)
            {
                result &= @this.Add(entry);
            }

            return result;
        }
        
        /// <summary>
        /// Removes values from the source.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="source"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns>True if all values removed were present</returns>
        public static bool RemoveRange<T>(this HashSet<T> @this, IEnumerable<T> source)
        {
            if (source == null)
            {
                return false;
            }

            bool result = true;
            foreach (var entry in source)
            {
                result &= @this.Remove(entry);
            }

            return result;
        }
    }
}