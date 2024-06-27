using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACO.Core.Models
{
    public class ReporteIBCResumen1Response
    {
        public float Cantidad { get; set; }
        public decimal IbcAco { get; set; }

        public decimal AporteSalud { get; set; }

        public decimal ReservaSalud { get; set; }

        public decimal TotalReservaSalud { get; set; }

        public decimal AportePension { get; set; }

        public decimal ReservaPension { get; set; }

        public decimal TotalReservaPension { get; set; }

        public decimal AporteRiesgo { get; set; }

        public decimal ReservaRiesgo { get; set; }

        public decimal TotalReservaRiesgo { get; set; }

        public decimal TotalReservaEspecial { get; set; }
    }
}
