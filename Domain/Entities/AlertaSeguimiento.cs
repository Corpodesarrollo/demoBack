using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Authentication.Domain.Common;

namespace Secani.Data.Models
{
    public class AlertaSeguimiento : BaseEntity
    {
        public long AlertaId { get; set; }
        public long SeguimientoId { get; set; }
        public string Observaciones { get; set; }
        public int EstadoId { get; set; }
        public DateTime UltimaFechaSeguimiento { get; set; }
    }

    public class AlertaSeguimientoConfiguration : IEntityTypeConfiguration<AlertaSeguimiento>
    {
        public void Configure(EntityTypeBuilder<AlertaSeguimiento> builder)
        {
            builder.Property(a => a.AlertaId).IsRequired();
            builder.Property(a => a.SeguimientoId).IsRequired();
            builder.Property(a => a.Observaciones).HasMaxLength(255);
            builder.Property(a => a.EstadoId).IsRequired();
            builder.Property(a => a.UltimaFechaSeguimiento).IsRequired();
        }
    }
}
