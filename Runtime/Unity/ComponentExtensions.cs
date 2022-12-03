using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class ComponentExtensions
    {
        public static void SetActive(this Component @this, bool value)
        {
            if (@this.gameObject.activeSelf == value)
            {
                return;
            }
            
            @this.gameObject.SetActive(value);
        }
    }
}