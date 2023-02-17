using UnityEngine.Events;
using UnityEngine.UI;

namespace Mirzipan.Extensions.Unity.UI
{
    public static class ToggleExtensions
    {
        /// <summary>
        /// Sets the specified listener as the only listener of the OnValueChanged event on this <see cref="Toggle"/>
        /// </summary>
        /// <param name="this"></param>
        /// <param name="listener">OnClick callback</param>
        public static void SetOnValueChangedListener(this Toggle @this, UnityAction<bool> listener)
        {
            @this.onValueChanged.RemoveAllListeners();
            @this.onValueChanged.AddListener(listener);
        }
    }
}