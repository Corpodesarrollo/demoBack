using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Authentication.Domain.Common;

namespace Secani.Data.Models
{
    public class Seguimiento : BaseEntity
    {
        public long NNAId { get; set; }
        public DateTime FechaSeguimiento { get; set; }
        public int EstadoId { get; set; }
        public long ContactoNNAId { get; set; }
        public string Telefono { get; set; }
        public long UsuarioId { get; set; }
        public long SolicitanteId { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public bool TieneDiagnosticos { get; set; }
        public string ObservacionesSolicitante { get; set; }
    }

    public class SeguimientoConfiguration : IEntityTypeConfiguration<Seguimiento>
    {
        public void Configure(EntityTypeBuilder<Seguimiento> builder)
        {

        }
    }
}
