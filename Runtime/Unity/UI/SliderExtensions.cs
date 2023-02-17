using UnityEngine.Events;
using UnityEngine.UI;

namespace Mirzipan.Extensions.Unity.UI
{
    public static class SliderExtensions
    {
        /// <summary>
        /// Sets the specified listener as the only listener of the OnValueChanged event on this <see cref="Slider"/>
        /// </summary>
        /// <param name="this"></param>
        /// <param name="listener">OnClick callback</param>
        public static void SetOnValueChangedListener(this Slider @this, UnityAction<float> listener)
        {
            @this.onValueChanged.RemoveAllListeners();
            @this.onValueChanged.AddListener(listener);
        }

        /// <summary>
        /// Sets the min and max values for this <see cref="Slider"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void SetMinMax(this Slider @this, float min, float max)
        {
            @this.wholeNumbers = false;
            @this.minValue = min;
            @this.maxValue = max;
        }

        /// <summary>
        /// Sets the min and max values for this <see cref="Slider"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public static void SetMinMax(this Slider @this, int min, int max)
        {
            @this.wholeNumbers = true;
            @this.minValue = min;
            @this.maxValue = max;
        }
    }
}