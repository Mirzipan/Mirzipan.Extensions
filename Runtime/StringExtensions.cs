namespace Mirzipan.Extensions
{
    public static partial class StringExtensions
    {
        #region Queries
        
        /// <summary>
        /// Returns true if this <see cref="string"/> is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string @this) => string.IsNullOrEmpty(@this);
        
        /// <summary>
        /// Returns true if this <see cref="string"/> is not null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool NotNullOrEmpty(this string @this) => !string.IsNullOrEmpty(@this);

        /// <summary>
        /// Returns true if this <see cref="string"/> is null or whitespace.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsNullOrWhitespace(this string @this) => string.IsNullOrWhiteSpace(@this);
        
        /// <summary>
        /// Returns true if this <see cref="string"/> is not null or whitespace.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool NotNullOrWhitespace(this string @this) => !string.IsNullOrWhiteSpace(@this);

        /// <summary>
        /// Returns this if this <see cref="string"/> is not null or empty, otherwise default value is returned.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="default"></param>
        /// <returns></returns>
        public static string ValueOrDefault(this string @this, string @default) => !string.IsNullOrEmpty(@this) ? @this : @default;

        /// <summary>
        /// Returns null if this <see cref="string"/> is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string NullIfEmpty(this string @this) => !string.IsNullOrEmpty(@this) ? @this : null;

        /// <summary>
        /// Returns empty <see cref="string"/> if this is null or empty.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string EmptyIfNull(this string @this) => !string.IsNullOrEmpty(@this) ? @this : string.Empty;

        #endregion Queries
    }
}