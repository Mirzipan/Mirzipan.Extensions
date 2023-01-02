using UnityEngine;
using System.Collections.Generic;
using System.Text;
using Mirzipan.Extensions.Text;

namespace Mirzipan.Extensions.Unity
{
    public static class TransformExtensions
    {
        public static void CopyPositionAndRotation(this Transform @this, Transform source)
        {
            @this.position = source.position;
            @this.rotation = source.rotation;
        }

        #region Position

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
        
        #endregion Position
        
        #region Reset

        public static Transform ResetPosition(this Transform @this)
        {
            @this.position = Vector3.zero;
            return @this;
        }

        public static Transform ResetLocalPosition(this Transform @this)
        {
            @this.localPosition = Vector3.zero;
            return @this;
        }

        public static Transform ResetRotation(this Transform @this)
        {
            @this.rotation = Quaternion.identity;
            return @this;
        }

        public static Transform ResetLocalRotation(this Transform @this)
        {
            @this.localRotation = Quaternion.identity;
            return @this;
        }

        public static Transform ResetLocalScale(this Transform @this)
        {
            @this.localScale = Vector3.one;
            return @this;
        }

        public static Transform Reset(this Transform @this)
        {
            @this.position = Vector3.zero;
            @this.rotation = Quaternion.identity;
            @this.localScale = Vector3.one;
            return @this;
        }

        public static Transform ResetLocal(this Transform @this)
        {
            @this.localPosition = Vector3.zero;
            @this.localRotation = Quaternion.identity;
            @this.localScale = Vector3.one;
            return @this;
        }

        #endregion Reset

        #region Children

        public static List<T> GetChildren<T>(this Transform @this) where T : Component
        {
            var result = new List<T>();
            for (int i = 0; i < @this.childCount; i++)
            {
                var comp = @this.GetChild(i).GetComponent<T>();
                if (comp)
                {
                    result.Add(comp);
                }
            }

            return result;
        }

        public static void DestroyChildren<T>(this Transform @this) where T : Component
        {
            for (int i = 0; i < @this.childCount; i++)
            {
                var comp = @this.GetChild(i).GetComponent<T>();
                if (!comp)
                {
                    continue;
                }

#if UNITY_EDITOR
                if (Application.isPlaying)
                {
                    Object.Destroy(comp.gameObject);
                    continue;
                }

                Object.DestroyImmediate(comp.gameObject);
#else
                Object.Destroy(comp.gameObject);
#endif
            }
        }

        public static void DestroyChildren(this Transform @this)
        {
            for (int i = 0; i < @this.childCount; i++)
            {
                var go = @this.GetChild(i).gameObject;

#if UNITY_EDITOR
                if (Application.isPlaying)
                {
                    Object.Destroy(go);
                    continue;
                }

                Object.DestroyImmediate(go);
#else
                Object.Destroy(go);
#endif
            }
        }

        #endregion Children

        #region Hierarchy

        public static Transform Root(this Transform @this)
        {
            if (!@this.parent)
            {
                return @this;
            }

            var current = @this;
            while (current.parent)
            {
                current = current.parent;
            }

            return current;
        }

        public static string Path(this Transform @this)
        {
            if (!@this.parent)
            {
                return @this.gameObject.name;
            }

            const char divider = '/';
            var sb = new StringBuilder();
            sb.Append(divider);
            sb.Append(@this.gameObject.name);
            
            var current = @this;
            while (current.parent)
            {
                current = current.parent;
                sb.Prepend(current.gameObject.name);
                sb.Prepend(divider);
            }

            return sb.ToString();
        }

        #endregion Hierarchy
    }
}