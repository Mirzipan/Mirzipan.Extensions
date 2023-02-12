using UnityEngine.Events;
using UnityEngine.UI;

namespace Mirzipan.Extensions.Unity.UI
{
    public static class SliderExtensions
    {
        public static void SetOnValueChangedListener(this Slider @this, UnityAction<float> listener)
        {
            @this.onValueChanged.RemoveAllListeners();
            @this.onValueChanged.AddListener(listener);
        }
    }
}