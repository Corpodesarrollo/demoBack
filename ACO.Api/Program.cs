#region Librerias

using ACO.Api.Extensions;
using ACO.Core.Models;
using SISPRO.TRV.General;
using SISPRO.TRV.Web.MVCCore.StartupExtensions;

#endregion

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

ReadConfig.FixLoadAppSettings (builder.Configuration);

builder.Services.AddCustomConfigureServicesPreviousMvc();
builder
	.Services
	.AddCustomMvcControllers()
    .AddJsonOptions()
	.AddFluentValidation<Greetings_SayHi_RequestValidator>();

builder.Services.AddCustomSwagger();

builder.Services.AddCustomAuthentication(true);

// Registro de los servicios
builder.CustomConfigureServices();

WebApplication app = builder.Build();

app.UseCustomConfigure();
app.UseCustomSwagger();

app.Run();
