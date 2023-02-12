using System.Collections.Generic;
using UnityEngine;

namespace Mirzipan.Extensions.Unity.Math
{
    public static class RectIntExtensions
    {
        #region Deconstruction

        public static void Deconstruct(this RectInt @this, out int x, out int y, out int width, out int height)
        {
            x = @this.x;
            y = @this.y;
            width = @this.width;
            height = @this.height;
        }

        public static void Deconstruct(this RectInt @this, out Vector2Int position, out Vector2Int size)
        {
            position = @this.position;
            size = @this.size;
        }

        #endregion Deconstruction
        
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