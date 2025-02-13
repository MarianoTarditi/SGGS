using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class sdaajfada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "85370f29-2f2d-47d2-9d31-a82160c09caf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "222966f2-dd4d-4274-b585-e149dee459c7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22bb8b92-7e7d-4297-b53b-ee179f0a5cc7", "AQAAAAIAAYagAAAAEFkQOl00e2SQed0DrCr5L4r5WElh8CSopRekylJqc2Xn7VtJ/hWnLpwzrP8eR6JNCw==", "d403cfa7-9ea6-4e3e-9277-a891b622f644" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d4177be-41bd-4c69-a82b-0539444f3bb1", "AQAAAAIAAYagAAAAEIFt8Zw3Txlg/mvN+t5SXCe5gCcwQ/AIX4RI9wLd7/y5176WMed8QJP6MKz6eVlqzg==", "8b744750-f25f-4e09-8b06-441d3ce93467" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(2195), new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(2196), new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(2197), new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(2197), new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(1402));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 22, 17, 8, 0, DateTimeKind.Local).AddTicks(1738));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "a938a7f6-f71f-4e12-9fc0-0be1d1d23b0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "0c0c053c-b505-41e3-b29a-22040cea90bf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ae417b1-1081-4ebd-9455-957441a68d2a", "AQAAAAIAAYagAAAAEARS/dfSKixnBtSCyWr+HARMIdOljLcQyM3J12zn0LnnMi5ZjV2EJGho7xazdAt3og==", "fcb00a74-c452-4da2-8c61-a014c95954d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd7a607-a227-4063-af70-14eb6f020f6f", "AQAAAAIAAYagAAAAECr08kSkJ45YtJ9biaCYHmxCLVxD1/NoVe5lkIpC2US2HoWk1+CHgJYemna31XKMwg==", "620d7ecc-04ea-4cb2-b2e1-d21c47f276fd" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8398), new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7982));
        }
    }
}
