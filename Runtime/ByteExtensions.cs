namespace Mirzipan.Extensions
{
    public static class ByteExtensions
    {
        /// <summary>
        /// Returns true if the bit at the specified index is set to 1.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static bool IsBitSet(this byte @this, int index) => (@this & (1 << index)) != 0;
        
        /// <summary>
        /// Sets the bit at index to 1.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static byte SetBit(this byte @this, int index) => (byte)(@this | (1 << index));
        
        /// <summary>
        /// Sets the bit at index to 0.
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static byte UnsetBit(this byte @this, int index) => (byte)(@this & ~(1 << index));
        
        /// <summary>
        /// Sets the bit at index to its opposite value (0 is changed 1, 1 is changed to 0).
        /// </summary>
        /// <param name="this"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static byte ToggleBit(this byte @this, int index) => (byte)(@this ^ (1 << index));
    }
}