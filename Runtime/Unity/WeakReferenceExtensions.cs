using System;

namespace Mirzipan.Extensions.Unity
{
	public static class WeakReferenceExtensions
	{
		public static T GetTargetOrNull<T>(this WeakReference<T> weak_reference) where T : class
		{
			return weak_reference.TryGetTarget(out var target) ? target : null; 
		}
	}
}