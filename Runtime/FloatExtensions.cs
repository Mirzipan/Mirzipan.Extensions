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

        public static float Round(this float @this) =>  (float) Math.Round(@this);

        public static int RoundToInt(this float @this) => (int) Math.Round(@this);

        public static float Ceil(this float @this) => (float) Math.Ceiling(@this);
        
        public static int CeilToInt(this float @this) => (int) Math.Ceiling(@this);

        public static float Floor(this float @this) => (float) Math.Floor(@this);
        
        public static int FloorToInt(this float @this) => (int) Math.Floor(@this);
    }
}