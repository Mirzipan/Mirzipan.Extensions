using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class FloatExtensions
    {
        public static float Clamp(this float @this, float min, float max)
        {
            return Mathf.Clamp(@this, min, max);
        }
        
        public static float Clamp01(this float @this)
        {
            return Mathf.Clamp01(@this);
        }
    }
}