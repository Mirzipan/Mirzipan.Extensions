namespace Mirzipan.Extensions
{
    public static class BoolExtensions
    {
        /// <summary>
        /// Returns the negated value of this.
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static bool Toggle(this bool @this)
        {
            return !@this;
        }

        /// <summary>
        /// Turns this into a string.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="true">String to return if this is true</param>
        /// <param name="false">String to return if this if false</param>
        /// <returns></returns>
        public static string ToString(this bool @this, string @true, string @false)
        {
            return @this ? @true : @false;
        }

        /// <summary>
        /// Turns this into an instance of type.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="true">Instance to return if this is true</param>
        /// <param name="false">Instance to return if this is false</param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ToType<T>(this bool @this, T @true, T @false)
        {
            return @this ? @true : @false;
        }
    }
}