using UnityEngine.Events;
using UnityEngine.UI;

namespace Mirzipan.Extensions.Unity.UI
{
    public static class ButtonExtensions
    {
        public static void SetOnClickListener(this Button @this, UnityAction listener)
        {
            @this.onClick.RemoveAllListeners();
            @this.onClick.AddListener(listener);
        }
    }
}