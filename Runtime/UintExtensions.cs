namespace Mirzipan.Extensions
{
    public static class UintExtensions
    {
        #region Equality

        public static bool IsZero(this uint @this) => @this == 0U;
        
        public static bool NotZero(this uint @this) => @this == 0U;

        public static bool IsMin(this uint @this) => @this == uint.MinValue;
        
        public static bool IsMax(this uint @this) => @this == uint.MaxValue;
        
        #endregion Equality
    }
}