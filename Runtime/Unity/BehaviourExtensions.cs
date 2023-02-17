using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class BehaviourExtensions
    {
        /// <summary>
        /// Sets this <see cref="Behaviour"/> to enabled.
        /// </summary>
        /// <param name="this"></param>
        public static void Enable(this Behaviour @this) => @this.enabled = true;

        /// <summary>
        /// Sets this <see cref="Behaviour"/> to disabled.
        /// </summary>
        /// <param name="this"></param>
        public static void Disable(this Behaviour @this) => @this.enabled = false;

        /// <summary>
        /// Returns true if the <see cref="GameObject"/> of this <see cref="Behaviour"/> is a prefab.
        /// </summary>
        /// <param name="this"></param>
        public static bool IsPrefab(this Behaviour @this) => @this.gameObject.IsPrefab();
    }
}