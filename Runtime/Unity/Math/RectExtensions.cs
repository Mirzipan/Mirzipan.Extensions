using System.Collections.Generic;
using UnityEngine;

namespace Mirzipan.Extensions.Unity.Math
{
    public static class RectExtensions
    {
        #region Deconstruction

        public static void Deconstruct(this Rect @this, out float x, out float y, out float width, out float height)
        {
            x = @this.x;
            y = @this.y;
            width = @this.width;
            height = @this.height;
        }

        public static void Deconstruct(this Rect @this, out Vector2 position, out Vector2 size)
        {
            position = @this.position;
            size = @this.size;
        }

        #endregion Deconstruction
        
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

        public static Vector2 RandomPositionInside(this Rect @this)
        {
            Vector2 result = Vector2.zero;
            Vector2 min = @this.min;
            Vector2 max = @this.max;
            
            result.x = Random.Range(min.x, max.x);
            result.y = Random.Range(min.y, max.y);

            return result;
        }
    }
}