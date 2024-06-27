using ACO.Core.Interfaces.Repositories;
using ACO.Api.Interfaces;
using ACO.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ACO.Api.Controllers;

[ApiController]
public class GreetingsController : Controller, IGreetingsController
{
	private IGreetingsRepo _Repo;
	
	
	public GreetingsController(IGreetingsRepo pRepo)
	{
		_Repo = pRepo;
	}
	
	
	[HttpPost("Hi")]
	public async Task<string> SayHi([FromBody] Greetings_SayHi_Request pData)
	{
		return await _Repo.SayHi(pData);
	}
}
