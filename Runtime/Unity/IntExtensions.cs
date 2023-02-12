using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class IntExtensions
    {
        public static int Clamp(this int @this, int min, int max) => Mathf.Clamp(@this, min, max);
    }
}