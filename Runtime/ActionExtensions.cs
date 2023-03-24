using System;

namespace Mirzipan.Extensions
{
    public static class ActionExtensions
    {
        public static void SafeInvoke(this Action @this)
        {
            @this?.Invoke();
        }

        public static void SafeInvoke<T1>(this Action<T1> @this, T1 param1)
        {
            @this?.Invoke(param1);
        }

        public static void SafeInvoke<T1, T2>(this Action<T1, T2> @this, T1 param1, T2 param2)
        {
            @this?.Invoke(param1, param2);
        }

        public static void SafeInvoke<T1, T2, T3>(this Action<T1, T2, T3> @this, T1 param1, T2 param2, T3 param3)
        {
            @this?.Invoke(param1, param2, param3);
        }

        public static void SafeInvoke<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> @this, T1 param1, T2 param2, T3 param3, T4 param4)
        {
            @this?.Invoke(param1, param2, param3, param4);
        }
    }
}