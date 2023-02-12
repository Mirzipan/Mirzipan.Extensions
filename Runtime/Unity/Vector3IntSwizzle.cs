using UnityEngine;

namespace Mirzipan.Extensions
{
    public static partial class Vector3IntExtensions
    {
        #region Swizzle

        #region V3 With X

        public static Vector3Int XXX(this Vector3Int @this)
        {
            return new Vector3Int(@this.x, @this.x, @this.x);
        }

        public static Vector3Int XXY(this Vector3Int @this)
        {
            return new Vector3Int(@this.x, @this.x, @this.y);
        }

        public static Vector3Int XXZ(this Vector3Int @this)
        {
            return new Vector3Int(@this.x, @this.x, @this.z);
        }

        public static Vector3Int XYX(this Vector3Int @this)
        {
            return new Vector3Int(@this.x, @this.y, @this.x);
        }

        public static Vector3Int XYY(this Vector3Int @this)
        {
            return new Vector3Int(@this.x, @this.y, @this.y);
        }

        public static Vector3Int XYZ(this Vector3Int @this)
        {
            return new Vector3Int(@this.x, @this.y, @this.z);
        }

        public static Vector3Int XZX(this Vector3Int @this)
        {
            return new Vector3Int(@this.x, @this.z, @this.x);
        }

        public static Vector3Int XZY(this Vector3Int @this)
        {
            return new Vector3Int(@this.x, @this.z, @this.y);
        }

        public static Vector3Int XZZ(this Vector3Int @this)
        {
            return new Vector3Int(@this.x, @this.z, @this.z);
        }

        public static void XYZ(ref this Vector3Int @this, Vector3Int other)
        {
            @this.x = other.x;
            @this.y = other.y;
            @this.z = other.z;
        }

        public static void XZY(ref this Vector3Int @this, Vector3Int other)
        {
            @this.x = other.x;
            @this.z = other.y;
            @this.y = other.z;
        }

        #endregion V3 With X

        #region V3 With Y

        public static Vector3Int YXX(this Vector3Int @this)
        {
            return new Vector3Int(@this.y, @this.x, @this.x);
        }

        public static Vector3Int YXY(this Vector3Int @this)
        {
            return new Vector3Int(@this.y, @this.x, @this.y);
        }

        public static Vector3Int YXZ(this Vector3Int @this)
        {
            return new Vector3Int(@this.y, @this.x, @this.z);
        }

        public static Vector3Int YYX(this Vector3Int @this)
        {
            return new Vector3Int(@this.y, @this.y, @this.x);
        }

        public static Vector3Int YYY(this Vector3Int @this)
        {
            return new Vector3Int(@this.y, @this.y, @this.y);
        }

        public static Vector3Int YYZ(this Vector3Int @this)
        {
            return new Vector3Int(@this.y, @this.y, @this.z);
        }

        public static Vector3Int YZX(this Vector3Int @this)
        {
            return new Vector3Int(@this.y, @this.z, @this.x);
        }

        public static Vector3Int YZY(this Vector3Int @this)
        {
            return new Vector3Int(@this.y, @this.z, @this.y);
        }

        public static Vector3Int YZZ(this Vector3Int @this)
        {
            return new Vector3Int(@this.y, @this.z, @this.z);
        }

        public static void YXZ(ref this Vector3Int @this, Vector3Int other)
        {
            @this.y = other.x;
            @this.x = other.y;
            @this.z = other.z;
        }

        public static void YZX(ref this Vector3Int @this, Vector3Int other)
        {
            @this.y = other.x;
            @this.z = other.y;
            @this.x = other.z;
        }

        #endregion V3 With Y

        #region V3 With Z

        public static Vector3Int ZXX(this Vector3Int @this)
        {
            return new Vector3Int(@this.z, @this.x, @this.x);
        }

        public static Vector3Int ZXY(this Vector3Int @this)
        {
            return new Vector3Int(@this.z, @this.x, @this.y);
        }

        public static Vector3Int ZXZ(this Vector3Int @this)
        {
            return new Vector3Int(@this.z, @this.x, @this.z);
        }

        public static Vector3Int ZYX(this Vector3Int @this)
        {
            return new Vector3Int(@this.z, @this.y, @this.x);
        }

        public static Vector3Int ZYY(this Vector3Int @this)
        {
            return new Vector3Int(@this.z, @this.y, @this.y);
        }

        public static Vector3Int ZYZ(this Vector3Int @this)
        {
            return new Vector3Int(@this.z, @this.y, @this.z);
        }

        public static Vector3Int ZZX(this Vector3Int @this)
        {
            return new Vector3Int(@this.z, @this.z, @this.x);
        }

        public static Vector3Int ZZY(this Vector3Int @this)
        {
            return new Vector3Int(@this.z, @this.z, @this.y);
        }

        public static Vector3Int ZZZ(this Vector3Int @this)
        {
            return new Vector3Int(@this.z, @this.z, @this.z);
        }

        public static void ZXY(ref this Vector3Int @this, Vector3Int other)
        {
            @this.z = other.x;
            @this.x = other.y;
            @this.y = other.z;
        }

        public static void ZYX(ref this Vector3Int @this, Vector3Int other)
        {
            @this.z = other.x;
            @this.y = other.y;
            @this.x = other.z;
        }

        #endregion V3 With Z

        #region V2

        public static Vector2Int XX(this Vector3Int @this)
        {
            return new Vector2Int(@this.x, @this.x);
        }

        public static Vector2Int XY(this Vector3Int @this)
        {
            return new Vector2Int(@this.x, @this.y);
        }

        public static Vector2Int XZ(this Vector3Int @this)
        {
            return new Vector2Int(@this.x, @this.z);
        }

        public static Vector2Int YX(this Vector3Int @this)
        {
            return new Vector2Int(@this.y, @this.x);
        }

        public static Vector2Int YY(this Vector3Int @this)
        {
            return new Vector2Int(@this.y, @this.y);
        }

        public static Vector2Int YZ(this Vector3Int @this)
        {
            return new Vector2Int(@this.y, @this.z);
        }

        public static Vector2Int ZX(this Vector3Int @this)
        {
            return new Vector2Int(@this.z, @this.x);
        }

        public static Vector2Int ZY(this Vector3Int @this)
        {
            return new Vector2Int(@this.z, @this.y);
        }

        public static Vector2Int ZZ(this Vector3Int @this)
        {
            return new Vector2Int(@this.z, @this.z);
        }

        public static void XY(ref this Vector3Int @this, Vector2Int other)
        {
            @this.x = other.x;
            @this.y = other.y;
        }

        public static void XZ(ref this Vector3Int @this, Vector2Int other)
        {
            @this.x = other.x;
            @this.z = other.y;
        }

        public static void YX(ref this Vector3Int @this, Vector2Int other)
        {
            @this.y = other.x;
            @this.x = other.y;
        }

        public static void YZ(ref this Vector3Int @this, Vector2Int other)
        {
            @this.y = other.x;
            @this.z = other.y;
        }

        public static void ZX(ref this Vector3Int @this, Vector2Int other)
        {
            @this.z = other.x;
            @this.x = other.y;
        }

        public static void ZY(ref this Vector3Int @this, Vector2Int other)
        {
            @this.z = other.x;
            @this.y = other.y;
        }

        #endregion V2

        #endregion Swizzle
    }
}