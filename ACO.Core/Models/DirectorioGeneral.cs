using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACO.Core.Models
{
    public class DirectorioGeneral
    {
        /*
         
        "tref": "PISISMesFinTrimestre",
        "nombre": "PISISMesFinTrimestre",
        "descripcion": "PISISMesFinTrimestre",
        "habilitado": true,
        "lastUpdate": "2021-04-14T09:34:07.477",
        "items": [
            {
                "codigo": "12",
                "nombre": "Diciembre",
                "descripcion": "Diciembre",
                "habilitado": true,
                "extra_I": null,
                "extra_II": null,
                "extra_III": null,
                "extra_IV": null,
                "extra_V": null,
                "extra_VI": null,
                "extra_VII": null,
                "extra_VIII": null,
                "extra_IX": null,
                "extra_X": null,
                "valor": null,
                "creation": "2016-11-21T11:04:07.763",
                "lastUpdate": "2015-09-03T18:50:04.603"
            }
        ]
         
         */
        public String tref { get; set; }
        public String nombre { get; set; }
        public String descripcion {  get; set; }
        public Boolean habilitado {  get; set; }
        public String lastUpdate { get; set; }
        public List<DirectorioGeneralItem> items { get; set; }

    }
}
