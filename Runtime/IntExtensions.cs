using System;

namespace Mirzipan.Extensions
{
    public static class IntExtensions
    {
        #region TimeSpan

        public static TimeSpan Days(this int @this)
        {
            return TimeSpan.FromDays(@this);
        }

        public static TimeSpan Hours(this int @this)
        {
            return TimeSpan.FromHours(@this);
        }

        public static TimeSpan Minutes(this int @this)
        {
            return TimeSpan.FromMinutes(@this);
        }

        public static TimeSpan Seconds(this int @this)
        {
            return TimeSpan.FromSeconds(@this);
        }

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