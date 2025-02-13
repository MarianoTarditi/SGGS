using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class asfdsakk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "9df49967-7255-42f5-aa78-4d1b8fc376c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "f61e5b97-70d0-4453-a19e-899ef3a5034f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c9af1e1-7ead-403b-8ec9-770c2e62b6f2", "AQAAAAIAAYagAAAAEE+6xr8HD/P0aL2aHFz+JMunTm/hBDbZxSJC2dlfLf/nLfQTQuykKJGcJc4h9X/j8w==", "5e168499-f982-40d6-bf96-e52780690a8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f53d9a7d-2603-4dff-aad8-0b086d13a45c", "AQAAAAIAAYagAAAAENaxovrTqfl+P0GXjF4y1fnUs3n09P8Yf6qE7WG9k65VDMWAM5bkOJqJvrQyDvRTLQ==", "4b5ef821-2455-46b2-a297-c9dcb697afc8" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(2770), new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(2773), new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(2775), new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(2775), new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 7, 2, 13, 49, 744, DateTimeKind.Local).AddTicks(1745));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "Fecha",
                value: new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(8127), new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(8128), new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(8130), new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(8130), new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 7, 2, 0, 40, 332, DateTimeKind.Local).AddTicks(7460));
        }
    }
}
