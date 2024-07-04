﻿// <auto-generated />
using System;
using Authentication.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Authentication.Infra.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Authentication.Infra.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("EstadoUsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Secani.Data.Models.Alerta", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SubcategoriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Alertas");
                });

            modelBuilder.Entity("Secani.Data.Models.AlertaSeguimiento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AlertaId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SeguimientoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UltimaFechaSeguimiento")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AlertaSeguimientos");
                });

            modelBuilder.Entity("Secani.Data.Models.Ausencia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiasAusencia")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAusencia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotivoAusencia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Ausencias");
                });

            modelBuilder.Entity("Secani.Data.Models.ContactoEntidad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("EntidadId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactoEntidades");
                });

            modelBuilder.Entity("Secani.Data.Models.ContactoNNA", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("NNAId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentescoId")
                        .HasColumnType("int");

                    b.Property<string>("TelefnosInactivos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ContactoNNAs");
                });

            modelBuilder.Entity("Secani.Data.Models.Entidad", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoEntidadId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Entidades");
                });

            modelBuilder.Entity("Secani.Data.Models.Intento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ContactoNNAId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaIntento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoFallaIntentoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoResultadoIntentoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Intentos");
                });

            modelBuilder.Entity("Secani.Data.Models.NNA", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("CantidadRecaidas")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaAlertaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CuidadorEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CuidadorNombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CuidadorParentescoId")
                        .HasColumnType("int");

                    b.Property<string>("CuidadorTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartamentoTratamientoId")
                        .HasColumnType("int");

                    b.Property<string>("DiagnosticoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DifAsignaciondeCitas")
                        .HasColumnType("bit");

                    b.Property<bool>("DifAutorizacionProcedimientos")
                        .HasColumnType("bit");

                    b.Property<bool>("DifAutorizaciondeMedicamentos")
                        .HasColumnType("bit");

                    b.Property<bool>("DifEntregaMedicamentosLAP")
                        .HasColumnType("bit");

                    b.Property<bool>("DifEntregaMedicamentosNoLAP")
                        .HasColumnType("bit");

                    b.Property<bool>("DifFallaConvenioEAPBeIPSTratante")
                        .HasColumnType("bit");

                    b.Property<bool>("DifFallasenMIPRES")
                        .HasColumnType("bit");

                    b.Property<bool>("DifHanCobradoCuotasoCopagos")
                        .HasColumnType("bit");

                    b.Property<bool>("DifMalaAtencionIPS")
                        .HasColumnType("bit");

                    b.Property<int>("DifMalaAtencionNombreIPSId")
                        .HasColumnType("int");

                    b.Property<bool>("DifRemisionInstitucionesEspecializadas")
                        .HasColumnType("bit");

                    b.Property<int>("EAPBId")
                        .HasColumnType("int");

                    b.Property<int>("EPSId")
                        .HasColumnType("int");

                    b.Property<int>("EstadoIngresoEstrategiaId")
                        .HasColumnType("int");

                    b.Property<int>("EtniaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaConsultaDiagnostico")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaConsultaOrigenReporte")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDefuncion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaDiagnostico")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaHospitalizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaIngresoEstrategia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicioSintomas")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicioTratamiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaNotificacionSIVIGILA")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUltimaRecaida")
                        .HasColumnType("datetime2");

                    b.Property<int>("GrupoPoblacionId")
                        .HasColumnType("int");

                    b.Property<int>("IPSId")
                        .HasColumnType("int");

                    b.Property<bool>("IPSIdTratamiento")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MotivoDefuncion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotivoNoDiagnosticoId")
                        .HasColumnType("int");

                    b.Property<string>("MotivoNoDiagnosticoOtro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MunicipioNacimientoId")
                        .HasColumnType("int");

                    b.Property<string>("NumeroIdentificacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrigenReporteId")
                        .HasColumnType("int");

                    b.Property<string>("PrimerApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PropietarioResidenciaActual")
                        .HasColumnType("bit");

                    b.Property<string>("PropietarioResidenciaActualOtro")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Recaida")
                        .HasColumnType("bit");

                    b.Property<int>("ResidenciaActualAreaId")
                        .HasColumnType("int");

                    b.Property<string>("ResidenciaActualBarrio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResidenciaActualCategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("ResidenciaActualDireccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResidenciaActualEstratoId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResidenciaActualMunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("ResidenciaActualTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResidenciaOrigenAreaId")
                        .HasColumnType("int");

                    b.Property<string>("ResidenciaOrigenBarrio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResidenciaOrigenCategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("ResidenciaOrigenDireccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ResidenciaOrigenEstratoId")
                        .HasColumnType("int");

                    b.Property<int>("ResidenciaOrigenMunicipioId")
                        .HasColumnType("int");

                    b.Property<string>("ResidenciaOrigenTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeguimientoLoDesea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeguimientoMotivoNoLoDesea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SexoId")
                        .HasColumnType("int");

                    b.Property<int>("SubcategoriaAlertaId")
                        .HasColumnType("int");

                    b.Property<int>("TipoCancerId")
                        .HasColumnType("int");

                    b.Property<int>("TipoDiagnosticoId")
                        .HasColumnType("int");

                    b.Property<int>("TipoIdentificacionId")
                        .HasColumnType("int");

                    b.Property<int>("TipoRegimenSSId")
                        .HasColumnType("int");

                    b.Property<bool>("TrasladoEAPBSuministroApoyo")
                        .HasColumnType("bit");

                    b.Property<bool>("TrasladoTieneCapacidadEconomica")
                        .HasColumnType("bit");

                    b.Property<bool>("TrasladosApoyoRecibidoxFundacion")
                        .HasColumnType("bit");

                    b.Property<bool>("TrasladosHaRecurridoAccionLegal")
                        .HasColumnType("bit");

                    b.Property<bool>("TrasladosHaSidoTrasladadodeInstitucion")
                        .HasColumnType("bit");

                    b.Property<bool>("TrasladosHaSolicitadoApoyoFundacion")
                        .HasColumnType("bit");

                    b.Property<int>("TrasladosIPSId")
                        .HasColumnType("int");

                    b.Property<bool>("TrasladosNombreFundacion")
                        .HasColumnType("bit");

                    b.Property<int>("TrasladosNumerodeTraslados")
                        .HasColumnType("int");

                    b.Property<bool>("TrasladosServiciosdeApoyoCobertura")
                        .HasColumnType("bit");

                    b.Property<bool>("TrasladosServiciosdeApoyoOportunos")
                        .HasColumnType("bit");

                    b.Property<int>("TrasladosTipoAccionLegalId")
                        .HasColumnType("int");

                    b.Property<int>("TratamientoCausasInasistenciaId")
                        .HasColumnType("int");

                    b.Property<string>("TratamientoCausasInasistenciaOtra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TratamientoCuantoTiemposinAsistir")
                        .HasColumnType("int");

                    b.Property<bool>("TratamientoEstudiaActualmente")
                        .HasColumnType("bit");

                    b.Property<bool>("TratamientoHaDejadodeAsistir")
                        .HasColumnType("bit");

                    b.Property<bool>("TratamientoHaDejadodeAsistirColegio")
                        .HasColumnType("bit");

                    b.Property<bool>("TratamientoHaSidoInformadoClaramente")
                        .HasColumnType("bit");

                    b.Property<string>("TratamientoObservaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TratamientoTiempoInasistenciaColegio")
                        .HasColumnType("int");

                    b.Property<int>("TratamientoTiempoInasistenciaUnidadMedidaId")
                        .HasColumnType("int");

                    b.Property<int>("TratamientoUnidadMedidaIdTiempoId")
                        .HasColumnType("int");

                    b.Property<int>("estadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("NNAs");
                });

            modelBuilder.Entity("Secani.Data.Models.Notificacion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("AlertaSeguimientoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("EntidadId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("FechaNotificacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRespuesta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RespuestaEntidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notificacions");
                });

            modelBuilder.Entity("Secani.Data.Models.Permiso", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("CanAdd")
                        .HasColumnType("bit");

                    b.Property<bool>("CanDele")
                        .HasColumnType("bit");

                    b.Property<bool>("CanEdit")
                        .HasColumnType("bit");

                    b.Property<bool>("CanView")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuncionalidadId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModuloId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Permisos");
                });

            modelBuilder.Entity("Secani.Data.Models.Seguimiento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ContactoNNAId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EstadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaSeguimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSolicitud")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("NNAId")
                        .HasColumnType("bigint");

                    b.Property<string>("ObservacionesSolicitante")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SolicitanteId")
                        .HasColumnType("bigint");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TieneDiagnosticos")
                        .HasColumnType("bit");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Seguimientos");
                });

            modelBuilder.Entity("Secani.Data.Models.UsuarioAsignado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaAsignacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("SeguimientoId")
                        .HasColumnType("bigint");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("UsuarioAsignados");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Authentication.Infra.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Authentication.Infra.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Authentication.Infra.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Authentication.Infra.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}