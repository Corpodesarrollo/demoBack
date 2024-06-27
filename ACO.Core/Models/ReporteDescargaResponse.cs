using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACO.Core.Models
{
    public class ReporteDescargaResponse
    {
        public ReporteDescargaResponse(string nombre, string extension, string mimetype, string archivo)
        {
            this.nombre = nombre;
            this.extension = extension;
            this.mimetype = mimetype;
            this.archivo = archivo;
        }
        public string nombre { get; set; }

        public string extension { get; set; }

        public string mimetype { get; set; }

        public string archivo { get; set; }
    }
}
