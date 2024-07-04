using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication.Infra.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alertas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubcategoriaId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alias = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alertas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlertaSeguimientos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlertaId = table.Column<long>(type: "bigint", nullable: false),
                    SeguimientoId = table.Column<long>(type: "bigint", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    UltimaFechaSeguimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlertaSeguimientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefonos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoUsuarioId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ausencias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    FechaAusencia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiasAusencia = table.Column<int>(type: "int", nullable: false),
                    MotivoAusencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ausencias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactoEntidades",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntidadId = table.Column<long>(type: "bigint", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefonos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactoEntidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactoNNAs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NNAId = table.Column<long>(type: "bigint", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentescoId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefonos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefnosInactivos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactoNNAs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entidades",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEntidadId = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Intentos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactoNNAId = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaIntento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoResultadoIntentoId = table.Column<int>(type: "int", nullable: false),
                    TipoFallaIntentoId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NNAs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estadoId = table.Column<int>(type: "int", nullable: false),
                    ResidenciaActualCategoriaId = table.Column<int>(type: "int", nullable: false),
                    ResidenciaActualMunicipioId = table.Column<int>(type: "int", nullable: false),
                    ResidenciaActualBarrio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidenciaActualAreaId = table.Column<int>(type: "int", nullable: false),
                    ResidenciaActualDireccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidenciaActualEstratoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidenciaActualTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidenciaOrigenCategoriaId = table.Column<int>(type: "int", nullable: false),
                    ResidenciaOrigenMunicipioId = table.Column<int>(type: "int", nullable: false),
                    ResidenciaOrigenBarrio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidenciaOrigenAreaId = table.Column<int>(type: "int", nullable: false),
                    ResidenciaOrigenDireccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidenciaOrigenEstratoId = table.Column<int>(type: "int", nullable: false),
                    ResidenciaOrigenTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNotificacionSIVIGILA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoIdentificacionId = table.Column<int>(type: "int", nullable: false),
                    NumeroIdentificacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MunicipioNacimientoId = table.Column<int>(type: "int", nullable: false),
                    SexoId = table.Column<int>(type: "int", nullable: false),
                    TipoRegimenSSId = table.Column<int>(type: "int", nullable: false),
                    EAPBId = table.Column<int>(type: "int", nullable: false),
                    EPSId = table.Column<int>(type: "int", nullable: false),
                    IPSId = table.Column<int>(type: "int", nullable: false),
                    GrupoPoblacionId = table.Column<int>(type: "int", nullable: false),
                    EtniaId = table.Column<int>(type: "int", nullable: false),
                    EstadoIngresoEstrategiaId = table.Column<int>(type: "int", nullable: false),
                    FechaIngresoEstrategia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrigenReporteId = table.Column<int>(type: "int", nullable: false),
                    FechaConsultaOrigenReporte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoCancerId = table.Column<int>(type: "int", nullable: false),
                    FechaInicioSintomas = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaHospitalizacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaDefuncion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotivoDefuncion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaInicioTratamiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Recaida = table.Column<bool>(type: "bit", nullable: false),
                    CantidadRecaidas = table.Column<int>(type: "int", nullable: false),
                    FechaUltimaRecaida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoDiagnosticoId = table.Column<int>(type: "int", nullable: false),
                    DiagnosticoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDiagnostico = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotivoNoDiagnosticoId = table.Column<int>(type: "int", nullable: false),
                    MotivoNoDiagnosticoOtro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaConsultaDiagnostico = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DepartamentoTratamientoId = table.Column<int>(type: "int", nullable: false),
                    IPSIdTratamiento = table.Column<bool>(type: "bit", nullable: false),
                    PropietarioResidenciaActual = table.Column<bool>(type: "bit", nullable: false),
                    PropietarioResidenciaActualOtro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrasladoTieneCapacidadEconomica = table.Column<bool>(type: "bit", nullable: false),
                    TrasladoEAPBSuministroApoyo = table.Column<bool>(type: "bit", nullable: false),
                    TrasladosServiciosdeApoyoOportunos = table.Column<bool>(type: "bit", nullable: false),
                    TrasladosServiciosdeApoyoCobertura = table.Column<bool>(type: "bit", nullable: false),
                    TrasladosHaSolicitadoApoyoFundacion = table.Column<bool>(type: "bit", nullable: false),
                    TrasladosNombreFundacion = table.Column<bool>(type: "bit", nullable: false),
                    TrasladosApoyoRecibidoxFundacion = table.Column<bool>(type: "bit", nullable: false),
                    DifAutorizaciondeMedicamentos = table.Column<bool>(type: "bit", nullable: false),
                    DifEntregaMedicamentosLAP = table.Column<bool>(type: "bit", nullable: false),
                    DifEntregaMedicamentosNoLAP = table.Column<bool>(type: "bit", nullable: false),
                    DifAsignaciondeCitas = table.Column<bool>(type: "bit", nullable: false),
                    DifHanCobradoCuotasoCopagos = table.Column<bool>(type: "bit", nullable: false),
                    DifAutorizacionProcedimientos = table.Column<bool>(type: "bit", nullable: false),
                    DifRemisionInstitucionesEspecializadas = table.Column<bool>(type: "bit", nullable: false),
                    DifMalaAtencionIPS = table.Column<bool>(type: "bit", nullable: false),
                    DifMalaAtencionNombreIPSId = table.Column<int>(type: "int", nullable: false),
                    DifFallasenMIPRES = table.Column<bool>(type: "bit", nullable: false),
                    DifFallaConvenioEAPBeIPSTratante = table.Column<bool>(type: "bit", nullable: false),
                    CategoriaAlertaId = table.Column<int>(type: "int", nullable: false),
                    SubcategoriaAlertaId = table.Column<int>(type: "int", nullable: false),
                    TrasladosHaSidoTrasladadodeInstitucion = table.Column<bool>(type: "bit", nullable: false),
                    TrasladosNumerodeTraslados = table.Column<int>(type: "int", nullable: false),
                    TrasladosIPSId = table.Column<int>(type: "int", nullable: false),
                    TrasladosHaRecurridoAccionLegal = table.Column<bool>(type: "bit", nullable: false),
                    TrasladosTipoAccionLegalId = table.Column<int>(type: "int", nullable: false),
                    TratamientoHaDejadodeAsistir = table.Column<bool>(type: "bit", nullable: false),
                    TratamientoCuantoTiemposinAsistir = table.Column<int>(type: "int", nullable: false),
                    TratamientoUnidadMedidaIdTiempoId = table.Column<int>(type: "int", nullable: false),
                    TratamientoCausasInasistenciaId = table.Column<int>(type: "int", nullable: false),
                    TratamientoCausasInasistenciaOtra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TratamientoEstudiaActualmente = table.Column<bool>(type: "bit", nullable: false),
                    TratamientoHaDejadodeAsistirColegio = table.Column<bool>(type: "bit", nullable: false),
                    TratamientoTiempoInasistenciaColegio = table.Column<int>(type: "int", nullable: false),
                    TratamientoTiempoInasistenciaUnidadMedidaId = table.Column<int>(type: "int", nullable: false),
                    TratamientoHaSidoInformadoClaramente = table.Column<bool>(type: "bit", nullable: false),
                    TratamientoObservaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuidadorNombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuidadorParentescoId = table.Column<int>(type: "int", nullable: false),
                    CuidadorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CuidadorTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeguimientoLoDesea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeguimientoMotivoNoLoDesea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NNAs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notificacions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlertaSeguimientoId = table.Column<long>(type: "bigint", nullable: false),
                    FechaNotificacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaRespuesta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RespuestaEntidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntidadId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificacions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuloId = table.Column<int>(type: "int", nullable: false),
                    FuncionalidadId = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CanView = table.Column<bool>(type: "bit", nullable: false),
                    CanEdit = table.Column<bool>(type: "bit", nullable: false),
                    CanDele = table.Column<bool>(type: "bit", nullable: false),
                    CanAdd = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seguimientos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NNAId = table.Column<long>(type: "bigint", nullable: false),
                    FechaSeguimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false),
                    ContactoNNAId = table.Column<long>(type: "bigint", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    SolicitanteId = table.Column<long>(type: "bigint", nullable: false),
                    FechaSolicitud = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TieneDiagnosticos = table.Column<bool>(type: "bit", nullable: false),
                    ObservacionesSolicitante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguimientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioAsignados",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<long>(type: "bigint", nullable: false),
                    SeguimientoId = table.Column<long>(type: "bigint", nullable: false),
                    FechaAsignacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioAsignados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alertas");

            migrationBuilder.DropTable(
                name: "AlertaSeguimientos");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Ausencias");

            migrationBuilder.DropTable(
                name: "ContactoEntidades");

            migrationBuilder.DropTable(
                name: "ContactoNNAs");

            migrationBuilder.DropTable(
                name: "Entidades");

            migrationBuilder.DropTable(
                name: "Intentos");

            migrationBuilder.DropTable(
                name: "NNAs");

            migrationBuilder.DropTable(
                name: "Notificacions");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.DropTable(
                name: "Seguimientos");

            migrationBuilder.DropTable(
                name: "UsuarioAsignados");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
