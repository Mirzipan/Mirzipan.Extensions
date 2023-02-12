using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class FloatExtensions
    {
        public static bool LossyEquals(this float @this, float other, float tolerance = float.Epsilon)
        {
            return Mathf.Abs(@this - other) <= Mathf.Abs(tolerance);
        }
    }
}