using UnityEngine;

namespace Mirzipan.Extensions.Unity.Math
{
    public static partial class Vector2Extensions
    {
        #region Swizzle

        public static Vector2 XX(this Vector2 @this) => new Vector2(@this.x, @this.x);

        public static Vector2 YY(this Vector2 @this) => new Vector2(@this.y, @this.y);

        public static Vector2 XY(this Vector2 @this) => new Vector2(@this.x, @this.y);

        public static Vector2 YX(this Vector2 @this) => new Vector2(@this.y, @this.x);

        public static void XY(ref this Vector2 @this, Vector2 other)
        {
            @this.x = other.x;
            @this.y = other.y;
        }

        public static void YX(ref this Vector2 @this, Vector2 other)
        {
            @this.y = other.x;
            @this.x = other.y;
        }

        #endregion Swizzle
    }
}