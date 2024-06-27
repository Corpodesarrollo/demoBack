using ACO.Core.Models;

namespace ACO.Api.Interfaces;


public interface IGreetingsController
{
	Task<string> SayHi(Greetings_SayHi_Request pData);
}
