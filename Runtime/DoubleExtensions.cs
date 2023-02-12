namespace Mirzipan.Extensions
{
    public static class DoubleExtensions
    {
        public static double Sign(this double @this)
        {
            return @this switch
            {
                > 0d => +1d,
                < 0d => -1d,
                _ => 0d
            };
        }
        
        public static bool IsBetween01(this double @this)
        {
            return IsBetween(@this, 0d, 1d);
        }
        
        public static bool IsBetween(this double @this, double min, double max)
        {
            return @this >= min && @this <= max;
        }
        
        public static bool LossyEquals(this double @this, double other, double tolerance = double.Epsilon)
        {
            double absDiff = @this > other ? @this - other : other - @this;
            double absTolerance = tolerance > 0d ? tolerance : -tolerance;
            return absDiff <= absTolerance;
        }
    }
}