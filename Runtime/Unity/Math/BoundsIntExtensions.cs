using System.Collections.Generic;
using UnityEngine;

namespace Mirzipan.Extensions.Unity.Math
{
    public static class BoundsIntExtensions
    {
        #region Deconstruction

        public static void Deconstruct(this BoundsInt @this, out float x, out float y, out float z, out float width, out float height, out float depth)
        {
            x = @this.center.x;
            y = @this.center.y;
            z = @this.center.z;
            width = @this.size.x;
            height = @this.size.y;
            depth = @this.size.z;
        }

        public static void Deconstruct(this BoundsInt @this, out Vector3 center, out Vector3Int size)
        {
            center = @this.center;
            size = @this.size;
        }

        #endregion Deconstruction

        #region Manipulation

        public static BoundsInt MoveTo(this ref BoundsInt @this, Vector3Int center) => new BoundsInt(center, @this.size);

        public static BoundsInt Move(this ref BoundsInt @this, Vector3Int offset) => new BoundsInt(@this.position + offset, @this.size);

        public static BoundsInt Resize(this ref BoundsInt @this, Vector3Int size)   => new BoundsInt(@this.position, size);
        
        public static BoundsInt Expand(this ref BoundsInt @this, Vector3Int amount) => new BoundsInt(@this.position - amount, @this.size + 2 *amount);

        public static BoundsInt Expand(this ref BoundsInt @this, int amount) => @this.Expand(new Vector3Int(amount, amount, amount));

        #endregion Manipulation

        #region Containment

        public static void Encapsulate(this ref BoundsInt @this, Vector3Int point)
        {
            @this.SetMinMax(Vector3Int.Min(@this.min, point), Vector3Int.Max(@this.max, point));
        }

        public static void Encapsulate(this ref BoundsInt @this, IEnumerable<Vector3Int> points)
        {
            Vector3Int min = @this.min;
            Vector3Int max = @this.max;

            foreach (var entry in points)
            {
                min = Vector3Int.Min(min, entry);
                max = Vector3Int.Max(max, entry);
            }
            
            @this.SetMinMax(min, max);
        }

        public static void Encapsulate(this ref BoundsInt @this, BoundsInt bounds)
        {
            @this.SetMinMax(Vector3Int.Min(@this.min, bounds.min), Vector3Int.Max(@this.max, bounds.max));
        }

        public static Vector3Int RandomPositionInside(this BoundsInt @this)
        {
            Vector3Int result = Vector3Int.zero;
            Vector3Int min = @this.min;
            Vector3Int max = @this.max;
            
            result.x = Random.Range(min.x, max.x);
            result.y = Random.Range(min.y, max.y);
            result.z = Random.Range(min.z, max.z);

            return result;
        }

        public static bool Intersect(this BoundsInt @this, BoundsInt other, out BoundsInt intersection)
        {
            intersection = new BoundsInt();
            
            if (@this.max.x <= other.min.x || @this.max.y <= other.min.y || @this.max.z <= other.min.z)
            {
                return false;
            }
            
            if (@this.min.x >= other.max.x || @this.min.y >= other.max.y || @this.min.z >= other.max.z)
            {
                return false;
            }

            Vector3Int min = Vector3Int.Min(@this.min, other.min);
            Vector3Int max = Vector3Int.Min(@this.max, other.max);
            intersection.SetMinMax(min, max);
            return true;
        }

        #endregion Containment
    }
}