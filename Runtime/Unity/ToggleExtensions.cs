using UnityEngine.Events;
using UnityEngine.UI;

namespace Mirzipan.Extensions.Unity
{
    public static class ToggleExtensions
    {
        public static void SetOnValueChangedListener(this Toggle @this, UnityAction<bool> listener)
        {
            @this.onValueChanged.RemoveAllListeners();
            @this.onValueChanged.AddListener(listener);
        }
    }
}