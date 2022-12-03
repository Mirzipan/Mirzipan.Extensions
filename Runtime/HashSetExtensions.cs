using System.Collections.Generic;

namespace Mirzipan.Extensions
{
    public static class HashSetExtensions
    {
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