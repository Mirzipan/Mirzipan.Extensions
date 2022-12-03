namespace Mirzipan.Extensions
{
    public static class BoolExtensions
    {
        public static bool Toggle(this bool @this)
        {
            return !@this;
        }

        public static string ToString(this bool @this, string @true, string @false)
        {
            return @this ? @true : @false;
        }

        public static T ToType<T>(this bool @this, T @true, T @false)
        {
            return @this ? @true : @false;
        }
    }
}