using System;
using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class FloatExtensions
    {
        [Obsolete("Use the one in Mirzipan.Extensions namespace")]
        public static bool Approximately(this float @this, float other) => Mathf.Approximately(@this, other);
        
        [Obsolete("Use the one in Mirzipan.Extensions namespace")]
        public static float Clamp(this float @this, float min, float max) => Mathf.Clamp(@this, min, max);

        [Obsolete("Use the one in Mirzipan.Extensions namespace")]
        public static float Clamp01(this float @this) => Mathf.Clamp01(@this);

        [Obsolete("Use the one in Mirzipan.Extensions namespace")]
        public static float Round(this float @this) => Mathf.Round(@this);

        [Obsolete("Use the one in Mirzipan.Extensions namespace")]
        public static int RoundToInt(this float @this) => Mathf.RoundToInt(@this);
    }
}