namespace Cubes.Public
{
	public interface ICubeService
	{
		bool Collide(ICube firstCube, ICube secondCube);
		double GetIntersectionVolume(ICube firstCube, ICube secondCube);
	}
}
