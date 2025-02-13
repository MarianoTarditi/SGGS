using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class naskkaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 17, 23, 12, 196, DateTimeKind.Local).AddTicks(6566));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "28b45fc0-1158-4a6d-986e-4ec1069b4635");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "bd38ac23-c149-4153-bedb-59f3f86d1472");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "063b661a-7149-4374-a42a-a4517a8389bd", "AQAAAAIAAYagAAAAEMQJtDqK4MBMu9ix7iOFU5Mr43B9gSCM/Lqm9W0bpc2Wd6yXh2B9Ifa/nrim8jQCCw==", "61519d6d-5456-405d-ad9d-368ed1dced78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "648ae05a-97d7-4810-ba97-1bbd3984676e", "AQAAAAIAAYagAAAAEAXed6jdaJ/y3wKcvbtAkkfbVfO/iGUAiDWr96SGg3O2c8+SEKG++J0HHLbz9IH+BQ==", "5fcf1d70-29f9-4701-aead-ee47ad042ba0" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 22, 16, 57, 29, 80, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(866), new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(867), new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(869), new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(871), new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(249));
        }
    }
}
