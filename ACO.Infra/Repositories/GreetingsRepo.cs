using ACO.Core.Interfaces.Repositories;
using ACO.Core.Models;

namespace ACO.Infra.Repositories;

public class GreetingsRepo : IGreetingsRepo
{
	public async Task<string> SayHi (Greetings_SayHi_Request pData)
	{
		return $"Hi {pData.Name}, whats going on? You are {pData.AgeYears} years old";
	}	
}
