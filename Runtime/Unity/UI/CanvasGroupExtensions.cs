using UnityEngine;

namespace Mirzipan.Extensions.Unity.UI
{
    public static class CanvasGroupExtensions
    {
        /// <summary>
        /// Makes this <see cref="CanvasGroup"/> opaque, interactable and blocking raycasts.
        /// </summary>
        /// <param name="this"></param>
        public static void Show(this CanvasGroup @this)
        {
            @this.alpha = 1f;
            @this.interactable = true;
            @this.blocksRaycasts = true;
        }
        
        /// <summary>
        /// Makes this <see cref="CanvasGroup"/> fully transparent, non-interactable and not blocking raycasts.
        /// </summary>
        /// <param name="this"></param>
        public static void Hide(this CanvasGroup @this)
        {
            @this.alpha = 0f;
            @this.interactable = false;
            @this.blocksRaycasts = false;
        }
    }
}