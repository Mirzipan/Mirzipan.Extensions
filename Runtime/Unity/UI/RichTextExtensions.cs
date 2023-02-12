using UnityEngine;

namespace Mirzipan.Extensions.Unity.UI
{
    public static class RichTextExtensions
    {
        public static string Colorize(this string @this, Color color)
        {
            return $"<color=#{ColorUtility.ToHtmlStringRGB(color)}>{@this}</color>";
        }
        
        public static string Bold(this string @this)
        {
            return $"<b>{@this}</b>";
        }
        
        public static string Italic(this string @this)
        {
            return $"<i>{@this}</i>";
        }
        
        public static string Underline(this string @this)
        {
            return $"<u>{@this}</u>";
        }
        
        public static string Underline(this string @this, Color color)
        {
            return $"<u color=#{ColorUtility.ToHtmlStringRGB(color)}>{@this}</u>";
        }
        
        public static string Strikethrough(this string @this)
        {
            return $"<s>{@this}</s>";
        }
        
        public static string Strikethrough(this string @this, Color color)
        {
            return $"<s color=#{ColorUtility.ToHtmlStringRGB(color)}>{@this}</s>";
        }

        public static string Lowercase(this string @this)
        {
            return $"<lowercase>{@this}</lowercase>";
        }

        public static string Uppercase(this string @this)
        {
            return $"<uppercase>{@this}</uppercase>";
        }

        public static string Smallcaps(this string @this)
        {
            return $"<smallcaps>{@this}</smallcaps>";
        }

        public static string Subscript(this string @this)
        {
            return $"<sub>{@this}</sub>";
        }

        public static string Superscript(this string @this)
        {
            return $"<sup>{@this}</sup>";
        }

        public static string Size(this string @this, int size)
        {
            return $"<size={size}%>{@this}</size>";
        }

        public static string LineHeight(this string @this, int height)
        {
            return $"<line-height={height}%>{@this}</line-height>";
        }

        public static string LineIndent(this string @this, int indent)
        {
            return $"<line-indent={indent}%>{@this}</line-indent>";
        }

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