using System.Text;

namespace Mirzipan.Extensions.Text
{
    public static class StringBuilderExtensions
    {
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
    }
}