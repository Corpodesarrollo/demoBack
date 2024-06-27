using ACO.Api.Interfaces;
using ACO.Core.Interfaces.Repositories;
using ACO.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace ACO.Api.Controllers
{
    [ApiController]
    public class ConsultaUnificadaATController : Controller, IConsultaUnificadaATController
    {
        #region Propiedades
        private IConsultaUnificadaATRepo _Repo;
        #endregion

        public ConsultaUnificadaATController(IConsultaUnificadaATRepo pRepo)
        {
            _Repo = pRepo;
        }

        [HttpGet("ConsultarReporteUnificadoAT")]
        public async Task<List<ConsultaUnificadaATResponse>> Consultar(int IdAnio, int IdMes, bool Activas, int OffSet, int PageSize)
        {
            return await _Repo.Consultar(IdAnio, IdMes, Activas, OffSet, PageSize);
        }

        [HttpGet("DescargarConsultarReporteUnificadoAT")]
        public async Task<ReporteDescargaResponse> DescargarReporte(int IdAnio, int IdMes, bool Activas)
        {
            return await _Repo.DescargarReporte(IdAnio, IdMes, Activas);
        }
        
    }
}
