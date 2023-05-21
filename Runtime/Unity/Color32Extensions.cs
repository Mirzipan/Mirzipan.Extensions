using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class Color32Extensions
    {
        #region Deconstruction
       
        public static void Deconstruct(this Color32 @this, out byte r, out byte g, out byte b)
        {
            r = @this.r;
            g = @this.g;
            b = @this.b;
        }
       
        public static void Deconstruct(this Color32 @this, out byte r, out byte g, out byte b, out byte a)
        {
            r = @this.r;
            g = @this.g;
            b = @this.b;
            a = @this.a;
        }

        #endregion Deconstruction
        
        #region Get/Set

        public static Color32 WithR(this Color32 @this, byte red) => new Color32(red, @this.g, @this.b, @this.a);

        public static Color32 WithG(this Color32 @this, byte green) => new Color32(@this.r, green, @this.b, @this.a);

        public static Color32 WithB(this Color32 @this, byte blue) => new Color32(@this.r, @this.g, blue, @this.a);

        public static Color32 WithAlpha(this Color32 @this, byte alpha) =>
            new Color32(@this.r, @this.g, @this.b, alpha);

        #endregion Get/Set

        #region Equality

        /// <summary>
        /// Returns true if both colors are equal.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool Equals(this Color32 @this, Color32 other)
        {
            return @this.r == other.r && @this.g == other.g && @this.b == other.b && @this.a == other.a;
        }

        /// <summary>
        /// Returns true if this <see cref="Color32"/>'s alpha is 255.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsOpaque(this Color32 @this) => @this.a == 255;

        /// <summary>
        /// Returns true if all components except for alpha are 255.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsWhite(this Color32 @this) => @this.Equals(Colors32.White);

        /// <summary>
        /// Returns true if all components except for alpha are 0.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsBlack(this Color32 @this) => @this.Equals(Colors32.Black);

        /// <summary>
        /// Returns true if the greatest component of this <see cref="Color32"/> is red.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsReddish(this Color32 @this) => @this.r > @this.g && @this.r > @this.b;

        /// <summary>
        /// Returns true if the greatest component of this <see cref="Color32"/> is green.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsGreenish(this Color32 @this) => @this.g > @this.r && @this.g > @this.b;

        /// <summary>
        /// Returns true if the greatest component of this <see cref="Color32"/> is blue.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsBlueish(this Color32 @this) => @this.b > @this.r && @this.b > @this.g;

        /// <summary>
        /// Returns true if this color's perceived brightness is high.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsLight(this Color32 @this) => @this.PerceivedBrightness() > 130;

        /// <summary>
        /// Returns true if this color's perceived brightness is low.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsDark(this Color32 @this) => @this.PerceivedBrightness() <= 130;

        #endregion Equality

        #region Misc

        /// <summary>
        /// Returns the inverted value of this <see cref="Color32"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static Color32 Invert(this Color32 @this)
        {
            return new Color32((byte)(255 - @this.r), (byte)(255 - @this.g), (byte)(255 - @this.b), @this.a);
        }

        /// <summary>
        /// Returns an opaque version of this <see cref="Color32"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static Color32 Opaque(this Color32 @this) => new Color32(@this.r, @this.g, @this.b, 255);

        /// <summary>
        /// Returns a random <see cref="Color32"/> that is darker than this.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static Color32 RandomDarker(this Color32 @this)
        {
            byte r = (byte)Random.Range(0, @this.r);
            byte g = (byte)Random.Range(0, @this.g);
            byte b = (byte)Random.Range(0, @this.b);
            return new Color32(r, g, b, @this.a);
        }

        /// <summary>
        /// Returns a random <see cref="Color32"/> that is lighter than this.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static Color32 RandomLighter(this Color32 @this)
        {
            byte r = (byte)Random.Range(@this.r, 255);
            byte g = (byte)Random.Range(@this.g, 255);
            byte b = (byte)Random.Range(@this.b, 255);
            return new Color32(r, g, b, @this.a);
        }

        /// <summary>
        /// Returns the perceived brightness of this <see cref="Color32"/> between 0 and 255.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static int PerceivedBrightness(this Color32 @this)
        {
            Color32 c = @this;
            return (int)System.Math.Sqrt(c.r * c.r * .299f + c.g * c.g * .587f + c.b * c.b * .114f);
        }

        /// <summary>
        /// Returns a suitable text color based on the perceived brightness of this <see cref="Color32"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static Color32 VisibleTextColor(this Color32 @this)
        {
            return PerceivedBrightness(@this) > 130 ? Colors32.Black : Colors32.White;
        }

        #endregion Misc
        
        #region Clamp

        /// <summary>
        /// Clamps red, green, and blue components of this <see cref="Color32"/> between min and max.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">Minimal value for each component (between 0 and 255)</param>
        /// <param name="max">Maximal value for each component (between 0 and 255)</param>
        /// <returns></returns>
        public static Color32 ClampRGB(this Color32 @this, float min, float max)
        {
            @this.r = (byte)Mathf.Clamp(@this.r, min, max);
            @this.g = (byte)Mathf.Clamp(@this.g, min, max);
            @this.b = (byte)Mathf.Clamp(@this.b, min, max);
            return @this;
        }

        /// <summary>
        /// Clamps all components of this <see cref="Color32"/> between min and max.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">Minimal value for each component (between 0 and 255)</param>
        /// <param name="max">Maximal value for each component (between 0 and 255)</param>
        /// <returns></returns>
        public static Color32 Clamp(this Color32 @this, float min, float max)
        {
            @this.r = (byte)Mathf.Clamp(@this.r, min, max);
            @this.g = (byte)Mathf.Clamp(@this.g, min, max);
            @this.b = (byte)Mathf.Clamp(@this.b, min, max);
            @this.a = (byte)Mathf.Clamp(@this.a, min, max);
            return @this;
        }

        /// <summary>
        /// Clamps all components of this <see cref="Color32"/> between min color and max color.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min">Minimal color per each component</param>
        /// <param name="max">Maximal color per each component</param>
        /// <returns></returns>
        public static Color32 Clamp(this Color32 @this, Color32 min, Color32 max)
        {
            @this.r = (byte)Mathf.Max(min.r, @this.r);
            @this.r = (byte)Mathf.Min(max.r, @this.r);
            @this.g = (byte)Mathf.Max(min.g, @this.g);
            @this.g = (byte)Mathf.Min(max.g, @this.g);
            @this.b = (byte)Mathf.Max(min.b, @this.b);
            @this.b = (byte)Mathf.Min(max.b, @this.b);
            @this.a = (byte)Mathf.Max(min.a, @this.a);
            @this.a = (byte)Mathf.Min(max.a, @this.a);
            return @this;
        }

        #endregion Clamp
    }
}