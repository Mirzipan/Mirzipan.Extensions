using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class ColorExtensions
    {
        public static Color Darken(this Color @this, float amount)
        {
            return new Color(@this.r - amount, @this.g - amount, @this.b - amount, @this.a);
        }

        public static Color Lighten(this Color @this, float amount)
        {
            return new Color(@this.r + amount, @this.g + amount, @this.b + amount, @this.a);
        }

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
    }
}