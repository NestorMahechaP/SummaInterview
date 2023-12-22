﻿using Argos.Summa.Service.Interface;
using Argos.Summa.Util.Enums;
using Argos.Summa.Util.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Argos.Summa.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AgentBController : ControllerBase
	{
		private IAgent _agent;
		public AgentBController([FromKeyedServices("B")] IAgent agent)
		{
			_agent = agent;
		}

		[HttpPost]
		public IActionResult GetMedia(List<double> data)
		{
			try
			{
				if (data.Count == 0)
				{
					return BadRequest(EnumHelper.GetDescription(EResult.InvalidBodyRequest));
				}
				if (data.Any(x => x == 0))
				{
					return BadRequest(EnumHelper.GetDescription(EResult.InvalidZeroMember));
				}
				return Ok(_agent.GetMedia(data));
			}
			catch
			{
				return BadRequest(EnumHelper.GetDescription(EResult.ServerError));
			}
		}

		[HttpGet("{size}")]
		public IActionResult GetStairCase(int size)
		{
			try
			{
				if (size < 0 || size > 100)
				{
					return BadRequest(EnumHelper.GetDescription(EResult.InvalidBodyRequest));
				}
				return Ok(_agent.GetStairCase(size));
			}
			catch
			{
				return BadRequest(EnumHelper.GetDescription(EResult.ServerError));
			}
		}
	}
}
