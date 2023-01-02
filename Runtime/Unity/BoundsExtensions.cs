using System.Collections.Generic;
using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class BoundsExtensions
    {
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
    }
}