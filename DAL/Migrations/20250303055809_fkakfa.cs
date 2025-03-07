using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class fkakfa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "61da21ae-e6d1-4a92-824b-2e819b3c47f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "613d608f-93b8-44a6-a38e-f20190ffb21f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "cf9b78fa-8cff-41e2-afd4-df72096a2ad8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a18f513-c9de-4419-b6a7-fb1e2bbcd64f", "AQAAAAIAAYagAAAAEKoHMBRRlM+pqipedgg5S4CeUi1k5p6A+9gwoY8x28gVJaL4yR/ZuK3EYB90ZomSRw==", "bb2a3f16-0204-4dbb-92b1-43ede8ec3da5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df9c7876-1c94-49f1-b803-78a02d46fc71", "AQAAAAIAAYagAAAAEMqIAjVuoiPgR51ub/0GqG7S/BU+/su790Vfd6uZFHmR6tEwNEmslyCdgG71bPaY9g==", "c330c570-2fd3-43e2-85cd-96c7c7b1d37b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3972b946-b55d-4def-8cae-2270d591c21d", "AQAAAAIAAYagAAAAECwExavC6d3Pi/z5zQoXJ8PZuvLd9NmKrWp6cNqBb5GfRLCgdIHQLhJs8nSPfHZBnQ==", "08b251fd-21b4-440d-a254-9099735c7949" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8351), new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8718));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "beb713e1-e8db-4665-9ffe-043b528a9538");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "c13d289d-bacb-4304-9382-21650e2735b3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "d2fa757c-e39c-4a78-b83a-66c8069da06c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a270fee-cb39-4853-9691-78320262b5ea", "AQAAAAIAAYagAAAAEJ+Ni+qrs6emUrNPEfz6bEuzWh9ENX0BQML7aH220x9dYJgRGh2BpnUMzc5Kz8218A==", "4e8bd38b-3cae-4f72-b223-558cd3f266f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d72d068-0460-4c1c-b117-3fc2db32503f", "AQAAAAIAAYagAAAAEFeriQOhEsJs68ITYuxaVNxxUEZlmseyCQu0jRpVnONAXD3K9x0vWszZokKAqWxclQ==", "11083b4d-bf08-4969-a811-d8b11aed9b7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95b17e5d-9a8b-4311-a4e3-7df5f5000a28", "AQAAAAIAAYagAAAAEDa1dCG9Qy4I5rnjHn3YpLhGygJgcqjYQ+M6FD+YIfvSL8GuoEc/FJHjXvR2u3ShnA==", "521a21be-d774-4fd2-9bf1-7295cf1ede56" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 3, 2, 12, 25, 727, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 12, 25, 727, DateTimeKind.Local).AddTicks(1344), new DateTime(2025, 3, 3, 2, 12, 25, 727, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 3, 2, 12, 25, 727, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 3, 2, 12, 25, 727, DateTimeKind.Local).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 3, 2, 12, 25, 727, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 3, 3, 2, 12, 25, 727, DateTimeKind.Local).AddTicks(1697));
        }
    }
}
