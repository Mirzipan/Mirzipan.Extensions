using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class Vector3Extensions
    {
        #region Validation

        public static bool IsNaN(this Vector3 @this)
        {
            return float.IsNaN(@this.x) || float.IsNaN(@this.y) || float.IsNaN(@this.z);
        }

        #endregion Validation
        
        #region Get/Set
        
        public static Vector3 WithX(this Vector3 @this, float x)
        {
            return new Vector3(x, @this.y, @this.z);
        }
        
        public static Vector3 WithY(this Vector3 @this, float y)
        {
            return new Vector3(@this.x, y, @this.z);
        }
        
        public static Vector3 WithZ(this Vector3 @this, float z)
        {
            return new Vector3(@this.x, @this.y, z);
        }

        public static Vector3 XXX(this Vector3 @this)
        {
            return new Vector3(@this.x, @this.x, @this.x);
        }

        public static Vector3 YYY(this Vector3 @this)
        {
            return new Vector3(@this.y, @this.y, @this.y);
        }

        public static Vector3 ZZZ(this Vector3 @this)
        {
            return new Vector3(@this.z, @this.z, @this.z);
        }

        public static Vector2 XX(this Vector3 @this)
        {
            return new Vector2(@this.x, @this.x);
        }

        public static Vector2 YY(this Vector3 @this)
        {
            return new Vector2(@this.y, @this.y);
        }

        public static Vector2 ZZ(this Vector3 @this)
        {
            return new Vector2(@this.z, @this.z);
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

        #endregion Get/Set

        #region Clamp

        public static Vector3 Clamp01(this Vector3 @this)
        {
            return Clamp(@this, 0f, 1f);
        }

        public static Vector3 Clamp(this Vector3 @this, float min, float max)
        {
            @this.x = Mathf.Clamp(@this.x, min, max);
            @this.y = Mathf.Clamp(@this.y, min, max);
            @this.z = Mathf.Clamp(@this.z, min, max);
            return @this;
        }

        public static Vector3 Clamp(this Vector3 @this, Vector3 min, Vector3 max)
        {
            @this.x = Mathf.Clamp(@this.x, min.x, max.x);
            @this.y = Mathf.Clamp(@this.y, min.y, max.y);
            @this.z = Mathf.Clamp(@this.z, min.z, max.z);
            return @this;
        }

        #endregion Clamp
    }
}