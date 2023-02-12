using UnityEngine;

namespace Mirzipan.Extensions.Unity.Math
{
    public static partial class Vector2IntExtensions
    {
        #region Swizzle

        public static Vector2Int XX(this Vector2Int @this) => new Vector2Int(@this.x, @this.x);
        public static Vector2Int YY(this Vector2Int @this) => new Vector2Int(@this.y, @this.y);
        public static Vector2Int YX(this Vector2Int @this) => new Vector2Int(@this.y, @this.x);
        public static Vector2Int XY(this Vector2Int @this) => new Vector2Int(@this.x, @this.y);

        public static void XY(ref this Vector2Int @this, Vector2Int other)
        {
            @this.x = other.x;
            @this.y = other.y;
        }

        public static void YX(ref this Vector2Int @this, Vector2Int other)
        {
            @this.y = other.x;
            @this.x = other.y;
        }

        #endregion Swizzle
    }
}