namespace Cubes.Public
{
	public interface ICube
	{
		IAxis XAxis { get; set; }
		IAxis YAxis { get; set; }
		IAxis ZAxis { get; set; }
	}
}
