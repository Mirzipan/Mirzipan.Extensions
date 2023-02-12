using System;
using UnityEngine;

namespace Mirzipan.Extensions.Unity
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

        public static bool HasComponent<T>(this GameObject @this) => @this.GetComponent<T>() != null;

        #endregion Components

        #region Hierarchy

        public static void SetParent(this GameObject @this, GameObject parent)
        {
            @this.transform.SetParent(parent.transform);
        }

        public static void SetParent(this GameObject @this, GameObject parent, bool worldPositionStays)
        {
            @this.transform.SetParent(parent.transform, worldPositionStays);
        }
        
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

        public static string Path(this GameObject @this) => @this.transform.Path();

        public static bool IsPrefab(this GameObject @this) => @this.scene.name.IsNullOrEmpty();

        #endregion Hierarchy
    }
}