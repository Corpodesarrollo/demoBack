using Authentication.Infra.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Secani.Data.Models;



namespace Authentication.Infra.Data
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<Alerta> Alertas { get; set; }
        public DbSet<AlertaSeguimiento> AlertaSeguimientos { get; set; }
        public DbSet<Ausencia> Ausencias { get; set; }
        public DbSet<ContactoEntidad> ContactoEntidades { get; set; }
        public DbSet<Entidad> Entidades { get; set; }
        public DbSet<Intento> Intentos { get; set; }
        public DbSet<ContactoNNA> ContactoNNAs { get; set; }
        public DbSet<NNA> NNAs { get; set; }
        public DbSet<Notificacion> Notificacions { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Seguimiento> Seguimientos { get; set; }
        public DbSet<UsuarioAsignado> UsuarioAsignados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }



    }

}
