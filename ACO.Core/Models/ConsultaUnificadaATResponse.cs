
namespace ACO.Core.Models;
public class ConsultaUnificadaATResponse
{

    public ConsultaUnificadaATResponse() { }

    public ConsultaUnificadaATResponse(string tipoIdEntidad, long nroIdEntidad, string nombreEntidad, string departamento, string municipio, string direccion, string telefono, string correo, string representanteLegal, string resolucionHabilitacion, string fechaHabilitacion, string resolucionCancelacion, string fechaCancelacion, string anexo240, float rACO240Reg, float rACO240OK, string iMAG240, string anexo245, float rACO245Reg, float rACO245OK, string iMAG245, float totalRegistros)
    {
        TipoIdEntidad = tipoIdEntidad;
        NroIdEntidad = nroIdEntidad;
        NombreEntidad = nombreEntidad;
        Departamento = departamento;
        Municipio = municipio;
        Direccion = direccion;
        Telefono = telefono;
        Correo = correo;
        RepresentanteLegal = representanteLegal;
        ResolucionHabilitacion = resolucionHabilitacion;
        FechaHabilitacion = fechaHabilitacion;
        ResolucionCancelacion = resolucionCancelacion;
        FechaCancelacion = fechaCancelacion;
        Anexo240 = anexo240;
        RACO240Reg = rACO240Reg;
        RACO240OK = rACO240OK;
        IMAG240 = iMAG240;
        Anexo245 = anexo245;
        RACO245Reg = rACO245Reg;
        RACO245OK = rACO245OK;
        IMAG245 = iMAG245;
        TotalRegistros = totalRegistros;

    }

    public string TipoIdEntidad { get; set; }
    public long NroIdEntidad { get; set; }
    public string NombreEntidad { get; set; }
    public string Departamento { get; set; }
    public string Municipio { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string RepresentanteLegal { get; set; }
    public string ResolucionHabilitacion { get; set; }
    public string FechaHabilitacion { get; set; }
    public string ResolucionCancelacion { get; set; }
    public string FechaCancelacion { get; set; }
    public string Anexo240 { get; set; }
    public float? RACO240Reg { get; set; }
    public float? RACO240OK { get; set; }
    public string IMAG240 { get; set; }
    public string Anexo245 { get; set; }
    public float? RACO245Reg { get; set; }
    public float? RACO245OK { get; set; }
    public string IMAG245 { get; set; }
    public float TotalRegistros { get; set; }
}
