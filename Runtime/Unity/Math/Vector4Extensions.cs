using UnityEngine;

namespace Mirzipan.Extensions.Unity.Math
{
    public static partial class Vector4Extensions
    {
        #region Deconstruction

        public static void Deconstruct(this Vector4 @this, out float x, out float y, out float z, out float w)
        {
            x = @this.x;
            y = @this.y;
            z = @this.z;
            w = @this.w;
        }

        #endregion Deconstruction
        
        #region Validation

        public static bool IsNaN(this Vector4 @this)
        {
            return float.IsNaN(@this.x) || float.IsNaN(@this.y) || float.IsNaN(@this.z) || float.IsNaN(@this.w);
        }

        #endregion Validation

        #region With

        public static Vector4 WithX(this Vector4 @this, float x) => new Vector4(x, @this.y, @this.z, @this.w);

        public static Vector4 WithY(this Vector4 @this, float y) => new Vector4(@this.x, y, @this.z, @this.w);

        public static Vector4 WithZ(this Vector4 @this, float z) => new Vector4(@this.x, @this.y, z, @this.w);

        public static Vector4 WithW(this Vector4 @this, float w) => new Vector4(@this.x, @this.y, @this.z, w);

        #endregion With

        #region Clamp

        public static Vector4 Clamp01(this Vector4 @this) => Clamp(@this, 0f, 1f);

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

        public static Vector4 ClampX(this Vector4 @this, float min, float max)
        {
            return @this.WithX(Mathf.Clamp(@this.x, min, max));
        }

        public static Vector4 ClampY(this Vector4 @this, float min, float max)
        {
            return @this.WithY(Mathf.Clamp(@this.y, min, max));
        }

        public static Vector4 ClampZ(this Vector4 @this, float min, float max)
        {
            return @this.WithZ(Mathf.Clamp(@this.z, min, max));
        }

        public static Vector4 ClampW(this Vector4 @this, float min, float max)
        {
            return @this.WithW(Mathf.Clamp(@this.w, min, max));
        }

        #endregion Clamp

        #region Equality

        public static bool Approximately(this Vector4 @this, Vector4 other, float tolerance = float.Epsilon)
        {
            var delta = @this - other;
            return delta.sqrMagnitude <= tolerance * tolerance;
        }

        public static bool IsZero(this Vector4 @this, float tolerance = float.Epsilon)
        {
            return @this.Approximately(Vector4.zero, tolerance);
        }

        public static bool NotZero(this Vector4 @this, float tolerance = float.Epsilon)
        {
            return !@this.Approximately(Vector4.zero, tolerance);
        }

        #endregion Equality
    }
}