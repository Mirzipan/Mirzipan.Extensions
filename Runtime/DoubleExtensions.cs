using System;

namespace Mirzipan.Extensions
{
    public static class DoubleExtensions
    {
        public static bool IsBetween01(this double @this) => IsBetween(@this, 0d, 1d);

        public static bool IsBetween(this double @this, double min, double max)
        {
            return @this >= min && @this <= max;
        }
        
        [Obsolete("Use Approximately")]
        public static bool LossyEquals(this double @this, double other, double tolerance = double.Epsilon)
        {
            return Approximately(@this, other, tolerance);
        }
        
        public static bool Approximately(this double @this, double other, double tolerance = double.Epsilon)
        {
            double absDiff = @this > other ? @this - other : other - @this;
            double absTolerance = tolerance > 0d ? tolerance : -tolerance;
            return absDiff <= absTolerance;
        }

        public static double Clamp01(this double @this) => Clamp(@this, 0d, 1d);
        
        public static double Clamp(this double @this, double min, double max)
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