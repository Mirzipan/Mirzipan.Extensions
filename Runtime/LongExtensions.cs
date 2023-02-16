namespace Mirzipan.Extensions
{
    public static class LongExtensions
    {        
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