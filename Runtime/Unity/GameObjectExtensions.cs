using System;
using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class GameObjectExtensions
    {
        #region Components
        
        public static T GetOrAddComponent<T>(this GameObject @this) where T: Component
        {
            return @this.GetComponent<T>() ?? @this.AddComponent<T>();
        }

        public static Component GetOrAddComponent(this GameObject @this, Type type)
        {
            return @this.GetComponent(type) ?? @this.AddComponent(type);
        }

        #endregion Components

        #region Hierarchy

        public static GameObject Root(this GameObject @this)
        {
            if (!@this.transform.parent)
            {
                return @this;
            }

            var current = @this.transform;
            while (current.parent)
            {
                current = current.parent;
            }

            return current.gameObject;
        }

        public static string Path(this GameObject @this)
        {
            return @this.transform.Path();
        }

        public static bool IsPrefab(this GameObject @this)
        {
            return @this.scene.name.IsNullOrEmpty();
        }

        #endregion Hierarchy
    }
}