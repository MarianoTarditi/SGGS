using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class naskhkaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "AutorizacionPagoId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.InsertData(
                table: "AutorizacionesPagos",
                columns: new[] { "Id", "Autorizado", "CreatedDate", "Estado", "Fecha", "Observacion", "UpdatedDate" },
                values: new object[] { 1122, true, "05/05/2025", "Aprobado", new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(5300), "Pago Autorizado con exito", null });

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
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 1,
                column: "AutorizacionPagoId",
                value: 1122);

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 17, 45, 44, 236, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_AutorizacionPagoId",
                table: "Pagos",
                column: "AutorizacionPagoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_AutorizacionesPagos_AutorizacionPagoId",
                table: "Pagos",
                column: "AutorizacionPagoId",
                principalTable: "AutorizacionesPagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_AutorizacionesPagos_AutorizacionPagoId",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_AutorizacionPagoId",
                table: "Pagos");

            migrationBuilder.DeleteData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DropColumn(
                name: "AutorizacionPagoId",
                table: "Pagos");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "fa9e17a9-99fb-4d63-b242-4e7070bbaf6f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "14cdc999-a0cd-4d8a-ac96-31adff8bcf72");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09234828-ff55-4a0d-a79c-9453eec2a917", "AQAAAAIAAYagAAAAEEMV4OJCjNlX75m6h19Hn6CtIkjJzN+pBQAgzr5ZRA0q2nNa7o37nJnXpUl3p74HkQ==", "309dc18f-c900-439d-92d8-24a2185ec633" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30a8301f-4f3d-4161-a694-e5ba7c5c12d3", "AQAAAAIAAYagAAAAEJwr4PwS1ZxMQuMNrb2qV06osucKKu2O8Qa7YcqwgPhNe1awEYvUr71q56NAFBsj7w==", "acd77c39-4397-4219-8467-8b917dc398ae" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.InsertData(
                table: "AutorizacionesPagos",
                columns: new[] { "Id", "Autorizado", "CreatedDate", "Estado", "Fecha", "Observacion", "UpdatedDate" },
                values: new object[] { 1, true, "05/05/2025", "Aprobado", new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(6566), "Pago Autorizado con exito", null });

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(7385), new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(7385), new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(7386), new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(7388), new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(7388) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(6809));
        }
    }
}
