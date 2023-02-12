using UnityEngine;

namespace Mirzipan.Extensions
{
    public static partial class Vector3Extensions
    {
        #region Swizzle

        #region V3 With X

        public static Vector3 XXX(this Vector3 @this)
        {
            return new Vector3(@this.x, @this.x, @this.x);
        }

        public static Vector3 XXY(this Vector3 @this)
        {
            return new Vector3(@this.x, @this.x, @this.y);
        }

        public static Vector3 XXZ(this Vector3 @this)
        {
            return new Vector3(@this.x, @this.x, @this.z);
        }

        public static Vector3 XYX(this Vector3 @this)
        {
            return new Vector3(@this.x, @this.y, @this.x);
        }

        public static Vector3 XYY(this Vector3 @this)
        {
            return new Vector3(@this.x, @this.y, @this.y);
        }

        public static Vector3 XYZ(this Vector3 @this)
        {
            return new Vector3(@this.x, @this.y, @this.z);
        }

        public static Vector3 XZX(this Vector3 @this)
        {
            return new Vector3(@this.x, @this.z, @this.x);
        }

        public static Vector3 XZY(this Vector3 @this)
        {
            return new Vector3(@this.x, @this.z, @this.y);
        }

        public static Vector3 XZZ(this Vector3 @this)
        {
            return new Vector3(@this.x, @this.z, @this.z);
        }

        public static void XYZ(ref this Vector3 @this, Vector3 other)
        {
            @this.x = other.x;
            @this.y = other.y;
            @this.z = other.z;
        }

        public static void XZY(ref this Vector3 @this, Vector3 other)
        {
            @this.x = other.x;
            @this.z = other.y;
            @this.y = other.z;
        }

        #endregion V3 With X

        #region V3 With Y

        public static Vector3 YXX(this Vector3 @this)
        {
            return new Vector3(@this.y, @this.x, @this.x);
        }

        public static Vector3 YXY(this Vector3 @this)
        {
            return new Vector3(@this.y, @this.x, @this.y);
        }

        public static Vector3 YXZ(this Vector3 @this)
        {
            return new Vector3(@this.y, @this.x, @this.z);
        }

        public static Vector3 YYX(this Vector3 @this)
        {
            return new Vector3(@this.y, @this.y, @this.x);
        }

        public static Vector3 YYY(this Vector3 @this)
        {
            return new Vector3(@this.y, @this.y, @this.y);
        }

        public static Vector3 YYZ(this Vector3 @this)
        {
            return new Vector3(@this.y, @this.y, @this.z);
        }

        public static Vector3 YZX(this Vector3 @this)
        {
            return new Vector3(@this.y, @this.z, @this.x);
        }

        public static Vector3 YZY(this Vector3 @this)
        {
            return new Vector3(@this.y, @this.z, @this.y);
        }

        public static Vector3 YZZ(this Vector3 @this)
        {
            return new Vector3(@this.y, @this.z, @this.z);
        }

        public static void YXZ(ref this Vector3 @this, Vector3 other)
        {
            @this.y = other.x;
            @this.x = other.y;
            @this.z = other.z;
        }

        public static void YZX(ref this Vector3 @this, Vector3 other)
        {
            @this.y = other.x;
            @this.z = other.y;
            @this.x = other.z;
        }

        #endregion V3 With Y

        #region V3 With Z

        public static Vector3 ZXX(this Vector3 @this)
        {
            return new Vector3(@this.z, @this.x, @this.x);
        }

        public static Vector3 ZXY(this Vector3 @this)
        {
            return new Vector3(@this.z, @this.x, @this.y);
        }

        public static Vector3 ZXZ(this Vector3 @this)
        {
            return new Vector3(@this.z, @this.x, @this.z);
        }

        public static Vector3 ZYX(this Vector3 @this)
        {
            return new Vector3(@this.z, @this.y, @this.x);
        }

        public static Vector3 ZYY(this Vector3 @this)
        {
            return new Vector3(@this.z, @this.y, @this.y);
        }

        public static Vector3 ZYZ(this Vector3 @this)
        {
            return new Vector3(@this.z, @this.y, @this.z);
        }

        public static Vector3 ZZX(this Vector3 @this)
        {
            return new Vector3(@this.z, @this.z, @this.x);
        }

        public static Vector3 ZZY(this Vector3 @this)
        {
            return new Vector3(@this.z, @this.z, @this.y);
        }

        public static Vector3 ZZZ(this Vector3 @this)
        {
            return new Vector3(@this.z, @this.z, @this.z);
        }

        public static void ZXY(ref this Vector3 @this, Vector3 other)
        {
            @this.z = other.x;
            @this.x = other.y;
            @this.y = other.z;
        }

        public static void ZYX(ref this Vector3 @this, Vector3 other)
        {
            @this.z = other.x;
            @this.y = other.y;
            @this.x = other.z;
        }

        #endregion V3 With Z

        #region V2

        public static Vector2 XX(this Vector3 @this)
        {
            return new Vector2(@this.x, @this.x);
        }

        public static Vector2 XY(this Vector3 @this)
        {
            return new Vector2(@this.x, @this.y);
        }

        public static Vector2 XZ(this Vector3 @this)
        {
            return new Vector2(@this.x, @this.z);
        }

        public static Vector2 YX(this Vector3 @this)
        {
            return new Vector2(@this.y, @this.x);
        }

        public static Vector2 YY(this Vector3 @this)
        {
            return new Vector2(@this.y, @this.y);
        }

        public static Vector2 YZ(this Vector3 @this)
        {
            return new Vector2(@this.y, @this.z);
        }

        public static Vector2 ZX(this Vector3 @this)
        {
            return new Vector2(@this.z, @this.x);
        }

        public static Vector2 ZY(this Vector3 @this)
        {
            return new Vector2(@this.z, @this.y);
        }

        public static Vector2 ZZ(this Vector3 @this)
        {
            return new Vector2(@this.z, @this.z);
        }

        public static void XY(ref this Vector3 @this, Vector2 other)
        {
            @this.x = other.x;
            @this.y = other.y;
        }

        public static void XZ(ref this Vector3 @this, Vector2 other)
        {
            @this.x = other.x;
            @this.z = other.y;
        }

        public static void YX(ref this Vector3 @this, Vector2 other)
        {
            @this.y = other.x;
            @this.x = other.y;
        }

        public static void YZ(ref this Vector3 @this, Vector2 other)
        {
            @this.y = other.x;
            @this.z = other.y;
        }

        public static void ZX(ref this Vector3 @this, Vector2 other)
        {
            @this.z = other.x;
            @this.x = other.y;
        }

        public static void ZY(ref this Vector3 @this, Vector2 other)
        {
            @this.z = other.x;
            @this.y = other.y;
        }

        #endregion V2

        #endregion Swizzle
    }
}