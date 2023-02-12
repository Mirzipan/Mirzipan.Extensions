using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class FloatExtensions
    {
        public static float Sign(this float @this)
        {
            return @this switch
            {
                > 0f => +1f,
                < 0f => -1f,
                _ => 0f
            };
        }
        
        public static bool IsBetween01(this float @this)
        {
            return IsBetween(@this, 0f, 1f);
        }
        
        public static bool IsBetween(this float @this, float min, float max)
        {
            return @this >= min && @this <= max;
        }
        
        public static bool LossyEquals(this float @this, float other, float tolerance = float.Epsilon)
        {
            return Mathf.Abs(@this - other) <= Mathf.Abs(tolerance);
        }
    }
}