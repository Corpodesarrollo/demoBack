using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACO.Core.Models
{
    public class EntidadAutorizadaResponse
    {
        public EntidadAutorizadaResponse() { }
        public EntidadAutorizadaResponse(string tipoIdEntidad, long nroIdEntidad, string nombre, string resolucion, DateTime fechaHabilitacion, DateTime fechaDeshabilitacion, string usuarioCreacion, DateTime fechaHoraCreacion, string usuarioActualizacion, DateTime fechaHoraActualizacion, string observacion) {
            this.TipoIdEntidad = tipoIdEntidad;
            this.NroIdEntidad = nroIdEntidad;
            this.Nombre = nombre;
            this.Resolucion = resolucion;
            this.FechaHabilitacion = fechaHabilitacion;
            this.FechaDeshabilitacion = fechaDeshabilitacion;
            this.UsuarioCreacion = usuarioCreacion;
            this.FechaHoraCreacion = fechaHoraCreacion;
            this.UsuarioActualizacion = usuarioActualizacion;
            this.FechaHoraActualizacion = fechaHoraActualizacion;
            this.Observacion = observacion;
        }

        public string TipoIdEntidad { get; set; }
        public long NroIdEntidad { get; set; }
        public string Nombre { get; set; }
        public string Resolucion { get; set; }
        public DateTime FechaHabilitacion { get; set; }
        public DateTime FechaDeshabilitacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaHoraCreacion { get; set; }
        public string UsuarioActualizacion { get; set; }
        public DateTime FechaHoraActualizacion { get; set; }
        public string Observacion { get; set; }
    }
}
