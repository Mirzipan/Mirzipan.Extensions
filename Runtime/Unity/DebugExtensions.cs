using UnityEngine;

namespace Mirzipan.Extensions.Unity
{
	public static class DebugExtensions
	{
		public static void DrawSphere(Vector3 center, float radius, Color color, float duration, bool depth_test)
		{
            const int SEGMENTS_COUNT = 18;
		
			float segment_angle = Mathf.PI * 2 / SEGMENTS_COUNT;
			for (int segment = 0; segment < SEGMENTS_COUNT; ++segment)
			{
				float angle_from = segment       * segment_angle;
				float angle_to   = (segment + 1) * segment_angle;

				Vector3 from = new (Mathf.Cos(angle_from) * radius, Mathf.Sin(angle_from) * radius, 0);
				Vector3 to   = new (Mathf.Cos(angle_to)   * radius, Mathf.Sin(angle_to)   * radius, 0);

				Debug.DrawLine(from + center, to + center, color, duration, depth_test);

				void Swap<T>(ref T a, ref T b)
				{
					(a, b) = (b, a);
				}

				Swap(ref from.x, ref from.z);
				Swap(ref to.x,   ref to.z);
				Debug.DrawLine(from + center, to + center, color, duration, depth_test);

				Swap(ref from.x, ref from.y);
				Swap(ref to.x,   ref to.y);
				Debug.DrawLine(from + center, to + center, color, duration, depth_test);
			}
		}

		public static void DrawBox(Vector3 a, Vector3 b, Color color, float duration, bool depth_test)
		{
			Debug.DrawLine(new Vector3(a.x, a.y, a.z), new Vector3(b.x, a.y, a.z), color, duration, depth_test);
			Debug.DrawLine(new Vector3(b.x, a.y, a.z), new Vector3(b.x, a.y, b.z), color, duration, depth_test);
			Debug.DrawLine(new Vector3(b.x, a.y, b.z), new Vector3(a.x, a.y, b.z), color, duration, depth_test);
			Debug.DrawLine(new Vector3(a.x, a.y, b.z), new Vector3(a.x, a.y, a.z), color, duration, depth_test);

			Debug.DrawLine(new Vector3(a.x, b.y, a.z), new Vector3(b.x, b.y, a.z), color, duration, depth_test);
			Debug.DrawLine(new Vector3(b.x, b.y, a.z), new Vector3(b.x, b.y, b.z), color, duration, depth_test);
			Debug.DrawLine(new Vector3(b.x, b.y, b.z), new Vector3(a.x, b.y, b.z), color, duration, depth_test);
			Debug.DrawLine(new Vector3(a.x, b.y, b.z), new Vector3(a.x, b.y, a.z), color, duration, depth_test);

			Debug.DrawLine(new Vector3(a.x, a.y, a.z), new Vector3(a.x, b.y, a.z), color, duration, depth_test);
			Debug.DrawLine(new Vector3(b.x, a.y, a.z), new Vector3(b.x, b.y, a.z), color, duration, depth_test);
			Debug.DrawLine(new Vector3(b.x, a.y, b.z), new Vector3(b.x, b.y, b.z), color, duration, depth_test);
			Debug.DrawLine(new Vector3(a.x, a.y, b.z), new Vector3(a.x, b.y, b.z), color, duration, depth_test);
		}
	}
}