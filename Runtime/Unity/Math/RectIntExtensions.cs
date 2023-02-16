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

        #region Containment

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

        public static Vector2 RandomPositionInside(this RectInt @this)
        {
            Vector2Int result = Vector2Int.zero;
            Vector2Int min = @this.min;
            Vector2Int max = @this.max;
            
            result.x = Random.Range(min.x, max.x);
            result.y = Random.Range(min.y, max.y);

            return result;
        }
        
        public static bool Intersect(this RectInt @this, RectInt other, out RectInt intersection)
        {
            intersection = new RectInt();
            
            if (@this.xMax <= other.xMin || @this.yMax <= other.yMin)
            {
                return false;
            }
            
            if (@this.xMin >= other.xMax || @this.yMin >= other.yMax)
            {
                return false;
            }

            int xMin = Mathf.Max(@this.xMin, other.xMin);
            int yMin = Mathf.Max(@this.yMin, other.yMin);
            int xMax = Mathf.Max(@this.xMax, other.xMax);
            int yMax = Mathf.Max(@this.yMax, other.yMax);
            
            intersection.SetMinMax(new Vector2Int(xMin, yMin), new Vector2Int(xMax, yMax));
            return true;
        }

        #endregion Containment
    }
}