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
public class ConsultaUnificadaATRepo : IConsultaUnificadaATRepo
{
    #region Propiedades
    private DbContext _DapperCtx;
    #endregion

    public ConsultaUnificadaATRepo(DbContext pDapperCtx)
    {
        _DapperCtx = pDapperCtx;
    }

    async Task<List<ConsultaUnificadaATResponse>> IConsultaUnificadaATRepo.Consultar(int IdAnio, int IdMes, bool Activas, int OffSet, int PageSize)
    {
        using IDbConnection cn = _DapperCtx.CreateConnection();
        DynamicParameters p = new DynamicParameters();
        p.Add("pAnioCorte", IdAnio, DbType.Int32, ParameterDirection.Input);
        p.Add("pMesCorte", IdMes, DbType.Int32, ParameterDirection.Input);
        p.Add("pActivas", Activas, DbType.Boolean, ParameterDirection.Input);
        p.Add("pOffSet", OffSet, DbType.Int32, ParameterDirection.Input);
        p.Add("pPageSize", PageSize, DbType.Int32, ParameterDirection.Input);
        return (await cn.QueryAsync<ConsultaUnificadaATResponse>("dbo.PRBACOConsultaUnificadaAT", p, commandType: CommandType.StoredProcedure, commandTimeout: 120)).ToList();
    }

    async Task<ReporteDescargaResponse> IConsultaUnificadaATRepo.DescargarReporte(int IdAnio, int IdMes, bool Activas)
    {
        using IDbConnection cn = _DapperCtx.CreateConnection();
        DynamicParameters p = new DynamicParameters();
        p.Add("pAnioCorte", IdAnio, DbType.Int32, ParameterDirection.Input);
        p.Add("pMesCorte", IdMes, DbType.Int32, ParameterDirection.Input);
        p.Add("pActivas", Activas, DbType.Boolean, ParameterDirection.Input);
        p.Add("pOffSet", 0, DbType.Int32, ParameterDirection.Input);
        p.Add("pPageSize", 10000, DbType.Int32, ParameterDirection.Input);
        List<ConsultaUnificadaATResponse> detalllado = (await cn.QueryAsync<ConsultaUnificadaATResponse>("dbo.PRBACOConsultaUnificadaAT", p, commandType: CommandType.StoredProcedure, commandTimeout: 120)).ToList();

        //Inicio creando excel
        XLWorkbook Workbook = new XLWorkbook(AppDomain.CurrentDomain.BaseDirectory + "Repositories\\Recursos\\PlantillaConsultaUnificadaAT.xlsx");
        IXLWorksheet Worksheet = Workbook.Worksheet(1);
        //Llenado
        for (int i = 0; i < detalllado.Count; i++)
        {
            ConsultaUnificadaATResponse row = detalllado[i];
            Worksheet.Row(2 + i).Cell(1).Value = row.TipoIdEntidad;
            Worksheet.Row(2 + i).Cell(2).Value = row.NroIdEntidad;
            Worksheet.Row(2 + i).Cell(3).Value = row.NombreEntidad;
            Worksheet.Row(2 + i).Cell(4).Value = row.Departamento;
            Worksheet.Row(2 + i).Cell(5).Value = row.Municipio;
            Worksheet.Row(2 + i).Cell(6).Value = row.Direccion;
            Worksheet.Row(2 + i).Cell(7).Value = row.Telefono;
            Worksheet.Row(2 + i).Cell(8).Value = row.Correo;
            Worksheet.Row(2 + i).Cell(9).Value = row.RepresentanteLegal;
            Worksheet.Row(2 + i).Cell(10).Value = row.ResolucionHabilitacion;
            Worksheet.Row(2 + i).Cell(11).Value = row.FechaHabilitacion;
            Worksheet.Row(2 + i).Cell(12).Value = row.ResolucionCancelacion;
            Worksheet.Row(2 + i).Cell(13).Value = row.FechaCancelacion;
            Worksheet.Row(2 + i).Cell(14).Value = row.Anexo240;
            Worksheet.Row(2 + i).Cell(15).Value = row.RACO240Reg;
            Worksheet.Row(2 + i).Cell(16).Value = row.RACO240OK;
            Worksheet.Row(2 + i).Cell(17).Value = row.IMAG240;
            Worksheet.Row(2 + i).Cell(18).Value = row.Anexo245;
            Worksheet.Row(2 + i).Cell(19).Value = row.RACO245Reg;
            Worksheet.Row(2 + i).Cell(20).Value = row.RACO245OK;
            Worksheet.Row(2 + i).Cell(21).Value = row.IMAG245;
        }
        MemoryStream ms = new MemoryStream();
        Workbook.SaveAs(ms);
        string base64 = Convert.ToBase64String(ms.ToArray());
        ReporteDescargaResponse reporte = new ReporteDescargaResponse($"ReporteConsultaUnificadaAT_{IdAnio}_{IdMes}", "xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", base64);
        return reporte;
    }
    
}