namespace Mirzipan.Extensions
{
    public static class LongExtensions
    {        
        #region Equality

        public static bool IsZero(this long @this) => @this == 0L;
        
        public static bool NotZero(this long @this) => @this == 0L;

        public static bool IsMin(this long @this) => @this == long.MinValue;
        
        public static bool IsMax(this long @this) => @this == long.MaxValue;
        
        #endregion Equality
        
        /// <summary>
        /// Clamps this between min and max values.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">Lower bound</param>
        /// <param name="max">Upped bound</param>
        /// <returns></returns>
        public static long Clamp(this long @this, long min, long max)
        {
            if (@this < min)
            {
                @this = min;
            }
            else if (@this > max)
            {
                @this = max;
            }

            return @this;
        }
    }
}