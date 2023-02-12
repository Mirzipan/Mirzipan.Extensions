using UnityEngine;

namespace Mirzipan.Extensions.Unity.UI
{
    public static class CanvasGroupExtensions
    {
        public static void Show(this CanvasGroup @this)
        {
            @this.alpha = 1f;
            @this.interactable = true;
            @this.blocksRaycasts = true;
        }
        
        public static void Hide(this CanvasGroup @this)
        {
            @this.alpha = 0f;
            @this.interactable = false;
            @this.blocksRaycasts = false;
        }
    }
}