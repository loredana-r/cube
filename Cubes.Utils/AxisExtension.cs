using System;
using Cubes.Public;

namespace Cubes.Utils
{
	public static class AxisExtension
	{
		public static bool IntersectsWith(this IAxis first, IAxis second) =>
			Difference(first, second) >= 0;

		public static double Overlap(this IAxis first, IAxis second) =>
			Math.Max(0, Difference(first, second));

		private static double Difference(this IAxis first, IAxis second) =>
			Math.Min(first.Top, second.Top) - Math.Max(first.Bottom, second.Bottom);
	}
}
