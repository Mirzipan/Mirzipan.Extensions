using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class FloatExtensions
    {
        public static bool Approximately(this float @this, float other) => Mathf.Approximately(@this, other);
        
        public static float Clamp(this float @this, float min, float max) => Mathf.Clamp(@this, min, max);

        public static float Clamp01(this float @this) => Mathf.Clamp01(@this);

        public static float Round(this float @this) => Mathf.Round(@this);

        public static int RoundToInt(this float @this) => Mathf.RoundToInt(@this);
    }
}