using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelerAPI.Models;

namespace TravelerAPI.Repositories
{
	public class MountainContext : DbContext
	{
		public MountainContext(DbContextOptions<MountainContext> opt) : base(opt)
		{

		}

		public DbSet<Mountain> Mountains { get; set; }
	}
}
