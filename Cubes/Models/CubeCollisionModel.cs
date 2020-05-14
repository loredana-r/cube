using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cubes.Models
{
	public class CubeCollisionModel
	{
		public bool Collide { get; set; }
		public double IntersectionVolume { get; set; }
	}
}