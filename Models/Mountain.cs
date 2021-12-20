using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TravelerAPI.Models
{
	public class Mountain
	{	[Key]
		[Required]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public string Height { get; set; }	
		public string Color { get; set; }
		public string Place { get; set; }
	}
}
