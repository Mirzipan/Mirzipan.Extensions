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