using System;
using System.Collections.Generic;
using Mirzipan.Extensions.Collections;
using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class GameObjectExtensions
    {
        #region Components

        /// <summary>
        /// Returns the component of type T on this <see cref="GameObject"/>.
        /// In case there is no existing component, a new instance will be created and returned.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T">Type of component to return</typeparam>
        public static T GetOrAddComponent<T>(this GameObject @this) where T : Component
        {
            return @this.GetComponent<T>() ?? @this.AddComponent<T>();
        }

        /// <summary>
        /// Returns the component of specified type on this <see cref="GameObject"/>.
        /// In case there is no existing component, a new instance will be created and returned.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="type">Type of component to return</param>
        public static Component GetOrAddComponent(this GameObject @this, Type type)
        {
            return @this.GetComponent(type) ?? @this.AddComponent(type);
        }

        /// <summary>
        /// Returns true if this <see cref="GameObject"/> has a component of type T.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T">Type of component to check for</typeparam>
        /// <returns></returns>
        public static bool HasComponent<T>(this GameObject @this) => @this.GetComponent<T>() != null;

        /// <summary>
        /// Returns true if the <see cref="GameObject"/> has a component of specified type.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="type">Type of component to check for</param>
        /// <returns></returns>
        public static bool HasComponent(this GameObject @this, Type type) => @this.GetComponent(type) != null;

        #endregion Components

        #region Hierarchy

        /// <summary>
        /// Makes this <see cref="GameObject"/> a child of another <see cref="GameObject"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="parent">New parent for this</param>
        public static void SetParent(this GameObject @this, GameObject parent)
        {
            @this.transform.SetParent(parent.transform);
        }

        /// <summary>
        /// Makes this <see cref="GameObject"/> a child of another <see cref="GameObject"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="parent">New parent for this</param>
        /// <param name="worldPositionStays">Should the world position of this stay the same?</param>
        public static void SetParent(this GameObject @this, GameObject parent, bool worldPositionStays)
        {
            @this.transform.SetParent(parent.transform, worldPositionStays);
        }

        /// <summary>
        /// Returns all children of the specified type.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T">Type of component to return</typeparam>
        /// <returns></returns>
        public static IList<T> GetChildren<T>(this GameObject @this) where T : Component => @this.transform.GetChildren<T>();

        /// <summary>
        /// Destroys all child <see cref="GameObject"/>s that have a <see cref="Component"/> of the specified type.
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T">Type of component to destroy</typeparam>
        /// <returns></returns>
        public static void DestroyChildren<T>(this GameObject @this) where T : Component => @this.transform.DestroyChildren<T>();

        /// <summary>
        /// Destroys all child <see cref="GameObject"/>s of this <see cref="GameObject"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static void DestroyChildren(this GameObject @this) => @this.transform.DestroyChildren();

        /// <summary>
        /// Returns the root of the hierarchy tree this <see cref="GameObject"/> is a part of.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns the path of this <see cref="GameObject"/> in the hierarchy.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string Path(this GameObject @this) => @this.transform.Path();

        /// <summary>
        /// Returns true if this <see cref="GameObject"/> is a prefab.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsPrefab(this GameObject @this) => @this.scene.name.IsNullOrEmpty();

        /// <summary>
        /// Sets layer to every object in hierarchy under this <see cref="GameObject"/>.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="layer">New layer to set</param>
        public static void SetLayerOnHierarchy(this GameObject @this, int layer)
        {
            @this.transform.ExecuteOnHierarchy(x => x.gameObject.layer = layer);
        }
        
        #endregion Hierarchy
    }
}