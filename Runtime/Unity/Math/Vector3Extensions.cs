using UnityEngine;

namespace Mirzipan.Extensions.Unity.Math
{
    public static partial class Vector3Extensions
    {
        #region Deconstruction

        public static void Deconstruct(this Vector3 @this, out float x, out float y, out float z)
        {
            x = @this.x;
            y = @this.y;
            z = @this.z;
        }

        #endregion Deconstruction
        
        #region Validation

        public static bool IsNaN(this Vector3 @this)
        {
            return float.IsNaN(@this.x) || float.IsNaN(@this.y) || float.IsNaN(@this.z);
        }

        #endregion Validation

        #region With

        public static Vector3 WithX(this Vector3 @this, float x) => new Vector3(x, @this.y, @this.z);

        public static Vector3 WithY(this Vector3 @this, float y) => new Vector3(@this.x, y, @this.z);

        public static Vector3 WithZ(this Vector3 @this, float z) => new Vector3(@this.x, @this.y, z);

        #endregion With

        #region Clamp

        public static Vector3 Clamp01(this Vector3 @this) => Clamp(@this, 0f, 1f);

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

        public static Vector3 ClampX(this Vector3 @this, float min, float max)
        {
            return @this.WithX(Mathf.Clamp(@this.x, min, max));
        }

        public static Vector3 ClampY(this Vector3 @this, float min, float max)
        {
            return @this.WithY(Mathf.Clamp(@this.y, min, max));
        }

        public static Vector3 ClampZ(this Vector3 @this, float min, float max)
        {
            return @this.WithZ(Mathf.Clamp(@this.z, min, max));
        }

        #endregion Clamp

        #region Equality

        public static bool Approximately(this Vector3 @this, Vector3 other, float tolerance = float.Epsilon)
        {
            var delta = @this - other;
            return delta.sqrMagnitude <= tolerance * tolerance;
        }

        #endregion Equality

        #region Containment
        
        public static bool IsInside(this Vector3 @this, Bounds bounds) => bounds.Contains(@this);

        #endregion Containment
    }
}