using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class Vector4Extensions
    {
        #region Validation

        public static bool IsNaN(this Vector4 @this)
        {
            return float.IsNaN(@this.x) || float.IsNaN(@this.y) || float.IsNaN(@this.z) || float.IsNaN(@this.w);
        }

        #endregion Validation
        
        #region Get/Set
        
        public static Vector4 WithX(this Vector4 @this, float x)
        {
            return new Vector4(x, @this.y, @this.z, @this.w);
        }
        
        public static Vector4 WithY(this Vector4 @this, float y)
        {
            return new Vector4(@this.x, y, @this.z, @this.w);
        }
        
        public static Vector4 WithZ(this Vector4 @this, float z)
        {
            return new Vector4(@this.x, @this.y, z, @this.w);
        }
        
        public static Vector4 WithW(this Vector4 @this, float w)
        {
            return new Vector4(@this.x, @this.y, @this.z, w);
        }

        public static Vector4 XXXX(this Vector4 @this)
        {
            return new Vector4(@this.x, @this.x, @this.x, @this.x);
        }

        public static Vector4 YYYY(this Vector4 @this)
        {
            return new Vector4(@this.y, @this.y, @this.y, @this.y);
        }

        public static Vector4 ZZZZ(this Vector4 @this)
        {
            return new Vector4(@this.z, @this.z, @this.z, @this.z);
        }

        public static Vector4 WWWW(this Vector4 @this)
        {
            return new Vector4(@this.w, @this.w, @this.w, @this.w);
        }

        public static Vector3 XXX(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.x, @this.x);
        }

        public static Vector3 YYY(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.y, @this.y);
        }

        public static Vector3 ZZZ(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.z, @this.z);
        }

        public static Vector3 WWW(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.w, @this.w);
        }

        public static Vector2 XX(this Vector4 @this)
        {
            return new Vector2(@this.x, @this.x);
        }

        public static Vector2 YY(this Vector4 @this)
        {
            return new Vector2(@this.y, @this.y);
        }

        public static Vector2 ZZ(this Vector4 @this)
        {
            return new Vector2(@this.z, @this.z);
        }

        public static Vector2 WW(this Vector4 @this)
        {
            return new Vector2(@this.w, @this.w);
        }

        public static Vector2 XY(this Vector4 @this)
        {
            return new Vector2(@this.x, @this.y);
        }

        public static Vector2 XZ(this Vector4 @this)
        {
            return new Vector2(@this.x, @this.z);
        }

        public static Vector2 XW(this Vector4 @this)
        {
            return new Vector2(@this.x, @this.w);
        }

        public static Vector2 YX(this Vector4 @this)
        {
            return new Vector2(@this.y, @this.x);
        }

        public static Vector2 YZ(this Vector4 @this)
        {
            return new Vector2(@this.y, @this.z);
        }

        public static Vector2 YW(this Vector4 @this)
        {
            return new Vector2(@this.y, @this.w);
        }

        public static Vector2 ZX(this Vector4 @this)
        {
            return new Vector2(@this.z, @this.x);
        }

        public static Vector2 ZY(this Vector4 @this)
        {
            return new Vector2(@this.z, @this.y);
        }

        public static Vector2 ZW(this Vector4 @this)
        {
            return new Vector2(@this.z, @this.w);
        }

        public static Vector2 WX(this Vector4 @this)
        {
            return new Vector2(@this.w, @this.x);
        }

        public static Vector2 WY(this Vector4 @this)
        {
            return new Vector2(@this.w, @this.y);
        }

        public static Vector2 WZ(this Vector4 @this)
        {
            return new Vector2(@this.w, @this.z);
        }

        #endregion Get/Set

        #region Clamp

        public static Vector4 Clamp01(this Vector4 @this)
        {
            return Clamp(@this, 0f, 1f);
        }

        public static Vector4 Clamp(this Vector4 @this, float min, float max)
        {
            @this.x = Mathf.Clamp(@this.x, min, max);
            @this.y = Mathf.Clamp(@this.y, min, max);
            @this.z = Mathf.Clamp(@this.z, min, max);
            @this.w = Mathf.Clamp(@this.w, min, max);
            return @this;
        }

        public static Vector4 Clamp(this Vector4 @this, Vector4 min, Vector4 max)
        {
            @this.x = Mathf.Clamp(@this.x, min.x, max.x);
            @this.y = Mathf.Clamp(@this.y, min.y, max.y);
            @this.z = Mathf.Clamp(@this.z, min.z, max.z);
            @this.w = Mathf.Clamp(@this.w, min.w, max.w);
            return @this;
        }

        #endregion Clamp
    }
}