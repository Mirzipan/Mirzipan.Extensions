namespace Mirzipan.Extensions
{
    public static class LongExtensions
    {
        public static long Sign(this long @this)
        {
            return @this switch
            {
                > 0L => +1L,
                < 0L => -1L,
                _ => 0L
            };
        }
    }
}