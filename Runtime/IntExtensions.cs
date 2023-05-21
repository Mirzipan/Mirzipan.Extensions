using System;
using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class IntExtensions
    {
        #region Equality

        public static bool IsZero(this int @this) => @this == 0;
        
        public static bool NotZero(this int @this) => @this == 0;

        public static bool IsMin(this int @this) => @this == int.MinValue;
        
        public static bool IsMax(this int @this) => @this == int.MaxValue;
        
        #endregion Equality
        
        /// <summary>
        /// Clamps this between min and max values.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">Lower bound</param>
        /// <param name="max">Upped bound</param>
        /// <returns></returns>
        public static int Clamp(this int @this, int min, int max) => Mathf.Clamp(@this, min, max);
        
        #region TimeSpan

        /// <summary>
        /// Creates a <see cref="TimeSpan"/> with days equal to this.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static TimeSpan Days(this int @this)
        {
            return TimeSpan.FromDays(@this);
        }

        /// <summary>
        /// Creates a <see cref="TimeSpan"/> with hours equal to this.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static TimeSpan Hours(this int @this)
        {
            return TimeSpan.FromHours(@this);
        }

        /// <summary>
        /// Creates a <see cref="TimeSpan"/> with minutes equal to this.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static TimeSpan Minutes(this int @this)
        {
            return TimeSpan.FromMinutes(@this);
        }

        /// <summary>
        /// Creates a <see cref="TimeSpan"/> with seconds equal to this.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static TimeSpan Seconds(this int @this)
        {
            return TimeSpan.FromSeconds(@this);
        }

        /// <summary>
        /// Creates a <see cref="TimeSpan"/> with milliseconds equal to this.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static TimeSpan Milliseconds(this int @this)
        {
            return TimeSpan.FromMilliseconds(@this);
        }

        #endregion TimeSpan

        #region Roman Numerals

        private static readonly string[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        private static readonly string[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        private static readonly string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        private static readonly string[] M = { "", "M", "MM", "MMM", "" };

        /// <summary>
        /// Converts a number to roman representation (VII, IX, CD, CM, MMMXXVIII, etc.)
        /// </summary>
        /// <param name="this">Must be a number between 1 and 3999</param>
        /// <returns></returns>
        public static string ToRoman(this int @this)
        {
            if (@this is <= 0 or >= 4000)
            {
                return string.Empty;
            }

            return $"{M[@this / 1000]}{C[@this % 1000 / 100]}{X[@this % 100 / 10]}{I[@this % 10]}";
        }

        #endregion Roman Numerals
    }
}