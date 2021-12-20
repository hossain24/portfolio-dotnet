using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelerAPI.Dto;
using TravelerAPI.Repositories;

namespace TravelerAPI.Controllers
{
	[Route("api/mountains")]
	[ApiController]
	public class MountainController : Controller
	{
		private readonly IMountainRepo _repository;
		private readonly IMapper _mapper;

		public MountainController(IMountainRepo repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		[HttpGet]
		public ActionResult<IEnumerable<MountainReadDto>> GetAllMountains()
		{
			var mountainDetails = _repository.GetAllMountains();

			return Ok(_mapper.Map<IEnumerable<MountainReadDto>>(mountainDetails));
		}
	}
}
