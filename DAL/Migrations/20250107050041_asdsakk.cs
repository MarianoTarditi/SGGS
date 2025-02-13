using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class asdsakk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacionesEventos_Usuarios_UsuarioId",
                table: "AutorizacionesEventos");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacionesPagos_Usuarios_UsuarioId",
                table: "AutorizacionesPagos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_AutorizacionesPagos_UsuarioId",
                table: "AutorizacionesPagos");

            migrationBuilder.DropIndex(
                name: "IX_AutorizacionesEventos_UsuarioId",
                table: "AutorizacionesEventos");

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Sexos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Sexos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Sexos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Resumen",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Resumen",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Resumen",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Religiones",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Religiones",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Religiones",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Recibos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Recibos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Recibos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Rama",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Rama",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Rama",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Provincias",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Provincias",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Provincias",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedDate",
                table: "Pagos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "Pagos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "PagoModalidad",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "PagoModalidad",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "PagoModalidad",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Organismos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Organismos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Organismos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Nacionalidades",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Nacionalidades",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Nacionalidades",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Miembros",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Miembros",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Miembros",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Localidades",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Localidades",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Localidades",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Idiomas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Idiomas",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Idiomas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Funciones",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Funciones",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Funciones",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Estudio",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Estudio",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Estudio",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "EstadoCivil",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "EstadoCivil",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "EstadoCivil",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Educadores",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Educadores",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Educadores",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Discapacidades",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Discapacidades",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Discapacidades",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Deudas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Deudas",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Deudas",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "DetallesPagos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "DetallesPagos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "DetallesPagos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Categorias",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Categorias",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Categorias",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "CategoriaPago",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "CategoriaPago",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "CategoriaPago",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "AutorizacionesPagos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "AutorizacionesPagos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "AutorizacionesPagos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Asociaciones",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Asociaciones",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Asociaciones",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Asociaciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "caa31017-369d-4c30-a65c-76d84123cce5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "cccaa4e2-4930-43de-94b6-45851b93883e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28307ee5-a177-47a1-93b9-383e9a7eac0f", "AQAAAAIAAYagAAAAECfnI1JuEFuoW0aUhSyL7iDkXPIjZ5Nj6vC4Panf29q00fJoI+e0g2ZODMfxoolG0g==", "496aac38-961e-49a8-a593-7da5ee697792" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "426f7161-f886-4e87-9aa3-6fd84f6a530f", "AQAAAAIAAYagAAAAELx+yL9QkqcWEjOaq+cr86H6yDgMV+RBFkT2oEoUHrRY5j6AXc9ljbTqZc0kX54DXw==", "b2c87c11-d075-40f3-aa91-f93c403aabf2" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "CreatedDate", "Fecha", "UpdatedDate" },
                values: new object[] { "05/05/2025", new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7842), null });

            migrationBuilder.UpdateData(
                table: "CategoriaPago",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "DetallesPagos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FechaVencimiento", "UpdatedDate" },
                values: new object[] { "05/05/2025", new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7223), null });

            migrationBuilder.UpdateData(
                table: "Discapacidades",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "EstadoCivil",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "EstadoCivil",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "EstadoCivil",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Estudio",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(8127), new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(8128), new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(8130), new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(8130), new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Funciones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Idiomas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Localidades",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FechaNacimiento", "UpdatedDate" },
                values: new object[] { "05/05/2025", new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7264), null });

            migrationBuilder.UpdateData(
                table: "Nacionalidades",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FechaCreacion", "UpdatedDate" },
                values: new object[] { "05/05/2025", new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7686), null });

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FechaDePago", "UpdatedDate" },
                values: new object[] { "05/05/2025", new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7608), null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Provincias",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Rama",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Fecha", "UpdatedDate" },
                values: new object[] { "05/05/2025", new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7460), null });

            migrationBuilder.UpdateData(
                table: "Religiones",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Resumen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Sexos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Sexos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Sexos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Sexos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Resumen");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Resumen");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Resumen");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Religiones");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Religiones");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Religiones");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Recibos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Recibos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Recibos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Rama");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Rama");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Rama");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PagoModalidad");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "PagoModalidad");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "PagoModalidad");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Nacionalidades");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Nacionalidades");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Nacionalidades");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Localidades");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Localidades");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Localidades");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Idiomas");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Idiomas");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Idiomas");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Funciones");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Funciones");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Funciones");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Estudio");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Estudio");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Estudio");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "EstadoCivil");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "EstadoCivil");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "EstadoCivil");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Educadores");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Educadores");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Educadores");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Discapacidades");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Discapacidades");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Discapacidades");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Deudas");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Deudas");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Deudas");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "DetallesPagos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "DetallesPagos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "DetallesPagos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "CategoriaPago");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "CategoriaPago");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "CategoriaPago");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AutorizacionesPagos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "AutorizacionesPagos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AutorizacionesPagos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Asociaciones");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Asociaciones");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Asociaciones");

            migrationBuilder.AlterColumn<string>(
                name: "UpdatedDate",
                table: "Pagos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedDate",
                table: "Pagos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

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
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioRolId = table.Column<int>(type: "int", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "e7bec80a-2437-4036-8054-7f7e14622e89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "231a740b-b2aa-4c05-976e-c8f2d1a9e23a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d3ae44b-943d-404f-b689-e39f63e6d39f", "AQAAAAIAAYagAAAAEESQp+hB4RPjZ/MaaDtcdBAqZiuIc+EqglpQoAAObasl7/K9m2WoP7uJyFKkKgF9qQ==", "752d3743-a159-45f5-800d-5c4d4a92905d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d797a193-6a1c-4126-b3cc-2a1c48edeff3", "AQAAAAIAAYagAAAAEP4LizlBxcn4uuIffe9KXl/JVTdJH7C9va1GkBYxqb+otKKEXioF8Oil7LlWXk+BkQ==", "335cbf56-430c-4610-88f3-46393a178577" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(8084), new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(8085), new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(8087), new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(8088), new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Descripcion", "EsActivo", "FechaRegistro" },
                values: new object[] { 1, "fdsfd", true, new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7527) });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Clave", "Email", "EsActivo", "Nombre", "Telefono", "UsuarioRolId" },
                values: new object[] { 1, "123", "fdsf", true, "Jorge", 45454, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesPagos_UsuarioId",
                table: "AutorizacionesPagos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesEventos_UsuarioId",
                table: "AutorizacionesEventos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UsuarioRolId",
                table: "Usuarios",
                column: "UsuarioRolId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacionesEventos_Usuarios_UsuarioId",
                table: "AutorizacionesEventos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacionesPagos_Usuarios_UsuarioId",
                table: "AutorizacionesPagos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
