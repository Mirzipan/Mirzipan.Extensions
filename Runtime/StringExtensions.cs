using System.Globalization;

namespace Mirzipan.Extensions
{
    public static class StringExtensions
    {
        #region String
        
        public static bool IsNullOrEmpty(this string @this) => string.IsNullOrEmpty(@this);
        
        public static bool NotNullOrEmpty(this string @this) => !string.IsNullOrEmpty(@this);

        public static bool IsNullOrWhitespace(this string @this) => string.IsNullOrWhiteSpace(@this);
        
        public static bool NotNullOrWhitespace(this string @this) => !string.IsNullOrWhiteSpace(@this);

        public static string ValueOrDefault(this string @this, string @default) => !string.IsNullOrEmpty(@this) ? @this : @default;

        public static string NullIfEmpty(this string @this) => !string.IsNullOrEmpty(@this) ? @this : null;

        public static string EmptyIfNull(this string @this) => !string.IsNullOrEmpty(@this) ? @this : string.Empty;

        #endregion String

        #region Int

        public static int ValueOrDefault(this string @this, int @default)
        {
            if (string.IsNullOrEmpty(@this) ||
                !int.TryParse(@this, NumberStyles.Integer, NumberFormatInfo.InvariantInfo, out var result))
            {
                return @default;
            }

            return result;
        }

        #endregion Int
    }
}