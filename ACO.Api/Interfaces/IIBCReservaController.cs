using ACO.Core.Models;

namespace ACO.Api.Interfaces;


public interface IIBCReservaController
{
    Task<List<MesesCorteResponse>> ObtenerMesesCorte();

    Task<List<AniosCorteResponse>> ObtenerAniosCorte();

    Task<List<EmpresaResponse>> ObtenerEmpresas(string prefixtext, int count);

    Task<List<ReporteIBCResumen1Response>> ObtenerReporte(Decimal IdEmpresa, int IdAnio, int IdMes, bool cruce);

    Task<ReporteDescargaResponse> DescargarReporte(Decimal IdEmpresa, int IdAnio, int IdMes, bool cruce);

    Task<List<ReporteConsolidadoResponse>> ObtenerConsolidadoReporte(int IdAnio, int IdMes, int OffSet, int PageSize);

    Task<ReporteDescargaResponse> DescargarConsolidadoReporte(int IdAnio, int IdMes);

}
