using AutoMapper;
using ACO.Infra;
using ACO.Core.Interfaces.Repositories;
using ACO.Infra.Repositories;

namespace ACO.Api.Extensions
{
	internal static class StartupExtensions
	{
        public static WebApplicationBuilder CustomConfigureServices(this WebApplicationBuilder pBuilder)
        {
            pBuilder.Services.AddSingleton<DbContext>();
			
			pBuilder.Services.AddScoped<IGreetingsRepo, GreetingsRepo>();

            pBuilder.Services.AddScoped<IIBCReservaRepo, IBCReservaRepo>();

            pBuilder.Services.AddScoped<IConsultaUnificadaATRepo, ConsultaUnificadaATRepo>();

            //pBuilder.Services.AddScoped<IXXX, XXXRepo>();

            //pBuilder.AutomapConfiguration();

            return pBuilder;
        }


        /*private static WebApplicationBuilder AutomapConfiguration(this WebApplicationBuilder pBuilder)
        {
            MapperConfiguration mapConf = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<XXX__Request, XXX>();
                });

            pBuilder.Services.AddSingleton(mapConf.CreateMapper());

            return pBuilder;
        }*/
    }
}
