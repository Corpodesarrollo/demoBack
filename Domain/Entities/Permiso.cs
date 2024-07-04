using Authentication.Domain.Common;

namespace Secani.Data.Models
{
    public class Permiso : BaseEntity
    {
        public int ModuloId { get; set; }
        public int FuncionalidadId { get; set; }
        public string Descripcion { get; set; }
        public bool CanView { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDele { get; set; }
        public bool CanAdd { get; set; }
    }
}
