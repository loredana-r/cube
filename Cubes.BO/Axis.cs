using Cubes.Public;

namespace Cubes.BO
{
	public class Axis:IAxis
	{
		public double Bottom { get; set; }
		public double Top { get; set; }

		public Axis(int center, int length)
		{
			Bottom = center - length / 2.0;
			Top = center + length / 2.0;
		}
	}
}
