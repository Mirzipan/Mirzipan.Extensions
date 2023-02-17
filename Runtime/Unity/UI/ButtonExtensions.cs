using UnityEngine.Events;
using UnityEngine.UI;

namespace Mirzipan.Extensions.Unity.UI
{
    public static class ButtonExtensions
    {
        /// <summary>
        /// Sets the specified listener as the only listener of the OnClick event on this <see cref="Button"/>
        /// </summary>
        /// <param name="this"></param>
        /// <param name="listener">OnClick callback</param>
        public static void SetOnClickListener(this Button @this, UnityAction listener)
        {
            @this.onClick.RemoveAllListeners();
            @this.onClick.AddListener(listener);
        }
    }
}