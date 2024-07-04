using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Authentication.Domain.Common;

namespace Secani.Data.Models
{
    public class UsuarioAsignado : BaseEntity
    {
        public long UsuarioId { get; set; }
        public long SeguimientoId { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string Observaciones { get; set; }
    }

    public class UsuarioAsignadoConfiguration : IEntityTypeConfiguration<UsuarioAsignado>
    {
        public void Configure(EntityTypeBuilder<UsuarioAsignado> builder)
        {

        }
    }
}
