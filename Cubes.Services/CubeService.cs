using System;
using Cubes.Public;
using Cubes.Utils;

namespace Cubes.Services
{
	public class CubeService : ICubeService
	{
		public bool Collide(ICube first, ICube second)
		{
			CheckArguments(first, second);

			return first.XAxis.IntersectsWith(second.XAxis)
			       && first.YAxis.IntersectsWith(second.YAxis)
			       && first.ZAxis.IntersectsWith(second.ZAxis);
		}

		public double GetIntersectionVolume(ICube first, ICube second)
		{
			CheckArguments(first, second);

			return first.XAxis.Overlap(second.XAxis)
					* first.YAxis.Overlap(second.YAxis)
					* first.ZAxis.Overlap(second.ZAxis);
		}

		private void CheckArguments(ICube first, ICube second)
		{
			if (first == null)
				throw new ArgumentNullException(nameof(first));
			if (second == null)
				throw new ArgumentNullException(nameof(second));
		}
	}
}
