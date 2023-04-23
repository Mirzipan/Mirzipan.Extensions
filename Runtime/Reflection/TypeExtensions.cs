using System;
using System.Linq;

namespace Mirzipan.Extensions.Reflection
{
    public static class TypeExtensions
    {
        /// <summary>
        /// Returns a nested type that is derived from the specified type.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="baseType"></param>
        /// <returns></returns>
        public static Type GetNestedType(this Type @this, Type baseType)
        {
            return @this.GetNestedTypes().FirstOrDefault(baseType.IsAssignableFrom);
        }

        /// <summary>
        /// Returns true if this type is assignable to target type.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="targetType"></param>
        /// <returns></returns>
        public static bool IsAssignableTo(this Type @this, Type targetType) => targetType.IsAssignableFrom(@this);

        /// <summary>
        /// Returns true if this type is a struct.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsStruct(this Type @this) => @this.IsValueType && !@this.IsPrimitive && !@this.IsEnum;

        /// <summary>
        /// Returns true if this type has a default constructor.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool HasDefaultConstructor(this Type @this)
        {
            if (@this.IsAbstract)
            {
                return false;
            }

            return @this.GetConstructor(Type.EmptyTypes) != null;
        }

        /// <summary>
        /// Returns true if this is a nullable type.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool IsNullable(this Type @this)
        {
            return @this.IsGenericType && @this.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        /// <summary>
        /// Returns true if this is not a nullable type.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool NotNullable(this Type @this)
        {
            return !@this.IsGenericType || @this.GetGenericTypeDefinition() != typeof(Nullable<>);
        }
    }
}