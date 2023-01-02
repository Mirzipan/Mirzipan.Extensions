using System.Collections.Generic;
using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class RectIntExtensions
    {
        public static void Encapsulate(this ref RectInt @this, Vector2Int point)
        {
            @this.SetMinMax(Vector2Int.Min(@this.min, point), Vector2Int.Max(@this.max, point));
        }
        
        public static void Encapsulate(this ref RectInt @this, IEnumerable<Vector2Int> points)
        {
            Vector2Int min = @this.min;
            Vector2Int max = @this.max;

            foreach (var entry in points)
            {
                min = Vector2Int.Min(min, entry);
                max = Vector2Int.Max(max, entry);
            }
            
            @this.SetMinMax(min, max);
        }
        
        public static void Encapsulate(this ref RectInt @this, RectInt rect)
        {
            @this.SetMinMax(Vector2Int.Min(@this.min, rect.min), Vector2Int.Max(@this.max, rect.max));
        }
    }
}