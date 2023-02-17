using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class AnimatorExtensions
    {
        /// <summary>
        /// Resets all parameters of this animator.
        /// </summary>
        /// <param name="this"></param>
        public static void ResetParameters(this Animator @this)
        {
            int count = @this.parameters.Length;
            for (int i = 0; i < count; i++)
            {
                var param = @this.parameters[i];
                switch (param.type)
                {
                    case AnimatorControllerParameterType.Bool:
                        @this.SetBool(param.name, param.defaultBool);
                        break;
                    case AnimatorControllerParameterType.Int:
                        @this.SetInteger(param.name, param.defaultInt);
                        break;
                    case AnimatorControllerParameterType.Float:
                        @this.SetFloat(param.name, param.defaultFloat);
                        break;
                    case AnimatorControllerParameterType.Trigger:
                        @this.ResetTrigger(param.name);
                        break;
                }
            }
        }

        /// <summary>
        /// Returns true if this animator has a parameter with the specified name.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="name">Name of the parameter to check for</param>
        public static bool HasParameter(this Animator @this, string name)
        {
            int count = @this.parameters.Length;
            for (int i = 0; i < count; i++)
            {
                var parameter = @this.parameters[i];
                if (string.CompareOrdinal(parameter.name, name) == 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns true if this animator has a parameter with the specified name and type.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="name">Name of the parameter to check for</param>
        /// <param name="type">Type of the parameter to check for</param>
        public static bool HasParameter(this Animator @this, string name, AnimatorControllerParameterType type)
        {
            int count = @this.parameters.Length;
            for (int i = 0; i < count; i++)
            {
                var parameter = @this.parameters[i];
                if (parameter.type == type && string.CompareOrdinal(parameter.name, name) == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}