using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class RichTextExtensions
    {
        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to change its color.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="color">Color of the text</param>
        /// <returns></returns>
        public static string Colorize(this string @this, Color color)
        {
            return $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{@this}</color>";
        }
        
        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to make it bold.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string Bold(this string @this) => $"<b>{@this}</b>";

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to make it italic.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string Italic(this string @this) => $"<i>{@this}</i>";

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to make it underlined.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string Underline(this string @this) => $"<u>{@this}</u>";

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to make it underlined.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="color">Color of the underline</param>
        /// <returns></returns>
        public static string Underline(this string @this, Color color)
        {
            return $"<u color=#{ColorUtility.ToHtmlStringRGB(color)}>{@this}</u>";
        }
        
        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to make it strikethrough.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string Strikethrough(this string @this) => $"<s>{@this}</s>";

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to make it strikethrough.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="color">Color of the strikethrough line</param>
        /// <returns></returns>
        public static string Strikethrough(this string @this, Color color)
        {
            return $"<s color=#{ColorUtility.ToHtmlStringRGB(color)}>{@this}</s>";
        }

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to make it lowercase.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string Lowercase(this string @this) => $"<lowercase>{@this}</lowercase>";

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to make it uppercase.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string Uppercase(this string @this) => $"<uppercase>{@this}</uppercase>";

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to make it smallcaps.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string Smallcaps(this string @this) => $"<smallcaps>{@this}</smallcaps>";

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to make it subscript.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string Subscript(this string @this) => $"<sub>{@this}</sub>";

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to make it superscript.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string Superscript(this string @this) => $"<sup>{@this}</sup>";

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to change its size.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="size">Text size in percentage</param>
        /// <returns></returns>
        public static string Size(this string @this, int size) => $"<size={size}%>{@this}</size>";

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to change its line height.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="height">New line height for this text</param>
        /// <returns></returns>
        public static string LineHeight(this string @this, int height)
        {
            return $"<line-height={height}%>{@this}</line-height>";
        }

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to change its line indent.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="indent">New line height for this text</param>
        /// <returns></returns>
        public static string LineIndent(this string @this, int indent)
        {
            return $"<line-indent={indent}%>{@this}</line-indent>";
        }

        /// <summary>
        /// Surrounds this <see cref="string"/> with the RichText tags to change its alignment.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="side">Side this text should be aligned to</param>
        /// <returns></returns>
        public static string Align(this string @this, TextAlignment side)
        {
            return side switch
            {
                TextAlignment.Left => $"<align=\"left\">{@this}</align>",
                TextAlignment.Center => $"<align=\"center\">{@this}</align>",
                TextAlignment.Right => $"<align=\"right\">{@this}</align>",
                _ => @this
            };
        }
    }
}