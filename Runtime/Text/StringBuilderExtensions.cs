using System;
using System.Collections.Generic;
using System.Text;

namespace Mirzipan.Extensions
{
    public static class StringBuilderExtensions
    {
        #region Append

        public static StringBuilder AppendIf<T>(this StringBuilder @this, Predicate<T> predicate, T value)
        {
            if (predicate(value))
            {
                @this.Append(value);
            }
            
            return @this;
        }

        public static StringBuilder AppendIf<T>(this StringBuilder @this, Predicate<T> predicate, IEnumerable<T> values)
        {
            foreach (var entry in values)
            {
                if (!predicate(entry))
                {
                    continue;
                }

                @this.Append(entry);
            }

            return @this;
        }

        public static StringBuilder AppendIf<T>(this StringBuilder @this, Predicate<T> predicate, params T[] values)
        {
            foreach (var entry in values)
            {
                if (!predicate(entry))
                {
                    continue;
                }

                @this.Append(entry);
            }

            return @this;
        }

        #endregion Append
        
        #region Prepend
        
        public static StringBuilder Prepend(this StringBuilder @this, object value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, string value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, char value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, byte value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, short value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, int value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, long value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, sbyte value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, ushort value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, uint value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, ulong value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, float value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, double value)
        {
            return @this.Insert(0, value);
        }
        
        public static StringBuilder Prepend(this StringBuilder @this, decimal value)
        {
            return @this.Insert(0, value);
        }

        #endregion Prepend
    }
}