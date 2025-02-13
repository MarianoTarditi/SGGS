using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class sdaajjfada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "42ad58a7-49f1-4b6e-afd5-0d74676ceacc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "3e1572d0-b1c5-4298-a6b9-c0d998727ca7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60ee4b1b-d1ea-4587-9a9f-062304973ff1", "AQAAAAIAAYagAAAAEMdxMFVajTtSQtaSs31AESyrMSeRER6TFUDIQjai2k1/Vfm7VzdK7hCdK/ouDGc5lA==", "e94e5379-f6e6-4447-b858-aaccec5fa7fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fae2b439-ef86-4d7a-b81a-f15d1a144fca", "AQAAAAIAAYagAAAAENj2M98V/ptWwFz2SinOY/7AHgDf3uHPPGUpkR+ZD4cquPM89/I9+yz05iLzTUjRxw==", "f60d508e-aff6-4e27-afc5-675ef5b13b58" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(1084), new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(1086), new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(1086), new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 22, 20, 57, 904, DateTimeKind.Local).AddTicks(623));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
