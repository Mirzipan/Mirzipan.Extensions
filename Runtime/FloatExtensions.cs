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
        
        public static bool Approximately(this float @this, float other, float tolerance)
        {
            return Mathf.Abs(@this - other) <= Mathf.Abs(tolerance);
        }
        
        public static bool Approximately(this float @this, float other) => Mathf.Approximately(@this, other);
        
        public static float Clamp(this float @this, float min, float max) => Mathf.Clamp(@this, min, max);

        public static float Clamp01(this float @this) => Mathf.Clamp01(@this);

        public static float Round(this float @this) => Mathf.Round(@this);

        public static int RoundToInt(this float @this) => Mathf.RoundToInt(@this);
    }
}