using Mirzipan.Extensions.Unity.Math;
using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class RectTransformExtensions
    {
        public static void SetWidth(this RectTransform @this, float width)
        {
            @this.sizeDelta = @this.sizeDelta.WithX(width);
        }
        
        public static void SetHeight(this RectTransform @this, float height)
        {
            @this.sizeDelta = @this.sizeDelta.WithY(height);
        }
        
        public static void SetPositionX(this RectTransform @this, float x)
        {
            @this.anchoredPosition = @this.anchoredPosition.WithX(x);
        }
        
        public static void SetPositionY(this RectTransform @this, float y)
        {
            @this.anchoredPosition = @this.anchoredPosition.WithY(y);
        }
    }
}