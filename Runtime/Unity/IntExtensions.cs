using System;
using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class IntExtensions
    {
        [Obsolete("Use the one in Mirzipan.Extensions namespace")]
        public static int Clamp(this int @this, int min, int max) => Mathf.Clamp(@this, min, max);
    }
}