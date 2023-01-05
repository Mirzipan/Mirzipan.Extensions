using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class Vector2Extensions
    {
        #region Validation

        public static bool IsNaN(this Vector2 @this)
        {
            return float.IsNaN(@this.x) || float.IsNaN(@this.y);
        }

        #endregion Validation
        
        #region Get/Set
        
        public static Vector2 WithX(this Vector2 @this, float x)
        {
            return new Vector2(x, @this.y);
        }
        
        public static Vector2 WithY(this Vector2 @this, float y)
        {
            return new Vector2(@this.x, y);
        }

        public static Vector2 XX(this Vector2 @this)
        {
            return new Vector2(@this.x, @this.x);
        }

        public static Vector2 YY(this Vector2 @this)
        {
            return new Vector2(@this.y, @this.y);
        }

        public static Vector2 YX(this Vector2 @this)
        {
            return new Vector2(@this.y, @this.x);
        }

        #endregion Get/Set

        #region Clamp

        public static Vector2 Clamp01(this Vector2 @this)
        {
            return Clamp(@this, 0f, 1f);
        }

        public static Vector2 Clamp(this Vector2 @this, float min, float max)
        {
            @this.x = Mathf.Clamp(@this.x, min, max);
            @this.y = Mathf.Clamp(@this.y, min, max);
            return @this;
        }

        public static Vector2 Clamp(this Vector2 @this, Vector2 min, Vector2 max)
        {
            @this.x = Mathf.Clamp(@this.x, min.x, max.x);
            @this.y = Mathf.Clamp(@this.y, min.y, max.y);
            return @this;
        }

        #endregion Clamp

        #region Rotation

        public static Vector2 RotateBy90CW(this Vector2 @this)
        {
            return new Vector2(@this.y, -@this.x);
        }

        public static Vector2 RotateBy90CCW(this Vector2 @this)
        {
            return new Vector2(-@this.y, @this.x);
        }

        #endregion Rotation
    }
}