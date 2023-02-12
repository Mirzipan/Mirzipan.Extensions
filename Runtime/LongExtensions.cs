namespace Mirzipan.Extensions
{
    public static class LongExtensions
    {
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