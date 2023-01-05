using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class Vector3IntExtensions
    {
        #region Get/Set
        
        public static Vector3Int WithX(this Vector3Int @this, int x)
        {
            return new Vector3Int(x, @this.y, @this.z);
        }
        
        public static Vector3Int WithY(this Vector3Int @this, int y)
        {
            return new Vector3Int(@this.x, y, @this.z);
        }
        
        public static Vector3Int WithZ(this Vector3Int @this, int z)
        {
            return new Vector3Int(@this.x, @this.y, z);
        }

        public static Vector3Int XXX(this Vector3Int @this)
        {
            return new Vector3Int(@this.x, @this.x, @this.x);
        }

        public static Vector3Int YYY(this Vector3Int @this)
        {
            return new Vector3Int(@this.y, @this.y, @this.y);
        }

        public static Vector3Int ZZZ(this Vector3Int @this)
        {
            return new Vector3Int(@this.z, @this.z, @this.z);
        }

        public static Vector2Int XX(this Vector3Int @this)
        {
            return new Vector2Int(@this.x, @this.x);
        }

        public static Vector2Int YY(this Vector3Int @this)
        {
            return new Vector2Int(@this.y, @this.y);
        }

        public static Vector2Int ZZ(this Vector3Int @this)
        {
            return new Vector2Int(@this.z, @this.z);
        }

        public static Vector2Int XY(this Vector3Int @this)
        {
            return new Vector2Int(@this.x, @this.y);
        }

        public static Vector2Int XZ(this Vector3Int @this)
        {
            return new Vector2Int(@this.x, @this.z);
        }

        public static Vector2Int YX(this Vector3Int @this)
        {
            return new Vector2Int(@this.y, @this.x);
        }

        public static Vector2Int YZ(this Vector3Int @this)
        {
            return new Vector2Int(@this.y, @this.z);
        }

        public static Vector2Int ZX(this Vector3Int @this)
        {
            return new Vector2Int(@this.z, @this.x);
        }

        public static Vector2Int ZY(this Vector3Int @this)
        {
            return new Vector2Int(@this.z, @this.y);
        }

        #endregion Get/Set

        #region Clamp

        public static Vector3Int Clamp(this Vector3Int @this, int min, int max)
        {
            @this.x = Mathf.Clamp(@this.x, min, max);
            @this.y = Mathf.Clamp(@this.y, min, max);
            @this.z = Mathf.Clamp(@this.z, min, max);
            return @this;
        }

        #endregion Clamp
    }
}