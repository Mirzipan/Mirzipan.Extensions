using System;
using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class ComponentExtensions
    {
        /// <summary>
        /// Set the active flag of <see cref="GameObject"/>, that this <see cref="Component"/> is attached to, to the specified value.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="value"></param>
        public static void SetActive(this Component @this, bool value)
        {
            if (@this.gameObject.activeSelf == value)
            {
                return;
            }
            
            @this.gameObject.SetActive(value);
        }
        
        /// <summary>
        /// Returns the <see cref="Component"/> of type T of <see cref="GameObject"/>, that this component is attached to.
        /// In case there is no existing component, a new instance will be created and returned.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T">Type of component to return</typeparam>
        public static T GetOrAddComponent<T>(this Component @this) where T: Component
        {
            return @this.GetComponent<T>() ?? @this.gameObject.AddComponent<T>();
        }

        /// <summary>
        /// Returns the <see cref="Component"/> of specified type of <see cref="GameObject"/>, that this component is attached to.
        /// In case there is no existing component, a new instance will be created and returned.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="type">Type of component to return</param>
        public static Component GetOrAddComponent(this Component @this, Type type)
        {
            return @this.GetComponent(type) ?? @this.gameObject.AddComponent(type);
        }

        /// <summary>
        /// Returns true if the <see cref="GameObject"/> this component is attached to has a <see cref="Component"/> of type T.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T">Type of component to check for</typeparam>
        /// <returns></returns>
        public static bool HasComponent<T>(this Component @this) => @this.GetComponent<T>() != null;

        /// <summary>
        /// Returns true if the <see cref="GameObject"/> this component is attached to has a <see cref="Component"/> of specified type.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="type">Type of component to check for</param>
        /// <returns></returns>
        public static bool HasComponent(this Component @this, Type type) => @this.GetComponent(type) != null;
    }
}