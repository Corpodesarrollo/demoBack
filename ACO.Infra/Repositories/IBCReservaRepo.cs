using ACO.Core.Interfaces.Repositories;
using ACO.Core.Models;
using ACO.Infra;
using ClosedXML.Excel;
using Dapper;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace ACO.Infra.Repositories;
public class IBCReservaRepo : IIBCReservaRepo
{
    #region Propiedades
    private DbContext _DapperCtx;
    #endregion

    public IBCReservaRepo(DbContext pDapperCtx)
    {
        _DapperCtx = pDapperCtx;
    }

    async Task<List<EmpresaResponse>> IIBCReservaRepo.ObtenerEmpresas(string prefixtext, int count)
    {
        //string query = $"SELECT TOP ({count}) IdentificationNumber IdEmpresa, CONCAT(IdType_Code,'|',IdentificationNumber,'|',Name) NombreEmpresa FROM VEntidadReferencia WHERE LOWER(CONCAT(IdType_Code,'|',IdentificationNumber,'|',Name)) LIKE LOWER('%{prefixtext}%')";
        //using IDbConnection cn = _DapperCtx.CreateConnectionTransversal();
        string query = $"SELECT TOP ({count}) NroIdEntidad IdEmpresa, CONCAT(TipoIdEntidad,'|',NroIdEntidad,'|',NombreEntidad) NombreEmpresa FROM VACOEntidadAutorizada WHERE LOWER(CONCAT(TipoIdEntidad,'|',NroIdEntidad,'|',NombreEntidad)) LIKE LOWER('%{prefixtext}%')";
        using IDbConnection cn = _DapperCtx.CreateConnection();


        return (await cn.QueryAsync<EmpresaResponse>(query)).ToList();
    }

    async Task<List<AniosCorteResponse>> IIBCReservaRepo.ObtenerAniosCorte()
    {
        string query = "SELECT FORMAT(DATEADD(YEAR,number,'20070101'),'yyyy') IdAnio, FORMAT(DATEADD(YEAR,number,'20070101'),'yyyy') NombreAnio FROM master.dbo.spt_values WHERE type = 'P' AND DATEADD(YEAR,number,'20070101') <= GETDATE() ORDER BY number DESC";
        using IDbConnection cn = _DapperCtx.CreateConnection();

        return (await cn.QueryAsync<AniosCorteResponse>(query)).ToList();
    }

    async Task<List<MesesCorteResponse>> IIBCReservaRepo.ObtenerMesesCorte()
    {
        List<MesesCorteResponse> lmesescorte = new List<MesesCorteResponse>();
        string page = "https://web.sispro.gov.co/DirectorioGeneral/API/PISISMesFinTrimestre";
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using (HttpResponseMessage response = await client.GetAsync(page))
            using (HttpContent content = response.Content)
            {
                DirectorioGeneral result = await content.ReadAsAsync<DirectorioGeneral>();
                if (result != null)
                {
                    foreach (var item in result.items)
                    {
                        lmesescorte.Add(new MesesCorteResponse(item.codigo, item.nombre));
                    }
                }
            }
        }

        return lmesescorte;
    }

    async Task<List<ReporteIBCResumen1Response>> IIBCReservaRepo.ObtenerReporte(decimal IdEmpresa, int IdAnio, int IdMes, bool cruce)
    {
        using IDbConnection cn = _DapperCtx.CreateConnection();
        DynamicParameters p = new DynamicParameters();
        p.Add("pTipoID", "NI", DbType.String, ParameterDirection.Input);
        p.Add("pNumID", IdEmpresa, DbType.Decimal, ParameterDirection.Input);
        p.Add("pAnioCorte", IdAnio, DbType.Int32, ParameterDirection.Input);
        p.Add("pMesCorte", IdMes, DbType.Int32, ParameterDirection.Input);
        p.Add("pCruce", cruce?1:0, DbType.Boolean, ParameterDirection.Input);
        p.Add("pDetalle", 0, DbType.Int32, ParameterDirection.Input);
        p.Add("pTotalReservaEspecial500", 0, DbType.Int32, ParameterDirection.Output);
        p.Add("pTotalReservaEspecial501", 0, DbType.Int32, ParameterDirection.Output);
        p.Add("observacionVRef", "", DbType.String, ParameterDirection.Output);
        return (await cn.QueryAsync<ReporteIBCResumen1Response>("dbo.PRBACOReservaIBC",p, commandType: CommandType.StoredProcedure)).ToList();
    }

    async Task<ReporteDescargaResponse> IIBCReservaRepo.DescargarReporte(decimal IdEmpresa, int IdAnio, int IdMes, bool cruce)
    {
        using IDbConnection cn = _DapperCtx.CreateConnection();
        DynamicParameters p = new DynamicParameters();
        p.Add("pTipoID", "NI", DbType.String, ParameterDirection.Input);
        p.Add("pNumID", IdEmpresa, DbType.Decimal, ParameterDirection.Input);
        p.Add("pAnioCorte", IdAnio, DbType.Int32, ParameterDirection.Input);
        p.Add("pMesCorte", IdMes, DbType.Int32, ParameterDirection.Input);
        p.Add("pCruce", cruce, DbType.Boolean, ParameterDirection.Input);
        p.Add("pDetalle", 0, DbType.Int32, ParameterDirection.Input);
        p.Add("pTotalReservaEspecial500", 0, DbType.Int32, ParameterDirection.Output);
        p.Add("pTotalReservaEspecial501", 0, DbType.Int32, ParameterDirection.Output);
        p.Add("observacionVRef", "", DbType.String, ParameterDirection.Output);
        List<ReporteIBCResumen1Response> resumen = (await cn.QueryAsync<ReporteIBCResumen1Response>("dbo.PRBACOReservaIBC", p, commandType: CommandType.StoredProcedure)).ToList();

        //Inicio creando excel
        XLWorkbook Workbook = new XLWorkbook(AppDomain.CurrentDomain.BaseDirectory + "Repositories\\Recursos\\PlantillaReporteIBCReserva.xlsx");
        IXLWorksheet Worksheet = Workbook.Worksheet(1);
        Worksheet.Row(1).Cell(3).Value = IdEmpresa;
        Worksheet.Row(2).Cell(3).Value = DateTime.Parse(IdAnio+"-"+ IdMes).ToString("yyyy/MM");
        
        for (int i = 0; i < resumen.Count; i++)
        {
            ReporteIBCResumen1Response row = resumen[i];
            Worksheet.Row(5 + i).Cell(1).Value = row.Cantidad;
            Worksheet.Row(5 + i).Cell(2).Value = row.IbcAco;
            Worksheet.Row(5 + i).Cell(3).Value = row.Cantidad;
            Worksheet.Row(5 + i).Cell(4).Value = row.AporteSalud;
            Worksheet.Row(5 + i).Cell(5).Value = row.ReservaSalud;
            Worksheet.Row(5 + i).Cell(6).Value = row.TotalReservaSalud;
            Worksheet.Row(5 + i).Cell(7).Value = row.Cantidad;
            Worksheet.Row(5 + i).Cell(8).Value = row.AportePension;
            Worksheet.Row(5 + i).Cell(9).Value = row.ReservaPension;
            Worksheet.Row(5 + i).Cell(10).Value = row.TotalReservaPension;
            Worksheet.Row(5 + i).Cell(11).Value = row.Cantidad;
            Worksheet.Row(5 + i).Cell(12).Value = row.AporteRiesgo;
            Worksheet.Row(5 + i).Cell(13).Value = row.ReservaRiesgo;
            Worksheet.Row(5 + i).Cell(14).Value = row.TotalReservaRiesgo;

            Worksheet.Row(9 + i).Cell(10).Value = row.TotalReservaEspecial;
        }

        p = new DynamicParameters();
        p.Add("pTipoID", "NI", DbType.String, ParameterDirection.Input);
        p.Add("pNumID", IdEmpresa, DbType.Decimal, ParameterDirection.Input);
        p.Add("pAnioCorte", IdAnio, DbType.Int32, ParameterDirection.Input);
        p.Add("pMesCorte", IdMes, DbType.Int32, ParameterDirection.Input);
        p.Add("pCruce", cruce, DbType.Boolean, ParameterDirection.Input);
        p.Add("pDetalle", 1, DbType.Int32, ParameterDirection.Input);
        p.Add("pTotalReservaEspecial500", 0, DbType.Int32, ParameterDirection.Output);
        p.Add("pTotalReservaEspecial501", 0, DbType.Int32, ParameterDirection.Output);
        p.Add("observacionVRef", "", DbType.String, ParameterDirection.Output);
        List<ReporteIBCResumen1Response> detalllado = (await cn.QueryAsync<ReporteIBCResumen1Response>("dbo.PRBACOReservaIBC", p, commandType: CommandType.StoredProcedure)).ToList();

        float cantAfiliados = 0;
        Worksheet = Workbook.Worksheet(2);
        for (int i = 0; i < detalllado.Count; i++)
        {
            ReporteIBCResumen1Response row = detalllado[i];
            Worksheet.Row(3 + i).Cell(1).Value = row.Cantidad;
            Worksheet.Row(3 + i).Cell(2).Value = row.IbcAco;
            Worksheet.Row(3 + i).Cell(3).Value = row.Cantidad;
            Worksheet.Row(3 + i).Cell(4).Value = row.AporteSalud;
            Worksheet.Row(3 + i).Cell(5).Value = row.ReservaSalud;
            Worksheet.Row(3 + i).Cell(6).Value = row.TotalReservaSalud;
            Worksheet.Row(3 + i).Cell(7).Value = row.Cantidad;
            Worksheet.Row(3 + i).Cell(8).Value = row.AportePension;
            Worksheet.Row(3 + i).Cell(9).Value = row.ReservaPension;
            Worksheet.Row(3 + i).Cell(10).Value = row.TotalReservaPension;
            Worksheet.Row(3 + i).Cell(11).Value = row.Cantidad;
            Worksheet.Row(3 + i).Cell(12).Value = row.AporteRiesgo;
            Worksheet.Row(3 + i).Cell(13).Value = row.ReservaRiesgo;
            Worksheet.Row(3 + i).Cell(14).Value = row.TotalReservaRiesgo;
            Worksheet.Row(3 + i).Cell(15).Value = row.TotalReservaSalud + row.TotalReservaPension + row.TotalReservaRiesgo;
            cantAfiliados = cantAfiliados + row.Cantidad;
        }
        Worksheet = Workbook.Worksheet(1);
        Worksheet.Row(7).Cell(1).Value = cantAfiliados;
        MemoryStream ms = new MemoryStream();
        Workbook.SaveAs(ms);
        string base64 = Convert.ToBase64String(ms.ToArray());
        ReporteDescargaResponse reporte = new ReporteDescargaResponse($"ReporteReservaIBC_{IdEmpresa}_{IdAnio}_{IdMes}", "xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", base64);
        return reporte;
    }

    async Task<List<ReporteConsolidadoResponse>> IIBCReservaRepo.ObtenerConsolidadoReporte(int IdAnio, int IdMes, int OffSet, int PageSize)
    {
        using IDbConnection cn = _DapperCtx.CreateConnection();
        DynamicParameters p = new DynamicParameters();
        p.Add("pAnioCorte", IdAnio, DbType.Int32, ParameterDirection.Input);
        p.Add("pMesCorte", IdMes, DbType.Int32, ParameterDirection.Input);
        p.Add("pOffSet", OffSet, DbType.Int32, ParameterDirection.Input);
        p.Add("pPageSize", PageSize, DbType.Int32, ParameterDirection.Input);
        return (await cn.QueryAsync<ReporteConsolidadoResponse>("dbo.PRBACOConsolidadoReserva", p, commandType: CommandType.StoredProcedure, commandTimeout: 120)).ToList();
    }

    async Task<ReporteDescargaResponse> IIBCReservaRepo.DescargarConsolidadoReporte(int IdAnio, int IdMes)
    {
        using IDbConnection cn = _DapperCtx.CreateConnection();
        DynamicParameters p = new DynamicParameters();
        p.Add("pAnioCorte", IdAnio, DbType.Int32, ParameterDirection.Input);
        p.Add("pMesCorte", IdMes, DbType.Int32, ParameterDirection.Input);
        p.Add("pOffSet", 0, DbType.Int32, ParameterDirection.Input);
        p.Add("pPageSize", 10000, DbType.Int32, ParameterDirection.Input);
        List<ReporteConsolidadoResponse> detalllado = (await cn.QueryAsync<ReporteConsolidadoResponse>("dbo.PRBACOConsolidadoReserva", p, commandType: CommandType.StoredProcedure, commandTimeout: 120)).ToList();

        //Inicio creando excel
        XLWorkbook Workbook = new XLWorkbook(AppDomain.CurrentDomain.BaseDirectory + "Repositories\\Recursos\\PlantillaConsolidadoReserva.xlsx");
        IXLWorksheet Worksheet = Workbook.Worksheet(1);
        //Llenado
        for (int i = 0; i < detalllado.Count; i++)
        {
            ReporteConsolidadoResponse row = detalllado[i];
            Worksheet.Row(2 + i).Cell(1).Value = row.NombreEntidad;
            Worksheet.Row(2 + i).Cell(2).Value = row.NitEntidad;
            Worksheet.Row(2 + i).Cell(3).Value = row.NAfiliadosR4;
            Worksheet.Row(2 + i).Cell(4).Value = row.NAfiliadosR2;
            Worksheet.Row(2 + i).Cell(5).Value = row.NAfiliadosSalud;
            Worksheet.Row(2 + i).Cell(6).Value = row.NAfiliadosPension;
            Worksheet.Row(2 + i).Cell(7).Value = row.NAfiliadosRiesgo;
            Worksheet.Row(2 + i).Cell(8).Value = row.CertificadoRLegal;
            Worksheet.Row(2 + i).Cell(9).Value = row.ValorSuficiencia;
            Worksheet.Row(2 + i).Cell(10).Value = row.ValorReferencia;
            Worksheet.Row(2 + i).Cell(11).Value = row.ObservacionVRef;
        }
            MemoryStream ms = new MemoryStream();
        Workbook.SaveAs(ms);
        string base64 = Convert.ToBase64String(ms.ToArray());
        ReporteDescargaResponse reporte = new ReporteDescargaResponse($"ReporteConsolidadoReserva_{IdAnio}_{IdMes}", "xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", base64);
        return reporte;
    }

    async Task<List<EntidadAutorizadaResponse>> IIBCReservaRepo.ConsultarEntidadesAutorizadas()
    {
        string query = $"SELECT " +
                                $"ea.TipoIdEntidad," +
                                $"ea.NroIdEntidad," +
                                $"tr.Nombre," +
                                $"ea.Resolucion," +
                                $"ea.FechaHabilitacion," +
                                $"ea.FechaDeshabilitacion," +
                                $"ea.UsuarioCreacion," +
                                $"ea.FechaHoraCreacion," +
                                $"ea.UsuarioActualizacion," +
                                $"ea.FechaHoraActualizacion," +
                                $"ea.Observacion " +
                        $"FROM TACOEntidadAutorizada ea, BDTRVSISPRO.dbo.TReferenciaBasica tr " +
                        $"WHERE   tr.TIPO = 'ACOEntidadAutorizada' AND " +
                                $"tr.Habilitado = 1 AND " +
                                $"tr.Codigo = ea.NroIdEntidad " +
                        $"ORDER BY tr.Nombre";
        using IDbConnection cn = _DapperCtx.CreateConnection();

        return (await cn.QueryAsync<EntidadAutorizadaResponse>(query)).ToList();
    }

    async Task<List<EntidadAutorizadaResponse>> IIBCReservaRepo.ConsultarTrazaEntidadAutorizada(string tipoIdEntidad, long nroIdEntidad)
    {
        string query = $"SELECT " +
                                $"ea.TipoIdEntidad," +
                                $"ea.NroIdEntidad," +
                                $"tr.Nombre," +
                                $"ea.Resolucion," +
                                $"ea.FechaHabilitacion," +
                                $"ea.FechaDeshabilitacion," +
                                $"ea.UsuarioCreacion," +
                                $"ea.FechaHoraCreacion," +
                                $"ea.UsuarioActualizacion," +
                                $"ea.FechaHoraActualizacion," +
                                $"ea.Observacion " +
                        $"FROM TACOEntidadAutorizada_History ea, BDTRVSISPRO.dbo.TReferenciaBasica tr " +
                        $"WHERE   tr.TIPO = 'ACOEntidadAutorizada' AND " +
                                $"tr.Habilitado = 1 AND " +
                                $"tr.Codigo = ea.NroIdEntidad AND " +
                                $"ea.TipoIdEntidad = '{tipoIdEntidad}' AND " +
                                $"ea.NroIdEntidad = {nroIdEntidad} " +
                        $"ORDER BY tr.Nombre";
        using IDbConnection cn = _DapperCtx.CreateConnection();

        return (await cn.QueryAsync<EntidadAutorizadaResponse>(query)).ToList();
    }
}