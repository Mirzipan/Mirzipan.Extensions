using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class GameObjectExtensions
    {
        public static T GetOrAddComponent<T>(this GameObject @this) where T: Component
        {
            return @this.GetComponent<T>() ?? @this.AddComponent<T>();
        }
    }
}