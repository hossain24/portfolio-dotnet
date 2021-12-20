using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelerAPI.Models;

namespace TravelerAPI.Repositories
{
	public interface IMountainRepo
	{
		IEnumerable<Mountain> GetAllMountains();
	}
}
