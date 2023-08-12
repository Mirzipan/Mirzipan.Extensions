using UnityEngine;

namespace Mirzipan.Extensions
{
    public static partial class IntExtensions
    {
        #region Equality

        public static bool IsZero(this int @this) => @this == 0;
        
        public static bool NotZero(this int @this) => @this != 0;

        public static bool IsMin(this int @this) => @this == int.MinValue;
        
        public static bool IsMax(this int @this) => @this == int.MaxValue;
        
        #endregion Equality

        #region Manipulation

        /// <summary>
        /// Clamps this between min and max values.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">Lower bound</param>
        /// <param name="max">Upped bound</param>
        /// <returns></returns>
        public static int Clamp(this int @this, int min, int max) => Mathf.Clamp(@this, min, max);

        #endregion Manipulation
    }
}