using Cubes.Public;
using Cubes.Services;
using NUnit.Framework;
using System.Collections.Generic;

namespace Cubes.Tests.Services
{
	public class CubeServiceTest
	{
		private ICubeService _cubeService;

		private static IEnumerable<TestCaseData> CollidingCubesTestCaseData
		{
			get
			{
				yield return TestCaseDataSource.GetCubesThatDontTouch().Returns(false);
				yield return TestCaseDataSource.GetCubesThatDontTouchReversed().Returns(false);
				yield return TestCaseDataSource.GetCubesThatTouch().Returns(true);
				yield return TestCaseDataSource.GetCubesThatTouchReversed().Returns(true);
				yield return TestCaseDataSource.GetCubesThatOverlap().Returns(true);
				yield return TestCaseDataSource.GetCubesThatOverlapReversed().Returns(true);
			}
		}

		private static IEnumerable<TestCaseData> CubesVolumeTestCaseData
		{
			get
			{
				yield return TestCaseDataSource.GetCubesThatDontTouch().Returns(0);
				yield return TestCaseDataSource.GetCubesThatDontTouchReversed().Returns(0);
				yield return TestCaseDataSource.GetCubesThatTouch().Returns(0);
				yield return TestCaseDataSource.GetCubesThatTouchReversed().Returns(0);
				yield return TestCaseDataSource.GetCubesThatOverlap().Returns(4);
				yield return TestCaseDataSource.GetCubesThatOverlapReversed().Returns(4);
			}
		}

		[SetUp]
		public void Init()
		{
			_cubeService = new CubeService();
		}

		[Test, TestCaseSource("CollidingCubesTestCaseData")]
		public bool CollidingCubesTest(ICube first, ICube second) => _cubeService.Collide(first, second);

		[Test, TestCaseSource("CubesVolumeTestCaseData")]
		public double CubesVolumeTest(ICube first, ICube second) => _cubeService.GetIntersectionVolume(first, second);
	}
}
