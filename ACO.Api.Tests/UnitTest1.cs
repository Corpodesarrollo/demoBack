//using ACO.Api.Client;
using SISPRO.TRV.Entity;
using SISPRO.TRV.General.Network;
using Microsoft.AspNetCore.Mvc.Testing;

namespace ACO.Api.Tests;


[TestClass]
public class UnitTest1
{	
	[TestInitialize]
	public void TestInitialize()
	{
		WebApplicationFactory<Program> app;

		HttpClient httpClient;

		User user = new User() { Alias = "test", Email = "test@test.com" };

		app = new WebApplicationFactory<Program>();

		httpClient = app.CreateClient();
		httpClient.DefaultRequestHeaders.AddAuthorizationHeader(user);

		// TODO: Definir el cliente del API, ej: _APIClient = new APIClient(null, httpClient);
	}
	
	[TestMethod]
    public void TestMethod()
    {
    }
}
