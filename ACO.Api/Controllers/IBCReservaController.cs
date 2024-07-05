using ACO.Api.Interfaces;
using ACO.Core.Interfaces.Repositories;
using ACO.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ACO.Api.Controllers
{
    [ApiController]
    public class IBCReservaController : Controller, IIBCReservaController
    {
        #region Propiedades
        private IIBCReservaRepo _Repo;
        #endregion

        public IBCReservaController(IIBCReservaRepo pRepo)
        {
            _Repo = pRepo;
        }

        [HttpGet("MesesCorte")]
        public async Task<List<MesesCorteResponse>> ObtenerMesesCorte()
        {
            return await _Repo.ObtenerMesesCorte();
        }

        [HttpGet("AniosCorte")]
        public async Task<List<AniosCorteResponse>> ObtenerAniosCorte()
        {
            return await _Repo.ObtenerAniosCorte();
        }

        [HttpGet("ListaEmpresas")]
        public async Task<List<EmpresaResponse>> ObtenerEmpresas(string prefixtext, int count)
        {
            return await _Repo.ObtenerEmpresas(prefixtext, count);
        }

        [HttpGet("ConsultarReporte")]
        public async Task<List<ReporteIBCResumen1Response>> ObtenerReporte(Decimal IdEmpresa, int IdAnio, int IdMes, bool cruce)
        {
            return await _Repo.ObtenerReporte(IdEmpresa, IdAnio, IdMes, cruce);
        }

        [HttpGet("DescargarReporte")]
        public async Task<ReporteDescargaResponse> DescargarReporte(Decimal IdEmpresa, int IdAnio, int IdMes, bool cruce)
        {
            return await _Repo.DescargarReporte(IdEmpresa, IdAnio, IdMes, cruce);
        }

        [HttpGet("ConsultarConsolidadoReporte")]
        public async Task<List<ReporteConsolidadoResponse>> ObtenerConsolidadoReporte(int IdAnio, int IdMes, int OffSet, int PageSize)
        {
            return await _Repo.ObtenerConsolidadoReporte(IdAnio, IdMes, OffSet, PageSize);
        }

        [HttpGet("DescargarConsolidadoReporte")]
        public async Task<ReporteDescargaResponse> DescargarConsolidadoReporte(int IdAnio, int IdMes)
        {
            return await _Repo.DescargarConsolidadoReporte(IdAnio, IdMes);
        }

        [HttpGet("ConsultarEntidadesAutorizadas")]
        public async Task<List<EntidadAutorizadaResponse>> ConsultarEntidadesAutorizadas()
        {
            return await _Repo.ConsultarEntidadesAutorizadas();
        }

        [HttpGet("ConsultarTrazaEntidadAutorizada")]
        public async Task<List<EntidadAutorizadaResponse>> ConsultarTrazaEntidadAutorizada(string tipoIdEntidad, long nroIdEntidad)
        {
            return await _Repo.ConsultarTrazaEntidadAutorizada(tipoIdEntidad, nroIdEntidad);
        }

        [HttpPost("HabilitarEntidadAutorizada")]
        public async Task<List<EntidadAutorizadaResponse>> HabilitarEntidadAutorizada(string tipoIdEntidad, long nroIdEntidad, string resolucionHabilitacion, string fechaHabilitacion)
        {
            return await _Repo.ConsultarTrazaEntidadAutorizada(tipoIdEntidad, nroIdEntidad);
        }
    }
}
