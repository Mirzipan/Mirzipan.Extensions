﻿using UnityEngine;

namespace Mirzipan.Extensions.Unity.Math
{
    public static partial class Vector2Extensions
    {
        #region Deconstruction

        public static void Deconstruct(this Vector2 @this, out float x, out float y)
        {
            x = @this.x;
            y = @this.y;
        }

        #endregion Deconstruction
        
        #region Validation

        public static bool IsNaN(this Vector2 @this) => float.IsNaN(@this.x) || float.IsNaN(@this.y);

        #endregion Validation

        #region With

        public static Vector2 WithX(this Vector2 @this, float x) => new Vector2(x, @this.y);

        public static Vector2 WithY(this Vector2 @this, float y) => new Vector2(@this.x, y);

        #endregion With

        #region Clamp

        public static Vector2 Clamp01(this Vector2 @this) => Clamp(@this, 0f, 1f);

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

        public static Vector2 RotateBy90CW(this Vector2 @this) => new Vector2(@this.y, -@this.x);

        public static Vector2 RotateBy90CCW(this Vector2 @this) => new Vector2(-@this.y, @this.x);

        #endregion Rotation

        #region Equality

        public static bool LossyEquals(this Vector2 @this, Vector2 other, float tolerance = float.Epsilon)
        {
            var delta = @this - other;
            return delta.sqrMagnitude <= tolerance * tolerance;
        }

        #endregion Equality
    }
}