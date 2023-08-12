using System.Globalization;

namespace Mirzipan.Extensions
{
    public static partial class StringExtensions
    {
        #region Queries

        /// <summary>
        /// Returns <see cref="int"/> value of this <see cref="string"/> if possible. If not, default value is returned.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="default"></param>
        /// <returns></returns>
        public static int ValueOrDefault(this string @this, int @default)
        {
            if (string.IsNullOrEmpty(@this) ||
                !int.TryParse(@this, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out var result))
            {
                return @default;
            }

            return result;
        }

        #endregion Queries
    }
}