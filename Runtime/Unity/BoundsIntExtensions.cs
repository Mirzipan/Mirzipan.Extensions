using System.Collections.Generic;
using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class BoundsIntExtensions
    {
        #region Deconstruction

        public static void Deconstruct(this BoundsInt @this, out float x, out float y, out float width, out float height)
        {
            x = @this.center.x;
            y = @this.center.y;
            width = @this.size.x;
            height = @this.size.y;
        }

        public static void Deconstruct(this BoundsInt @this, out Vector2 center, out Vector2Int size)
        {
            center = @this.center;
            size = @this.size.XY();
        }

        #endregion Deconstruction
        
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

        public static BoundsInt MoveTo(this ref BoundsInt @this, Vector3Int center)
        {
            return new BoundsInt(center, @this.size);
        }
        
        public static BoundsInt Resize(this ref BoundsInt @this, Vector3Int size)
        {
            return new BoundsInt(@this.position, size);
        }
    }
}