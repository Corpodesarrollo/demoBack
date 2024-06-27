using ACO.Core.Models;

namespace ACO.Core.Interfaces.Repositories;

public interface IConsultaUnificadaATRepo
{
    Task<List<ConsultaUnificadaATResponse>> Consultar(int IdAnio, int IdMes, bool Activas, int OffSet, int PageSize);
    Task<ReporteDescargaResponse> DescargarReporte(int IdAnio, int IdMes, bool Activas);

}
