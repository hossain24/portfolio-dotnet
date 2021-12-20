using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelerAPI.Dto
{
	public class MountainReadDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public string Height { get; set; }
		public string Color { get; set; }
		public string Place { get; set; }
	}
}
