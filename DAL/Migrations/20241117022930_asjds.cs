using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class asjds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asociaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorAfiliacion = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ValorSeguro = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    AsociacionNombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asociaciones", x => x.Id);
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
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "CategoriaPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoriaNombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaPago", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DestacamientosPoliciales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<double>(type: "float", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestacamientosPoliciales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discapacidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discapacidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsigniaMadera = table.Column<bool>(type: "bit", nullable: false),
                    FuncionEducador = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCivil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCivil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nivel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Funciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Idiomas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idiomas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nacionalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nacionalidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Propietarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Propietarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provincias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provincias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rama",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rama", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Religiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religiones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sexos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sexos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportesPrivados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroHabilitacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<double>(type: "float", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportesPrivados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadesSanitarias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<double>(type: "float", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesSanitarias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VechiculosPropios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VechiculosPropios", x => x.Id);
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
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(34)", maxLength: 34, nullable: false)
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
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(34)", maxLength: 34, nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Locaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropietarioId = table.Column<int>(type: "int", nullable: false),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locaciones_Propietarios_PropietarioId",
                        column: x => x.PropietarioId,
                        principalTable: "Propietarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Localidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinciaId = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localidades_Provincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "Provincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    UsuarioRolId = table.Column<int>(type: "int", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Roles_UsuarioRolId",
                        column: x => x.UsuarioRolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Organismos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoPostal = table.Column<int>(type: "int", nullable: false),
                    LocalidadId = table.Column<int>(type: "int", nullable: false),
                    AsociacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organismos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organismos_Asociaciones_AsociacionId",
                        column: x => x.AsociacionId,
                        principalTable: "Asociaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Organismos_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Miembros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CodigoPostal = table.Column<int>(type: "int", nullable: false),
                    Telefono = table.Column<double>(type: "float", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescripcionDiscapacidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocalidadId = table.Column<int>(type: "int", nullable: false),
                    DiscapacidadId = table.Column<int>(type: "int", nullable: false),
                    IdiomaId = table.Column<int>(type: "int", nullable: false),
                    SexoId = table.Column<int>(type: "int", nullable: false),
                    ReligionId = table.Column<int>(type: "int", nullable: false),
                    NacionalidadId = table.Column<int>(type: "int", nullable: false),
                    OrganismoId = table.Column<int>(type: "int", nullable: false),
                    EstadoCivilId = table.Column<int>(type: "int", nullable: false),
                    EstudioId = table.Column<int>(type: "int", nullable: false),
                    RamaId = table.Column<int>(type: "int", nullable: false),
                    FuncionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Miembros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Miembros_Discapacidades_DiscapacidadId",
                        column: x => x.DiscapacidadId,
                        principalTable: "Discapacidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Miembros_EstadoCivil_EstadoCivilId",
                        column: x => x.EstadoCivilId,
                        principalTable: "EstadoCivil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Miembros_Estudio_EstudioId",
                        column: x => x.EstudioId,
                        principalTable: "Estudio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Miembros_Funciones_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Miembros_Idiomas_IdiomaId",
                        column: x => x.IdiomaId,
                        principalTable: "Idiomas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Miembros_Localidades_LocalidadId",
                        column: x => x.LocalidadId,
                        principalTable: "Localidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Miembros_Nacionalidades_NacionalidadId",
                        column: x => x.NacionalidadId,
                        principalTable: "Nacionalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Miembros_Organismos_OrganismoId",
                        column: x => x.OrganismoId,
                        principalTable: "Organismos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Miembros_Rama_RamaId",
                        column: x => x.RamaId,
                        principalTable: "Rama",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Miembros_Religiones_ReligionId",
                        column: x => x.ReligionId,
                        principalTable: "Religiones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Miembros_Sexos_SexoId",
                        column: x => x.SexoId,
                        principalTable: "Sexos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resumen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Credito = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Debito = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Saldo = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    OrganismoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resumen_Organismos_OrganismoId",
                        column: x => x.OrganismoId,
                        principalTable: "Organismos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaLlegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraLlegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telefono = table.Column<double>(type: "float", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreDirecZona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<double>(type: "float", nullable: true),
                    LocacionId = table.Column<int>(type: "int", nullable: false),
                    VehiculoPropioId = table.Column<int>(type: "int", nullable: false),
                    TransportePrivdadoId = table.Column<int>(type: "int", nullable: false),
                    DestacamientoPolicialId = table.Column<int>(type: "int", nullable: false),
                    UnidadSanitariaId = table.Column<int>(type: "int", nullable: false),
                    JefeDeCampoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eventos_DestacamientosPoliciales_DestacamientoPolicialId",
                        column: x => x.DestacamientoPolicialId,
                        principalTable: "DestacamientosPoliciales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eventos_Locaciones_LocacionId",
                        column: x => x.LocacionId,
                        principalTable: "Locaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eventos_Miembros_JefeDeCampoId",
                        column: x => x.JefeDeCampoId,
                        principalTable: "Miembros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eventos_TransportesPrivados_TransportePrivdadoId",
                        column: x => x.TransportePrivdadoId,
                        principalTable: "TransportesPrivados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eventos_UnidadesSanitarias_UnidadSanitariaId",
                        column: x => x.UnidadSanitariaId,
                        principalTable: "UnidadesSanitarias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eventos_VechiculosPropios_VehiculoPropioId",
                        column: x => x.VehiculoPropioId,
                        principalTable: "VechiculosPropios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ResumenId = table.Column<int>(type: "int", nullable: false),
                    TipoModalidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pagos_Resumen_ResumenId",
                        column: x => x.ResumenId,
                        principalTable: "Resumen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorizacionesEventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Autorizado = table.Column<bool>(type: "bit", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    EventoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorizacionesEventos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutorizacionesEventos_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorizacionesEventos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventosMiembros",
                columns: table => new
                {
                    MiembroId = table.Column<int>(type: "int", nullable: false),
                    EventoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventosMiembros", x => new { x.MiembroId, x.EventoId });
                    table.ForeignKey(
                        name: "FK_EventosMiembros_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventosMiembros_Miembros_MiembroId",
                        column: x => x.MiembroId,
                        principalTable: "Miembros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorizacionesPagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Autorizado = table.Column<bool>(type: "bit", nullable: false),
                    PagoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorizacionesPagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutorizacionesPagos_Pagos_PagoId",
                        column: x => x.PagoId,
                        principalTable: "Pagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorizacionesPagos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetallesPagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Pagoid = table.Column<int>(type: "int", nullable: false),
                    CategoriaPagoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesPagos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesPagos_CategoriaPago_CategoriaPagoId",
                        column: x => x.CategoriaPagoId,
                        principalTable: "CategoriaPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetallesPagos_Pagos_Pagoid",
                        column: x => x.Pagoid,
                        principalTable: "Pagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagoModalidad",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaDePago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PagoId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    NumeroSucursal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroOperacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroCuenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NroCuentaOrigenFondo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BancoOrigen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transferencia_NumeroOperacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagoModalidad", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagoModalidad_Pagos_PagoId",
                        column: x => x.PagoId,
                        principalTable: "Pagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recibos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    PagoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recibos_Pagos_PagoId",
                        column: x => x.PagoId,
                        principalTable: "Pagos",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Asociaciones",
                columns: new[] { "Id", "AsociacionNombre", "ValorAfiliacion", "ValorSeguro" },
                values: new object[] { 1, "ScoutsArgentina", 1000m, 2000m });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9b67832b-7091-48e8-aa0a-f1b3baeca418", "401f6c20-1949-446e-b192-c8a1c75135d3", "SuperAdmin", "SUPERADMIN" },
                    { "affedc34-9713-423a-880e-4a61ceefb7b1", "3875c360-8ee1-44f3-aed4-16d779ce98d2", "Member", "MEMBER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FileName", "FileType", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "070a9212-d4a9-44da-8479-4ec813b63621", 0, "4a6431a7-e229-4813-827c-f0caf3006fae", "test.video.lesson@gmail.com", false, null, null, false, null, "TEST.VIDEO.LESSON@GMAIL.COM", "TESTADMIN", "AQAAAAIAAYagAAAAEIVmeARgWAfIqaJXJBL2iBe78lsj10ywMCCdy5i4WB61EkFfEVERe2or6E9HK4idbw==", null, false, "8cca75e5-3e45-44aa-927f-a883d9b91314", false, "TestAdmin" },
                    { "6b0e483c-ebae-4ed3-827e-8ed27f7d9131", 0, "455b9201-b9e9-4abe-88fa-aa7163f023d0", "test.video.lesson2@gmail.com", false, null, null, false, null, "TEST.VIDEO.LESSON2@GMAIL.COM", "TESTMEMBER", "AQAAAAIAAYagAAAAEEgBVEM3qs/tJu64PFywGA+g6QPzki6t/VqgKktWKkj3InrQKhl+4Yq9yOwXl21/+w==", null, false, "1f750c8d-4cf3-42d8-83be-671c40f3d549", false, "TestMember" }
                });

            migrationBuilder.InsertData(
                table: "CategoriaPago",
                columns: new[] { "Id", "CategoriaNombre" },
                values: new object[] { 1, "asd" });

            migrationBuilder.InsertData(
                table: "DestacamientosPoliciales",
                columns: new[] { "Id", "Direccion", "Nombre", "Telefono" },
                values: new object[] { 1, "Dardo rocha 78", "PoliciaRojas", 2445445.0 });

            migrationBuilder.InsertData(
                table: "Discapacidades",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Diselxia" });

            migrationBuilder.InsertData(
                table: "EstadoCivil",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Masculino" },
                    { 2, "Femenino" },
                    { 3, "X" }
                });

            migrationBuilder.InsertData(
                table: "Estudio",
                columns: new[] { "Id", "Nivel" },
                values: new object[] { 1, "asd" });

            migrationBuilder.InsertData(
                table: "Funciones",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Protagonista" });

            migrationBuilder.InsertData(
                table: "Idiomas",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Español" });

            migrationBuilder.InsertData(
                table: "Nacionalidades",
                columns: new[] { "Id", "Pais" },
                values: new object[] { 1, "Argentina" });

            migrationBuilder.InsertData(
                table: "Propietarios",
                columns: new[] { "Id", "Nombre", "Telefono" },
                values: new object[] { 1, "Ernesto", 2445445.0 });

            migrationBuilder.InsertData(
                table: "Provincias",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Buenos Aires" },
                    { 2, "Buenos Aires-GBA" },
                    { 3, "Catamarca" },
                    { 4, "Chaco" },
                    { 5, "Chubut" },
                    { 6, "Córdoba" },
                    { 7, "Corrientes" },
                    { 8, "Entre Ríos" },
                    { 9, "Formosa" },
                    { 10, "Jujuy" },
                    { 11, "La Pampa" },
                    { 12, "La Rioja" },
                    { 13, "Mendoza" },
                    { 14, "Misiones" },
                    { 15, "Neuquén" },
                    { 16, "Río Negro" },
                    { 17, "Salta" },
                    { 18, "San Juan" },
                    { 19, "San Luis" },
                    { 20, "Santa Cruz" },
                    { 21, "Santa Fe" },
                    { 22, "Santiago del Estero" },
                    { 23, "Tierra del Fuego" },
                    { 24, "Tucumán" }
                });

            migrationBuilder.InsertData(
                table: "Rama",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "sad" });

            migrationBuilder.InsertData(
                table: "Religiones",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Cristiano" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Descripcion", "EsActivo", "FechaRegistro" },
                values: new object[] { 1, "fdsfd", true, new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.InsertData(
                table: "Sexos",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { 1, "Masculino" });

            migrationBuilder.InsertData(
                table: "TransportesPrivados",
                columns: new[] { "Id", "Direccion", "NumeroHabilitacion", "RazonSocial", "Telefono" },
                values: new object[] { 1, "Dardo rocha 78", "542", "45", 2445445.0 });

            migrationBuilder.InsertData(
                table: "UnidadesSanitarias",
                columns: new[] { "Id", "Direccion", "Nombre", "Telefono" },
                values: new object[] { 1, "Dardo rocha 78", "HospitalRojas", 2445445.0 });

            migrationBuilder.InsertData(
                table: "VechiculosPropios",
                columns: new[] { "Id", "Marca", "Modelo", "Patente", "Tipo" },
                values: new object[] { 1, "Ford", "Fiesta", "IAA344", "GEF" });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "Discriminator", "UserId" },
                values: new object[] { 1, "AdminObserverExpireDate", "06/11/2023", "AppUserClaim", "6b0e483c-ebae-4ed3-827e-8ed27f7d9131" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[,]
                {
                    { "9b67832b-7091-48e8-aa0a-f1b3baeca418", "070a9212-d4a9-44da-8479-4ec813b63621", "AppUserRole" },
                    { "affedc34-9713-423a-880e-4a61ceefb7b1", "6b0e483c-ebae-4ed3-827e-8ed27f7d9131", "AppUserRole" }
                });

            migrationBuilder.InsertData(
                table: "Locaciones",
                columns: new[] { "Id", "Ciudad", "Direccion", "PropietarioId", "Provincia" },
                values: new object[] { 1, "Rojas", "Dardo rocha 78", 1, "Buenos Aires" });

            migrationBuilder.InsertData(
                table: "Localidades",
                columns: new[] { "Id", "Codigo", "Nombre", "ProvinciaId" },
                values: new object[] { 1, 1, "Rojas", 1 });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Clave", "Email", "EsActivo", "Nombre", "Telefono", "UsuarioRolId" },
                values: new object[] { 1, "123", "fdsf", true, "Jorge", 45454, 1 });

            migrationBuilder.InsertData(
                table: "Organismos",
                columns: new[] { "Id", "AsociacionId", "Codigo", "CodigoPostal", "Descripcion", "Direccion", "FechaCreacion", "LocalidadId", "Nombre" },
                values: new object[] { 1, 1, 1, 2705, "Grupo Scout de Entre Rios", "Dardo rocha 78", new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6410), 1, "San isidrio labrador" });

            migrationBuilder.InsertData(
                table: "Miembros",
                columns: new[] { "Id", "Activo", "Apellido", "CodigoPostal", "DescripcionDiscapacidad", "DiscapacidadId", "Dni", "Email", "EstadoCivilId", "EstudioId", "FechaNacimiento", "FuncionId", "IdiomaId", "LocalidadId", "NacionalidadId", "Nombre", "OrganismoId", "RamaId", "ReligionId", "SexoId", "Telefono", "Titulo" },
                values: new object[] { 1, true, "Martinez", 2705, null, 1, "45621359", "marianotarditi2004@gmail.com", 1, 1, new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(5838), 1, 1, 1, 1, "Lautaro", 1, 1, 1, 1, null, null });

            migrationBuilder.InsertData(
                table: "Resumen",
                columns: new[] { "Id", "Credito", "Debito", "OrganismoId", "Saldo" },
                values: new object[] { 1, 1000m, 500m, 1, 100m });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "Celular", "Codigo", "DestacamientoPolicialId", "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida", "JefeDeCampoId", "LocacionId", "NombreDirecZona", "Observacion", "Telefono", "TransportePrivdadoId", "UnidadSanitariaId", "VehiculoPropioId" },
                values: new object[] { 1, 2474403379.0, 1, 1, new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6945), new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6947), new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6948), new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6949), new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6949), 1, 1, "sad", null, 0.0, 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Pagos",
                columns: new[] { "Id", "Codigo", "ResumenId", "TipoModalidad", "Total" },
                values: new object[] { 1, 1, 1, "Efectivo", 10000m });

            migrationBuilder.InsertData(
                table: "AutorizacionesEventos",
                columns: new[] { "Id", "Autorizado", "EventoId", "Fecha", "UsuarioId" },
                values: new object[] { 1, false, 1, new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6584), 1 });

            migrationBuilder.InsertData(
                table: "AutorizacionesPagos",
                columns: new[] { "Id", "Autorizado", "Fecha", "PagoId", "UsuarioId" },
                values: new object[] { 1096, false, new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6612), 1, 1 });

            migrationBuilder.InsertData(
                table: "DetallesPagos",
                columns: new[] { "Id", "CategoriaPagoId", "Monto", "Pagoid" },
                values: new object[] { 1, 1, 1000m, 1 });

            migrationBuilder.InsertData(
                table: "EventosMiembros",
                columns: new[] { "EventoId", "MiembroId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "PagoModalidad",
                columns: new[] { "Id", "Discriminator", "FechaDePago", "NombreCompleto", "Observacion", "PagoId" },
                values: new object[] { 1, "ModalidadPago", new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6313), "Mariano Tarditi", "Pago hecho con transferencia", 1 });

            migrationBuilder.InsertData(
                table: "Recibos",
                columns: new[] { "Id", "Codigo", "Fecha", "PagoId", "Total" },
                values: new object[] { 1, 1012, new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6035), 1, 3000m });

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

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesEventos_EventoId",
                table: "AutorizacionesEventos",
                column: "EventoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesEventos_UsuarioId",
                table: "AutorizacionesEventos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesPagos_PagoId",
                table: "AutorizacionesPagos",
                column: "PagoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesPagos_UsuarioId",
                table: "AutorizacionesPagos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPagos_CategoriaPagoId",
                table: "DetallesPagos",
                column: "CategoriaPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPagos_Pagoid",
                table: "DetallesPagos",
                column: "Pagoid");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_DestacamientoPolicialId",
                table: "Eventos",
                column: "DestacamientoPolicialId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_JefeDeCampoId",
                table: "Eventos",
                column: "JefeDeCampoId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_LocacionId",
                table: "Eventos",
                column: "LocacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_TransportePrivdadoId",
                table: "Eventos",
                column: "TransportePrivdadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_UnidadSanitariaId",
                table: "Eventos",
                column: "UnidadSanitariaId");

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_VehiculoPropioId",
                table: "Eventos",
                column: "VehiculoPropioId");

            migrationBuilder.CreateIndex(
                name: "IX_EventosMiembros_EventoId",
                table: "EventosMiembros",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_Locaciones_PropietarioId",
                table: "Locaciones",
                column: "PropietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Localidades_ProvinciaId",
                table: "Localidades",
                column: "ProvinciaId");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_DiscapacidadId",
                table: "Miembros",
                column: "DiscapacidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_EstadoCivilId",
                table: "Miembros",
                column: "EstadoCivilId");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_EstudioId",
                table: "Miembros",
                column: "EstudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_FuncionId",
                table: "Miembros",
                column: "FuncionId");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_IdiomaId",
                table: "Miembros",
                column: "IdiomaId");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_LocalidadId",
                table: "Miembros",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_NacionalidadId",
                table: "Miembros",
                column: "NacionalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_OrganismoId",
                table: "Miembros",
                column: "OrganismoId");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_RamaId",
                table: "Miembros",
                column: "RamaId");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_ReligionId",
                table: "Miembros",
                column: "ReligionId");

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_SexoId",
                table: "Miembros",
                column: "SexoId");

            migrationBuilder.CreateIndex(
                name: "IX_Organismos_AsociacionId",
                table: "Organismos",
                column: "AsociacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Organismos_LocalidadId",
                table: "Organismos",
                column: "LocalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_PagoModalidad_PagoId",
                table: "PagoModalidad",
                column: "PagoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_ResumenId",
                table: "Pagos",
                column: "ResumenId");

            migrationBuilder.CreateIndex(
                name: "IX_Recibos_PagoId",
                table: "Recibos",
                column: "PagoId",
                unique: true,
                filter: "[PagoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Resumen_OrganismoId",
                table: "Resumen",
                column: "OrganismoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioRolId",
                table: "Usuarios",
                column: "UsuarioRolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "AutorizacionesEventos");

            migrationBuilder.DropTable(
                name: "AutorizacionesPagos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "DetallesPagos");

            migrationBuilder.DropTable(
                name: "Educadores");

            migrationBuilder.DropTable(
                name: "EventosMiembros");

            migrationBuilder.DropTable(
                name: "PagoModalidad");

            migrationBuilder.DropTable(
                name: "Recibos");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "CategoriaPago");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "DestacamientosPoliciales");

            migrationBuilder.DropTable(
                name: "Locaciones");

            migrationBuilder.DropTable(
                name: "Miembros");

            migrationBuilder.DropTable(
                name: "TransportesPrivados");

            migrationBuilder.DropTable(
                name: "UnidadesSanitarias");

            migrationBuilder.DropTable(
                name: "VechiculosPropios");

            migrationBuilder.DropTable(
                name: "Resumen");

            migrationBuilder.DropTable(
                name: "Propietarios");

            migrationBuilder.DropTable(
                name: "Discapacidades");

            migrationBuilder.DropTable(
                name: "EstadoCivil");

            migrationBuilder.DropTable(
                name: "Estudio");

            migrationBuilder.DropTable(
                name: "Funciones");

            migrationBuilder.DropTable(
                name: "Idiomas");

            migrationBuilder.DropTable(
                name: "Nacionalidades");

            migrationBuilder.DropTable(
                name: "Rama");

            migrationBuilder.DropTable(
                name: "Religiones");

            migrationBuilder.DropTable(
                name: "Sexos");

            migrationBuilder.DropTable(
                name: "Organismos");

            migrationBuilder.DropTable(
                name: "Asociaciones");

            migrationBuilder.DropTable(
                name: "Localidades");

            migrationBuilder.DropTable(
                name: "Provincias");
        }
    }
}
