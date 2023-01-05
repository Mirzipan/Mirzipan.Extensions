using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class ColorExtensions
    {
        #region Get/Set

        public static Color WithR(this Color @this, float red)
        {
            return new Color(red, @this.g, @this.b, @this.a);
        }

        public static Color WithG(this Color @this, float green)
        {
            return new Color(@this.r, green, @this.b, @this.a);
        }

        public static Color WithB(this Color @this, float blue)
        {
            return new Color(@this.r, @this.g, blue, @this.a);
        }
        
        public static Color WithAlpha(this Color @this, float alpha)
        {
            return new Color(@this.r, @this.g, @this.b, alpha);
        }
        
        public static Color WithAlphaMultiplied(this Color @this, float multiplier)
        {
            return new Color(@this.r, @this.g, @this.b, @this.a * multiplier);
        }
        
        public static Color WithRGBMultiplied(this Color @this, float multiplier)
        {
            return new Color(@this.r * multiplier, @this.g * multiplier, @this.b * multiplier, @this.a);
        }

        #endregion Get/Set

        #region Misc
        
        public static Color Darken(this Color @this, float amount)
        {
            return new Color(@this.r - amount, @this.g - amount, @this.b - amount, @this.a);
        }

        public static Color Lighten(this Color @this, float amount)
        {
            return new Color(@this.r + amount, @this.g + amount, @this.b + amount, @this.a);
        }

        public static Color RandomDarker(this Color @this)
        {
            float r = Random.Range(0f, @this.r);
            float g = Random.Range(0f, @this.g);
            float b = Random.Range(0f, @this.b);
            return new Color(r, g, b);
        }

        public static Color RandomLighter(this Color @this)
        {
            float r = Random.Range(@this.r, 1f);
            float g = Random.Range(@this.g, 1f);
            float b = Random.Range(@this.b, 1f);
            return new Color(r, g, b);
        }

        public static Color LerpHSV(Color a, Color b, float t)
        {
            Color.RGBToHSV(a, out var aH, out var aS, out var aV);
            Color.RGBToHSV(b, out var bH, out var bS, out var bV);
            Color lerped = Color.HSVToRGB(aH + (bH - aH) * t, aS + (bS - aS) * t, aV + (bV - aV) * t);
            return lerped.WithAlpha(a.a + (b.a - a.a) * t);
        }

        #endregion Misc

        #region Clamp

        public static Color ClampRGB(this Color @this, float min, float max)
        {
            @this.r = Mathf.Clamp(@this.r, min, max);
            @this.g = Mathf.Clamp(@this.g, min, max);
            @this.b = Mathf.Clamp(@this.b, min, max);
            return @this;
        }

        public static Color Clamp(this Color @this, float min, float max)
        {
            @this.r = Mathf.Clamp(@this.r, min, max);
            @this.g = Mathf.Clamp(@this.g, min, max);
            @this.b = Mathf.Clamp(@this.b, min, max);
            @this.a = Mathf.Clamp(@this.a, min, max);
            return @this;
        }

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