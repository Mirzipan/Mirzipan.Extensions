namespace Mirzipan.Extensions
{
    public static class UlongExtensions
    {
        #region Equality

        public static bool IsZero(this ulong @this) => @this == 0UL;
        
        public static bool NotZero(this ulong @this) => @this != 0UL;

        public static bool IsMin(this ulong @this) => @this == ulong.MinValue;
        
        public static bool IsMax(this ulong @this) => @this == ulong.MaxValue;
        
        #endregion Equality
    }
}