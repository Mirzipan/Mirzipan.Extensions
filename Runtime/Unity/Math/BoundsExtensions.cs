using System.Collections.Generic;
using UnityEngine;

namespace Mirzipan.Extensions.Unity.Math
{
    public static class BoundsExtensions
    {
        #region Deconstruction

        public static void Deconstruct(this Bounds @this, out Vector3 center, out Vector3 size)
        {
            center = @this.center;
            size = @this.size;
        }

        #endregion Deconstruction

        #region Manipulation

        public static Bounds MoveTo(this ref Bounds @this, Vector3 center) => new Bounds(center, @this.size);

        public static Bounds Resize(this ref Bounds @this, Vector3 size) => new Bounds(@this.center, size);

        #endregion Manipulation

        #region Containment

        public static void Encapsulate(this ref Bounds @this, IEnumerable<Vector3> points)
        {
            Vector3 min = @this.min;
            Vector3 max = @this.max;

            foreach (var entry in points)
            {
                min = Vector3.Min(min, entry);
                max = Vector3.Max(max, entry);
            }
            
            @this.SetMinMax(min, max);
        }

        public static Vector3 RandomPositionInside(this Bounds @this)
        {
            Vector3 result = Vector3.zero;
            Vector3 min = @this.min;
            Vector3 max = @this.max;
            
            result.x = Random.Range(min.x, max.x);
            result.y = Random.Range(min.y, max.y);
            result.z = Random.Range(min.z, max.z);

            return result;
        }
        
        public static bool Intersect(this Bounds @this, Bounds other, out Bounds intersection)
        {
            intersection = new Bounds();
            
            if (@this.max.x <= other.min.x || @this.max.y <= other.min.y || @this.max.z <= other.min.z)
            {
                return false;
            }
            
            if (@this.min.x >= other.max.x || @this.min.y >= other.max.y || @this.min.z >= other.max.z)
            {
                return false;
            }

            Vector3 min = Vector3.Min(@this.min, other.min);
            Vector3 max = Vector3.Min(@this.max, other.max);
            intersection.SetMinMax(min, max);
            return true;
        }

        #endregion Containment
    }
}