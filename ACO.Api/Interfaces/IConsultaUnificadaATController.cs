using ACO.Core.Models;

namespace ACO.Api.Interfaces;


public interface IConsultaUnificadaATController
{
    Task<List<ConsultaUnificadaATResponse>> Consultar(int IdAnio, int IdMes, bool Activas, int OffSet, int PageSize);
    Task<ReporteDescargaResponse> DescargarReporte(int IdAnio, int IdMes, bool Activas);

}
