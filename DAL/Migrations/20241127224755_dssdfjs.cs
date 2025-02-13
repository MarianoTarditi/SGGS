using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class dssdfjs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "e96a7b24-4bdd-4f39-95fc-5aa5f87bb153");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "92d6e313-2aa3-46ef-aab2-2ee800a9a6c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2171cbe-41d0-4424-ab18-2f0a93fc76d6", "AQAAAAIAAYagAAAAEHjTs+mCKKN485XfK3Gop6pdgWpIVx//k7FItsDaK2ykj9nYaMxQKg7cgj4zyP/kxA==", "28d37134-f1d5-47dd-9e81-45e182f92cee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d32e5924-63ca-4a32-82eb-3b64105f4ce0", "AQAAAAIAAYagAAAAEBZW5f3XjLB70sIjDeDzbe0xyc5IW9t9E35WFsZ4SCOqY6eO6pffPpUfh8jy6CVmPw==", "f24b6ae4-d2fc-4bed-a945-e6c20be9b58b" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5856), new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5858), new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5859), new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5860), new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5382));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "d4938581-0690-4859-b014-687682f1db18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "efb4488c-aa09-4e6f-975f-505d1641c635");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "440d6fe4-6238-4a53-8eeb-7ab9509976dc", "AQAAAAIAAYagAAAAEKwyyUeASIRe4SewToL/UZ6bnk550TNRm+8BD7V1XXQI8N0N1Nto7gMqfOpKcyWrEw==", "fc76a36e-1506-4428-957b-12e44de6e2ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7ed9384-6cf8-4483-8e55-1da2d805744e", "AQAAAAIAAYagAAAAEHH/OIaX38mijlbkpLJUge4sFhKT6L0V1uGK1XII2cSiaw7CiJa+V24ljZcSFRRPcg==", "8b3bce13-2a53-4d85-b9c4-f83b0de5b575" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 25, 22, 19, 22, 901, DateTimeKind.Local).AddTicks(108), new DateTime(2024, 11, 25, 22, 19, 22, 901, DateTimeKind.Local).AddTicks(109), new DateTime(2024, 11, 25, 22, 19, 22, 901, DateTimeKind.Local).AddTicks(111), new DateTime(2024, 11, 25, 22, 19, 22, 901, DateTimeKind.Local).AddTicks(111), new DateTime(2024, 11, 25, 22, 19, 22, 901, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9684));
        }
    }
}
