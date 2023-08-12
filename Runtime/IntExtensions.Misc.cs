namespace Mirzipan.Extensions
{
    public static partial class IntExtensions
    {
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