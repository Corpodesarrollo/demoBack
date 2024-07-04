using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Authentication.Domain.Common;

namespace Secani.Data.Models
{
    public class ContactoEntidad : BaseEntity
    {
        public long EntidadId { get; set; }
        public string Nombres { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Telefonos { get; set; }
    }

    public class ContactoEntidadConfiguration : IEntityTypeConfiguration<ContactoEntidad>
    {
        public void Configure(EntityTypeBuilder<ContactoEntidad> builder)
        {

        }
    }
}
