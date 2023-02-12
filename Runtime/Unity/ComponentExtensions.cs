using System;
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
        
        public static T GetOrAddComponent<T>(this Component @this) where T: Component
        {
            return @this.GetComponent<T>() ?? @this.gameObject.AddComponent<T>();
        }

        public static Component GetOrAddComponent(this Component @this, Type type)
        {
            return @this.GetComponent(type) ?? @this.gameObject.AddComponent(type);
        }

        public static bool HasComponent<T>(this Component @this) => @this.GetComponent<T>() != null;
    }
}