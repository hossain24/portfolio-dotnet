using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelerAPI.Dto;
using TravelerAPI.Models;

namespace TravelerAPI.Profiles
{
	public class MountainsProfile : Profile
	{
		public MountainsProfile()
		{
			//Source -> Target
			CreateMap<Mountain, MountainReadDto>();
		}
	}
}
