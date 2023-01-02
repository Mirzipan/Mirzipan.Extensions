using UnityEngine;

namespace Mirzipan.Extensions
{
    public static class BehaviourExtensions
    {
        public static void Enable(this Behaviour @this)
        {
            @this.enabled = true;
        }
        
        public static void Disable(this Behaviour @this)
        {
            @this.enabled = false;
        }

        public static bool IsPrefab(this Behaviour @this)
        {
            return @this.gameObject.IsPrefab();
        }
    }
}