using Mirzipan.Extensions.Unity.Math;
using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class RectTransformExtensions
    {
        /// <summary>
        /// Resizes this <see cref="RectTransform"/> to have the specified width.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="width">New width</param>
        public static void SetWidth(this RectTransform @this, float width)
        {
            @this.sizeDelta = @this.sizeDelta.WithX(width);
        }

        /// <summary>
        /// Resizes this <see cref="RectTransform"/> to have the specified height.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="height">New height</param>
        public static void SetHeight(this RectTransform @this, float height)
        {
            @this.sizeDelta = @this.sizeDelta.WithY(height);
        }
        
        /// <summary>
        /// Moves this <see cref="RectTransform"/> to the specified x position.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="x">New horizontal position</param>
        public static void SetPositionX(this RectTransform @this, float x)
        {
            @this.anchoredPosition = @this.anchoredPosition.WithX(x);
        }
        
        /// <summary>
        /// Moves this <see cref="RectTransform"/> to the specified y position.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="y">New vertical position</param>
        public static void SetPositionY(this RectTransform @this, float y)
        {
            @this.anchoredPosition = @this.anchoredPosition.WithY(y);
        }
    }
}