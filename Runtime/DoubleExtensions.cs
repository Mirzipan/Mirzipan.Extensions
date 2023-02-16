using System;
using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Returns true if this is between 0 and 1.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsBetween01(this double @this) => IsBetween(@this, 0d, 1d);

        /// <summary>
        /// Returns true if this is between min and max
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">Lower bound (inclusive)</param>
        /// <param name="max">Upped bound (inclusive)</param>
        /// <returns></returns>
        public static bool IsBetween(this double @this, double min, double max)
        {
            return @this >= min && @this <= max;
        }
        
        [Obsolete("Use Approximately")]
        public static bool LossyEquals(this double @this, double other, double tolerance = double.Epsilon)
        {
            return Approximately(@this, other, tolerance);
        }
        
        /// <summary>
        /// Returns true if this and the other value are equal enough.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="other"></param>
        /// <param name="tolerance">Optional value that specifies how close this and the other value need to be in order to be considered equal.</param>
        /// <returns></returns>
        public static bool Approximately(this double @this, double other, double tolerance = double.Epsilon)
        {
            double absDiff = @this > other ? @this - other : other - @this;
            double absTolerance = tolerance > 0d ? tolerance : -tolerance;
            return absDiff <= absTolerance;
        }

        /// <summary>
        /// Clamps this between 0 and 1.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static double Clamp01(this double @this) => Clamp(@this, 0d, 1d);
        
        /// <summary>
        /// Clamps this between min and max values.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">Lower bound</param>
        /// <param name="max">Upped bound</param>
        /// <returns></returns>
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

        /// <summary>
        /// Rounds this to the nearest integer. 
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static double Round(this double @this) => Math.Round(@this);

        /// <summary>
        /// Rounds this to the nearest integer. 
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static int RoundToInt(this double @this) => (int) Math.Round(@this);

        /// <summary>
        /// Rounds this to the nearest integer greater than or equal to this. 
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static double Ceil(this double @this) => Math.Ceiling(@this);
        
        /// <summary>
        /// Rounds this to the nearest integer greater than or equal to this. 
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static int CeilToInt(this double @this) => (int) Math.Ceiling(@this);

        /// <summary>
        /// Rounds this to the nearest integer smaller than or equal to this. 
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static double Floor(this double @this) => Math.Floor(@this);
        
        /// <summary>
        /// Rounds this to the nearest integer smaller than or equal to this. 
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static int FloorToInt(this double @this) => (int) Math.Floor(@this);
    }
}