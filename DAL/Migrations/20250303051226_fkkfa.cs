using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class fkkfa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                columns: new[] { "ConcurrencyStamp", "Description" },
                values: new object[] { "beb713e1-e8db-4665-9ffe-043b528a9538", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                columns: new[] { "ConcurrencyStamp", "Description" },
                values: new object[] { "c13d289d-bacb-4304-9382-21650e2735b3", null });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                columns: new[] { "ConcurrencyStamp", "Description" },
                values: new object[] { "d2fa757c-e39c-4a78-b83a-66c8069da06c", null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetRoles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "6a34709f-72fe-4cf1-9111-df5c3b8f663d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "6e73e19e-7f02-4ae7-8dc9-716839db45ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "b51b41c9-6a16-41df-810c-d5cece7b19cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03b0386d-4c55-461f-a775-da1be5dde758", "AQAAAAIAAYagAAAAEJbeliwhFDyMXoTVnkp3khU0TOXd0TQHRFLPjg+yF7iB+LrpRMH/ku4WfIJieBmKoA==", "b0e3fc2e-999d-4c04-9c58-3549402e8127" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a2b5ff1-00ad-49bb-8d64-c77ec5cc8f8d", "AQAAAAIAAYagAAAAEK2mBbveroD44K7yGsl+4Iz8IOKSphhHg0FY7Fqkt+p2vv6/oiTsHk/Yw9Ow/mMUhA==", "c83b13d7-389d-485c-9dd7-faf0222ca785" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95d4e1f3-fd74-42e9-8f02-93ac1caa5d20", "AQAAAAIAAYagAAAAENT13jCT1RC4ScvhjWpt82GC4hyKOkVEwIjheAul9dvbbGeEVgHUi+ddtvmBxomEsA==", "095d8cb6-bf4e-403a-8cf3-340486781cc0" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(899), new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(1248));
        }
    }
}
