using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
    public static class TransformExtensions
    {
        public static void CopyPositionAndRotation(this Transform @this, Transform source)
        {
            @this.position = source.position;
            @this.rotation = source.rotation;
        }

        public static void SetPositionX(this Transform @this, float x)
        {
            var pos = @this.position;
            pos = new Vector3(x, pos.y, pos.z);
            @this.position = pos;
        }

        public static void SetPositionY(this Transform @this, float y)
        {
            var pos = @this.position;
            pos = new Vector3(pos.x, y, pos.z);
            @this.position = pos;
        }

        public static void SetPositionZ(this Transform @this, float z)
        {
            var pos = @this.position;
            pos = new Vector3(pos.x, pos.y, z);
            @this.position = pos;
        }

        public static void SetPositionXY(this Transform @this, float x, float y)
        {
            var pos = @this.position;
            pos = new Vector3(x, y, pos.z);
            @this.position = pos;
        }

        public static void SetPositionXZ(this Transform @this, float x, float z)
        {
            var pos = @this.position;
            pos = new Vector3(x, pos.y, z);
            @this.position = pos;
        }

        public static void SetPositionYZ(this Transform @this, float y, float z)
        {
            var pos = @this.position;
            pos = new Vector3(pos.x, y, z);
            @this.position = pos;
        }
    }
}