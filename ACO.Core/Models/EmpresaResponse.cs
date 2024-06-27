using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACO.Core.Models
{
    public class EmpresaResponse
    {
        public EmpresaResponse(Decimal idEmpresa, string nombreEmpresa)
        {
            IdEmpresa = idEmpresa;
            NombreEmpresa = nombreEmpresa;
        }

        public Decimal IdEmpresa { get; set; }
        public string NombreEmpresa { get; set; }
    }

    
}
