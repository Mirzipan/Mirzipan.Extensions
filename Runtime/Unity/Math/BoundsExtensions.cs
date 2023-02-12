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
        
        public static Bounds MoveTo(this ref Bounds @this, Vector3 center)
        {
            return new Bounds(center, @this.size);
        }
        
        public static Bounds Resize(this ref Bounds @this, Vector3 size)
        {
            return new Bounds(@this.center, size);
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
    }
}