using UnityEngine;

namespace Mirzipan.Extensions.Unity.Math
{
    public static partial class Vector3IntExtensions
    {
        #region Deconstruction

        public static void Deconstruct(this Vector3Int @this, out int x, out int y, out int z)
        {
            x = @this.x;
            y = @this.y;
            z = @this.z;
        }

        #endregion Deconstruction
        
        #region With

        public static Vector3Int WithX(this Vector3Int @this, int x) => new Vector3Int(x, @this.y, @this.z);

        public static Vector3Int WithY(this Vector3Int @this, int y) => new Vector3Int(@this.x, y, @this.z);

        public static Vector3Int WithZ(this Vector3Int @this, int z) => new Vector3Int(@this.x, @this.y, z);

        #endregion With

        #region Clamp

        public static Vector3Int Clamp(this Vector3Int @this, int min, int max)
        {
            @this.x = Mathf.Clamp(@this.x, min, max);
            @this.y = Mathf.Clamp(@this.y, min, max);
            @this.z = Mathf.Clamp(@this.z, min, max);
            return @this;
        }

        public static Vector3Int Clamp(this Vector3Int @this, Vector3Int min, Vector3Int max)
        {
            @this.x = Mathf.Clamp(@this.x, min.x, max.x);
            @this.y = Mathf.Clamp(@this.y, min.y, max.y);
            @this.z = Mathf.Clamp(@this.z, min.z, max.z);
            return @this;
        }

        #endregion Clamp
    }
}