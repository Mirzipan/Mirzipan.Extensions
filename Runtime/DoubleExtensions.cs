namespace Mirzipan.Extensions
{
    public static class DoubleExtensions
    {
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