using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class ColorExtensions
    {
        #region Get/Set

        public static Color WithR(this Color @this, float red) => new Color(red, @this.g, @this.b, @this.a);

        public static Color WithG(this Color @this, float green) => new Color(@this.r, green, @this.b, @this.a);

        public static Color WithB(this Color @this, float blue) => new Color(@this.r, @this.g, blue, @this.a);

        public static Color WithAlpha(this Color @this, float alpha) => new Color(@this.r, @this.g, @this.b, alpha);

        public static Color WithAlphaMultiplied(this Color @this, float multiplier)
        {
            return new Color(@this.r, @this.g, @this.b, @this.a * multiplier);
        }
        
        public static Color WithRGBMultiplied(this Color @this, float multiplier)
        {
            return new Color(@this.r * multiplier, @this.g * multiplier, @this.b * multiplier, @this.a);
        }

        #endregion Get/Set

        #region Equality

        /// <summary>
        /// Returns true if this <see cref="Color"/>'s alpha is 1 or within the tolerance of 1.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="tolerance"></param>
        /// <returns></returns>
        public static bool IsOpaque(this Color @this, float tolerance = float.Epsilon) => @this.a >= 1 - tolerance;

        /// <summary>
        /// Returns true if all components except for alpha are 1 or within the tolerance of 1.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="tolerance"></param>
        /// <returns></returns>
        public static bool IsWhite(this Color @this, float tolerance = float.Epsilon)
        {
            return @this.r + @this.g + @this.b >= 3 - tolerance;
        }

        /// <summary>
        /// Returns true if all components except for alpha are 0 or within the tolerance of 0.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="tolerance"></param>
        /// <returns></returns>
        public static bool IsBlack(this Color @this, float tolerance = float.Epsilon)
        {
            return @this.r + @this.g + @this.b <= tolerance;
        }

        /// <summary>
        /// Returns true if the greatest component of this <see cref="Color"/> is red.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsReddish(this Color @this) => @this.r > @this.g && @this.r > @this.b;

        /// <summary>
        /// Returns true if the greatest component of this <see cref="Color"/> is green.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsGreenish(this Color @this) => @this.g > @this.r && @this.g > @this.b;

        /// <summary>
        /// Returns true if the greatest component of this <see cref="Color"/> is blue.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsBlueish(this Color @this) => @this.b > @this.r && @this.b > @this.g;

        /// <summary>
        /// Returns true if this color's perceived brightness is high.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsLight(this Color @this) => @this.PerceivedBrightness() > 130;

        /// <summary>
        /// Returns true if this color's perceived brightness is low.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsDark(this Color @this) => @this.PerceivedBrightness() <= 130;

        #endregion Equality

        #region Misc

        /// <summary>
        /// Returns the inverted value of this <see cref="Color"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static Color Invert(this Color @this)
        {
            return new Color(1f - @this.r, 1f - @this.g, 1f - @this.b, @this.a);
        }

        /// <summary>
        /// Returns an opaque version of this <see cref="Color"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static Color Opaque(this Color @this) => new Color(@this.r, @this.g, @this.b, 1f);

        /// <summary>
        /// Returns this <see cref="Color"/> darkened.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="amount">Amount between 0 and 1 by which this color should be darkened</param>
        /// <returns></returns>
        public static Color Darken(this Color @this, float amount)
        {
            return new Color(@this.r - amount, @this.g - amount, @this.b - amount, @this.a);
        }

        /// <summary>
        /// Returns this <see cref="Color"/> lightened.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="amount">Amount between 0 and 1 by which this color should be lightened</param>
        /// <returns></returns>
        public static Color Lighten(this Color @this, float amount)
        {
            return new Color(@this.r + amount, @this.g + amount, @this.b + amount, @this.a);
        }

        /// <summary>
        /// Returns this <see cref="Color"/> darkened.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="percentage">Amount between 0% and 100% by which this color should be darkened</param>
        /// <returns></returns>
        public static Color Darken(this Color @this, int percentage)
        {
            return WithRGBMultiplied(@this, percentage / 100f);
        }

        /// <summary>
        /// Returns this <see cref="Color"/> lightened.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="percentage">Amount between 0% and 100% by which this color should be lightened</param>
        /// <returns></returns>
        public static Color Lightened(this Color @this, int percentage)
        {
            return WithRGBMultiplied(@this, -1f * percentage / 100f);
        }

        /// <summary>
        /// Returns a random <see cref="Color"/> that is darker than this.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static Color RandomDarker(this Color @this)
        {
            float r = Random.Range(0f, @this.r);
            float g = Random.Range(0f, @this.g);
            float b = Random.Range(0f, @this.b);
            return new Color(r, g, b);
        }

        /// <summary>
        /// Returns a random <see cref="Color"/> that is lighter than this.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static Color RandomLighter(this Color @this)
        {
            float r = Random.Range(@this.r, 1f);
            float g = Random.Range(@this.g, 1f);
            float b = Random.Range(@this.b, 1f);
            return new Color(r, g, b);
        }

        /// <summary>
        /// Returns the perceived brightness of this <see cref="Color"/> between 0 and 255.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static int PerceivedBrightness(this Color @this)
        {
            Color32 c = @this;
            return (int)System.Math.Sqrt(c.r * c.r * .299f + c.g * c.g * .587f + c.b * c.b * .114f);
        }

        /// <summary>
        /// Returns a suitable text color based on the perceived brightness of this <see cref="Color"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static Color VisibleTextColor(this Color @this)
        {
            return PerceivedBrightness(@this) > 130 ? Color.black : Color.white;
        }

        /// <summary>
        /// Linearly interpolates between two <see cref="Color"/>s using HSV space instead of the default RGB.
        /// </summary>
        /// <param name="a">Start color, returned when t = 0.</param>
        /// <param name="b">End color, returned when t = 1.</param>
        /// <param name="t">Value used to interpolate between a and b.</param>
        /// <returns></returns>
        public static Color LerpHSV(Color a, Color b, float t)
        {
            Color.RGBToHSV(a, out var aH, out var aS, out var aV);
            Color.RGBToHSV(b, out var bH, out var bS, out var bV);
            Color lerped = Color.HSVToRGB(aH + (bH - aH) * t, aS + (bS - aS) * t, aV + (bV - aV) * t);
            return lerped.WithAlpha(a.a + (b.a - a.a) * t);
        }

        #endregion Misc

        #region Clamp

        /// <summary>
        /// Clamps red, green, and blue components of this <see cref="Color"/> between min and max.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">Minimal value for each component (between 0 and 1)</param>
        /// <param name="max">Maximal value for each component (between 0 and 1)</param>
        /// <returns></returns>
        public static Color ClampRGB(this Color @this, float min, float max)
        {
            @this.r = Mathf.Clamp(@this.r, min, max);
            @this.g = Mathf.Clamp(@this.g, min, max);
            @this.b = Mathf.Clamp(@this.b, min, max);
            return @this;
        }

        /// <summary>
        /// Clamps all components of this <see cref="Color"/> between min and max.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">Minimal value for each component (between 0 and 1)</param>
        /// <param name="max">Maximal value for each component (between 0 and 1)</param>
        /// <returns></returns>
        public static Color Clamp(this Color @this, float min, float max)
        {
            @this.r = Mathf.Clamp(@this.r, min, max);
            @this.g = Mathf.Clamp(@this.g, min, max);
            @this.b = Mathf.Clamp(@this.b, min, max);
            @this.a = Mathf.Clamp(@this.a, min, max);
            return @this;
        }

        /// <summary>
        /// Clamps all components of this <see cref="Color"/> between min color and max color.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">Minimal color per each component</param>
        /// <param name="max">Maximal color per each component</param>
        /// <returns></returns>
        public static Color Clamp(this Color @this, Color min, Color max)
        {
            @this.r = Mathf.Max(min.r, @this.r);
            @this.r = Mathf.Min(max.r, @this.r);
            @this.g = Mathf.Max(min.g, @this.g);
            @this.g = Mathf.Min(max.g, @this.g);
            @this.b = Mathf.Max(min.b, @this.b);
            @this.b = Mathf.Min(max.b, @this.b);
            @this.a = Mathf.Max(min.a, @this.a);
            @this.a = Mathf.Min(max.a, @this.a);
            return @this;
        }

        #endregion Clamp
    }
}