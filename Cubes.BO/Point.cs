using Cubes.Public;

namespace Cubes.BO
{
	public class Point : IPoint
	{
		public Point(int x, int y, int z)
		{
			X = x;
			Y = y;
			Z = z;
		}

		public int X { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
	}
}
