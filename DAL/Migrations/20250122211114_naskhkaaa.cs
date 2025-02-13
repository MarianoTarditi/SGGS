using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class naskhkaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "AutorizacionesPagos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "AutorizacionesEventos");

            migrationBuilder.AddColumn<int>(
                name: "EstadoAutorizacionId",
                table: "AutorizacionesPagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstadoAutorizacionId",
                table: "AutorizacionesEventos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EstadoAutorizaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoAutorizaciones", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "001099d6-41c7-451d-aae3-71b39d1b2a8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "c70078ef-5cdb-4b16-a4a8-5eb274dc358a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8274cf4-e9e8-459c-9439-353a9e1ff5c5", "AQAAAAIAAYagAAAAEGQW3GAeWZ0TeKK5O7mnhPWGDTn9CTB6fmTKYYgC0kCGiEkN2iPFSmYwWFfOSdduKg==", "d5f65186-ad58-49a1-8dd9-4f5d3a29ce7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da0c909f-a4d9-4320-87a5-4cfea77c7184", "AQAAAAIAAYagAAAAEFwWju7FUJxxJTZTDr+5l4LbyvOjGYmvKxXvotY/A6b1kVii/5WDFOrVAZiKQbrNYg==", "1f735d88-70c1-44e9-a960-3cef01f3f3ac" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EstadoAutorizacionId", "Fecha" },
                values: new object[] { 1, new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "EstadoAutorizacionId", "Fecha" },
                values: new object[] { 1, new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.InsertData(
                table: "EstadoAutorizaciones",
                columns: new[] { "Id", "CreatedDate", "Estado", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "05/05/2025", "Autorizado", null },
                    { 2, "05/05/2025", "Pendiente", null }
                });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(9222), new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(9227), new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(9229), new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(9230), new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesPagos_EstadoAutorizacionId",
                table: "AutorizacionesPagos",
                column: "EstadoAutorizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesEventos_EstadoAutorizacionId",
                table: "AutorizacionesEventos",
                column: "EstadoAutorizacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacionesEventos_EstadoAutorizaciones_EstadoAutorizacionId",
                table: "AutorizacionesEventos",
                column: "EstadoAutorizacionId",
                principalTable: "EstadoAutorizaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacionesPagos_EstadoAutorizaciones_EstadoAutorizacionId",
                table: "AutorizacionesPagos",
                column: "EstadoAutorizacionId",
                principalTable: "EstadoAutorizaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacionesEventos_EstadoAutorizaciones_EstadoAutorizacionId",
                table: "AutorizacionesEventos");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacionesPagos_EstadoAutorizaciones_EstadoAutorizacionId",
                table: "AutorizacionesPagos");

            migrationBuilder.DropTable(
                name: "EstadoAutorizaciones");

            migrationBuilder.DropIndex(
                name: "IX_AutorizacionesPagos_EstadoAutorizacionId",
                table: "AutorizacionesPagos");

            migrationBuilder.DropIndex(
                name: "IX_AutorizacionesEventos_EstadoAutorizacionId",
                table: "AutorizacionesEventos");

            migrationBuilder.DropColumn(
                name: "EstadoAutorizacionId",
                table: "AutorizacionesPagos");

            migrationBuilder.DropColumn(
                name: "EstadoAutorizacionId",
                table: "AutorizacionesEventos");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "AutorizacionesPagos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "AutorizacionesEventos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "9aec871e-979a-4f1b-9a9f-97464bb898fe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "d1a3d8de-214a-47aa-aa97-057c57c51ae3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4559e42-a09f-42a2-9742-a002e73cd7e2", "AQAAAAIAAYagAAAAEMM6cGaCxt2pWIJuGHIVff9G59hHsKzcozvN8+NEbat9bEmHrbxmAFNkz24ogZ9+jA==", "a0d1da4d-a03a-47b3-950f-f52c5e9bb22d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "416b242c-abe2-4e3a-94fa-c0c215a2a0d5", "AQAAAAIAAYagAAAAEDhehFW+utniqtoCOlntOLMCD//Dh2rEWKoaXU0cNpc3ScyS6pI6zo+ZzztdetKznw==", "af1e56f9-14f8-43ec-9fc2-3c96619334ee" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Estado", "Fecha" },
                values: new object[] { "Aprobado", new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "Estado", "Fecha" },
                values: new object[] { "Aprobado", new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(6013), new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(6014), new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(6014), new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(6015), new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(6016) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(5469));
        }
    }
}
