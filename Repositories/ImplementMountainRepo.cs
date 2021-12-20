using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelerAPI.Models;

namespace TravelerAPI.Repositories
{
	public class ImplementMountainRepo : IMountainRepo
	{
		private readonly MountainContext _context;

		public ImplementMountainRepo(MountainContext context)
		{
			_context = context;
		}

		public IEnumerable<Mountain> GetAllMountains()
		{
			return _context.Mountains.ToList();
		}
	}
}
