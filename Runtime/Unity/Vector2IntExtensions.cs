﻿using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class Vector2IntExtensions
    {
        #region Deconstruction

        public static void Deconstruct(this Vector2Int @this, out int x, out int y)
        {
            x = @this.x;
            y = @this.y;
        }

        #endregion Deconstruction
        
        #region With

        public static Vector2Int WithX(this Vector2Int @this, int x)
        {
            return new Vector2Int(x, @this.y);
        }

        public static Vector2Int WithY(this Vector2Int @this, int y)
        {
            return new Vector2Int(@this.x, y);
        }

        #endregion With

        #region Swizzle

        public static Vector2Int XX(this Vector2Int @this)
        {
            return new Vector2Int(@this.x, @this.x);
        }

        public static Vector2Int YY(this Vector2Int @this)
        {
            return new Vector2Int(@this.y, @this.y);
        }

        public static Vector2Int YX(this Vector2Int @this)
        {
            return new Vector2Int(@this.y, @this.x);
        }

        public static Vector2Int XY(this Vector2Int @this)
        {
            return new Vector2Int(@this.x, @this.y);
        }

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

        #region Rotation
        
        public static Vector2Int RotateBy90CW(this Vector2Int @this)
        {
            return new Vector2Int(@this.y, -@this.x);
        }

        public static Vector2Int RotateBy90CCW(this Vector2Int @this)
        {
            return new Vector2Int(-@this.y, @this.x);
        }

        #endregion Rotation

        #region Clamp

        public static Vector2Int Clamp(this Vector2Int @this, int min, int max)
        {
            @this.x = Mathf.Clamp(@this.x, min, max);
            @this.y = Mathf.Clamp(@this.y, min, max);
            return @this;
        }

        #endregion Clamp
    }
}