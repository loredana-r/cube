using Cubes.Public;

namespace Cubes.BO
{
	public class Cube : ICube
	{
		public IAxis XAxis { get; set; }
		public IAxis YAxis { get; set; }
		public IAxis ZAxis { get; set; }

		public Cube(IPoint center, int edgeLength)
		{
			XAxis = new Axis(center.X, edgeLength);
			YAxis = new Axis(center.Y, edgeLength);
			ZAxis = new Axis(center.Z, edgeLength);
		}
	}
}
