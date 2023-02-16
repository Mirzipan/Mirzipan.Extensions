using UnityEngine;

namespace Mirzipan.Extensions.Unity.Math
{
    public static partial class Vector2IntExtensions
    {
        #region Deconstruction

        public static void Deconstruct(this Vector2Int @this, out int x, out int y)
        {
            x = @this.x;
            y = @this.y;
        }

        #endregion Deconstruction
        
        #region With

        public static Vector2Int WithX(this Vector2Int @this, int x) => new Vector2Int(x, @this.y);

        public static Vector2Int WithY(this Vector2Int @this, int y) => new Vector2Int(@this.x, y);

        #endregion With

        #region Rotation
        
        public static Vector2Int RotateBy90CW(this Vector2Int @this) => new Vector2Int(@this.y, -@this.x);

        public static Vector2Int RotateBy90CCW(this Vector2Int @this) => new Vector2Int(-@this.y, @this.x);

        #endregion Rotation

        #region Clamp

        public static Vector2Int Clamp(this Vector2Int @this, int min, int max)
        {
            @this.x = Mathf.Clamp(@this.x, min, max);
            @this.y = Mathf.Clamp(@this.y, min, max);
            return @this;
        }

        public static Vector2Int Clamp(this Vector2Int @this, Vector2Int min, Vector2Int max)
        {
            @this.x = Mathf.Clamp(@this.x, min.x, max.x);
            @this.y = Mathf.Clamp(@this.y, min.y, max.y);
            return @this;
        }

        #endregion Clamp

        #region Containment

        public static bool IsInside(this Vector2Int @this, RectInt rect) => rect.Contains(@this);

        #endregion Containment
    }
}