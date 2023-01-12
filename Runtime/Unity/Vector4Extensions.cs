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

        #region V3 With X
        
        public static Vector3 XXX(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.x, @this.x);
        }

        public static Vector3 XXY(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.x, @this.y);
        }

        public static Vector3 XXZ(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.x, @this.z);
        }

        public static Vector3 XXW(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.x, @this.w);
        }

        public static Vector3 XYX(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.y, @this.x);
        }

        public static Vector3 XYY(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.y, @this.y);
        }

        public static Vector3 XYZ(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.y, @this.z);
        }

        public static Vector3 XYW(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.y, @this.w);
        }

        public static Vector3 XZX(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.z, @this.x);
        }

        public static Vector3 XZY(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.z, @this.y);
        }

        public static Vector3 XZZ(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.z, @this.z);
        }

        public static Vector3 XZW(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.z, @this.w);
        }

        public static Vector3 XWX(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.w, @this.x);
        }

        public static Vector3 XWY(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.w, @this.y);
        }

        public static Vector3 XWZ(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.w, @this.z);
        }

        public static Vector3 XWW(this Vector4 @this)
        {
            return new Vector3(@this.x, @this.w, @this.w);
        }

        #endregion V3 With X
        
        #region V3 With Y
        
        public static Vector3 YXX(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.x, @this.x);
        }

        public static Vector3 YXY(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.x, @this.y);
        }

        public static Vector3 YXZ(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.x, @this.z);
        }

        public static Vector3 YXW(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.x, @this.w);
        }

        public static Vector3 YYX(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.y, @this.x);
        }

        public static Vector3 YYY(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.y, @this.y);
        }

        public static Vector3 YYZ(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.y, @this.z);
        }

        public static Vector3 YYW(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.y, @this.w);
        }

        public static Vector3 YZX(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.z, @this.x);
        }

        public static Vector3 YZY(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.z, @this.y);
        }

        public static Vector3 YZZ(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.z, @this.z);
        }

        public static Vector3 YZW(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.z, @this.w);
        }

        public static Vector3 YWX(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.w, @this.x);
        }

        public static Vector3 YWY(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.w, @this.y);
        }

        public static Vector3 YWZ(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.w, @this.z);
        }

        public static Vector3 YWW(this Vector4 @this)
        {
            return new Vector3(@this.y, @this.w, @this.w);
        }

        #endregion V3 With Y
        
        #region V3 With Z
        
        public static Vector3 ZXX(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.x, @this.x);
        }

        public static Vector3 ZXY(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.x, @this.y);
        }

        public static Vector3 ZXZ(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.x, @this.z);
        }

        public static Vector3 ZXW(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.x, @this.w);
        }

        public static Vector3 ZYX(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.y, @this.x);
        }

        public static Vector3 ZYY(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.y, @this.y);
        }

        public static Vector3 ZYZ(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.y, @this.z);
        }

        public static Vector3 ZYW(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.y, @this.w);
        }

        public static Vector3 ZZX(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.z, @this.x);
        }

        public static Vector3 ZZY(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.z, @this.y);
        }

        public static Vector3 ZZZ(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.z, @this.z);
        }

        public static Vector3 ZZW(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.z, @this.w);
        }

        public static Vector3 ZWX(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.w, @this.x);
        }

        public static Vector3 ZWY(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.w, @this.y);
        }

        public static Vector3 ZWZ(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.w, @this.z);
        }

        public static Vector3 ZWW(this Vector4 @this)
        {
            return new Vector3(@this.z, @this.w, @this.w);
        }

        #endregion V3 With Z
        
        #region V3 With W
        
        public static Vector3 WXX(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.x, @this.x);
        }

        public static Vector3 WXY(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.x, @this.y);
        }

        public static Vector3 WXZ(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.x, @this.z);
        }

        public static Vector3 WXW(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.x, @this.w);
        }

        public static Vector3 WYX(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.y, @this.x);
        }

        public static Vector3 WYY(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.y, @this.y);
        }

        public static Vector3 WYZ(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.y, @this.z);
        }

        public static Vector3 WYW(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.y, @this.w);
        }

        public static Vector3 WZX(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.z, @this.x);
        }

        public static Vector3 WZY(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.z, @this.y);
        }

        public static Vector3 WZZ(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.z, @this.z);
        }

        public static Vector3 WZW(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.z, @this.w);
        }

        public static Vector3 WWX(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.w, @this.x);
        }

        public static Vector3 WWY(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.w, @this.y);
        }

        public static Vector3 WWZ(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.w, @this.z);
        }

        public static Vector3 WWW(this Vector4 @this)
        {
            return new Vector3(@this.w, @this.w, @this.w);
        }

        #endregion V3 With W

        #region V2

        public static Vector2 XX(this Vector4 @this)
        {
            return new Vector2(@this.x, @this.x);
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

        public static Vector2 YY(this Vector4 @this)
        {
            return new Vector2(@this.y, @this.y);
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

        public static Vector2 ZZ(this Vector4 @this)
        {
            return new Vector2(@this.z, @this.z);
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

        public static Vector2 WW(this Vector4 @this)
        {
            return new Vector2(@this.w, @this.w);
        }

        #endregion V2

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