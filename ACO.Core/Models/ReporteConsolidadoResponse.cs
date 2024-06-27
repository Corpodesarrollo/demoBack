using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACO.Core.Models
{
    public class ReporteConsolidadoResponse
    {
        public string NombreEntidad { get; set; }

        public string NitEntidad { get; set; }

        public float NAfiliadosR4 { get; set; }

        public float NAfiliadosR2 { get; set; }

        public float NAfiliadosSalud { get; set; }

        public float NAfiliadosPension { get; set; }

        public float NAfiliadosRiesgo { get; set; }

        public decimal CertificadoRLegal {  get; set; }

        public decimal ValorSuficiencia { get; set; }

        public decimal ValorReferencia { get; set; }

        public string ObservacionVRef { get; set; }

        public float TotalRegistros { get; set; }

    }
}
