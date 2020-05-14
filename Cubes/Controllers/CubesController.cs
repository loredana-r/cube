using Cubes.BO;
using Cubes.Models;
using Cubes.Public;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Cubes.Controllers
{
	public class CubesController : ApiController
	{
		private readonly ICubeService _cubeService;

		public CubesController(ICubeService cubeService)
		{
			_cubeService = cubeService;
		}

		[HttpGet]
		public HttpResponseMessage CheckCollision()
		{
			//TODO - To be removed, this should be obtained from frontend application
			// here just for demonstration purposes
			var first = new Cube(new Point(2, 2, 2), 2);
			var second = new Cube(new Point(4, 2, 2), 2);

			var collide = _cubeService.Collide(first, first);
			var volume = _cubeService.GetIntersectionVolume(second, second);

			var response = new CubeCollisionModel() { Collide = collide, IntersectionVolume = volume };

			return Request.CreateResponse(HttpStatusCode.OK, response);
		}
	}
}
