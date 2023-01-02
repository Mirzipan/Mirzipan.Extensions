using System.Collections.Generic;
using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class RectExtensions
    {
        public static void SetMinMax(this ref Rect @this, Vector2 min, Vector2 max)
        {
            @this.min = min;
            @this.max = max;
        }
        
        public static void Encapsulate(this ref Rect @this, Vector2 point)
        {
            @this.min = Vector2.Min(@this.min, point);
            @this.max = Vector2.Max(@this.max, point);
        }
        
        public static void Encapsulate(this ref Rect @this, IEnumerable<Vector2> points)
        {
            Vector2 min = @this.min;
            Vector2 max = @this.max;

            foreach (var entry in points)
            {
                min = Vector2.Min(min, entry);
                max = Vector2.Max(max, entry);
            }
            
            @this.min = min;
            @this.max = max;
        }
        
        public static void Encapsulate(this ref Rect @this, Rect rect)
        {
            @this.min = Vector2.Min(@this.min, rect.min);
            @this.max = Vector2.Min(@this.max, rect.max);
        }
    }
}