using System;
using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class FloatExtensions
    {
        public static bool IsBetween01(this float @this) => IsBetween(@this, 0f, 1f);

        public static bool IsBetween(this float @this, float min, float max)
        {
            return @this >= min && @this <= max;
        }
        
        [Obsolete("Use Approximately")]
        public static bool LossyEquals(this float @this, float other, float tolerance = float.Epsilon)
        {
            return Approximately(@this, other, tolerance);
        }
        
        public static bool Approximately(this float @this, float other, float tolerance = float.Epsilon)
        {
            return Mathf.Abs(@this - other) <= Mathf.Abs(tolerance);
        }
    }
}