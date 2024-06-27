using ACO.Core.Models;

namespace ACO.Core.Interfaces.Repositories;

public interface IGreetingsRepo
{
	Task<string> SayHi (Greetings_SayHi_Request pData);
}
