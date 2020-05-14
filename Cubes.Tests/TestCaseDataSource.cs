using Cubes.BO;
using NUnit.Framework;

namespace Cubes.Tests
{
	public class TestCaseDataSource
	{
		public static TestCaseData GetCubesThatDontTouch()
		{
			return new TestCaseData(new Cube(new Point(2, 2, 2), 2), new Cube(new Point(7, 7, 7), 2));
		}

		public static TestCaseData GetCubesThatDontTouchReversed()
		{
			return new TestCaseData(new Cube(new Point(7, 7, 7), 2), new Cube(new Point(2, 2, 2), 2));
		}

		public static TestCaseData GetCubesThatTouch()
		{
			return new TestCaseData(new Cube(new Point(2, 2, 2), 2), new Cube(new Point(4, 2, 2), 2));
		}

		public static TestCaseData GetCubesThatTouchReversed()
		{
			return new TestCaseData(new Cube(new Point(4, 2, 2), 2), new Cube(new Point(2, 2, 2), 2));
		}

		public static TestCaseData GetCubesThatOverlap()
		{
			return new TestCaseData(new Cube(new Point(3, 2, 2), 2), new Cube(new Point(2, 2, 2), 2));
		}

		public static TestCaseData GetCubesThatOverlapReversed()
		{
			return new TestCaseData(new Cube(new Point(2, 2, 2), 2), new Cube(new Point(3, 2, 2), 2));
		}
	}
}
