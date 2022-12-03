using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class RectExtensions
    {
        public static void Encapsulate(this ref RectInt @this, Vector2Int point)
        {
            @this.SetMinMax(Vector2Int.Min(@this.min, point), Vector2Int.Max(@this.max, point));
        }
    }
}