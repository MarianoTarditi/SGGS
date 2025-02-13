using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class sdaajjfadaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Pagos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Organismos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Eventos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "5f316902-1737-4698-8136-a2d60e0eb72c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "8286ebc1-e78f-4bcb-bc9b-54a47c00de91");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d782067-a169-4463-b2af-a1a57892ef7f", "AQAAAAIAAYagAAAAEOtfJpXin7WiVCFEcTgbqfE92G6vMFGWkwtWrfRsZeOejJaKtlEaNr7NIz4tPdFaDg==", "238e61b5-5ddd-4b8b-a7f3-f79fe7fb28f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d910dada-848e-4a74-9351-426155bc58cb", "AQAAAAIAAYagAAAAECwrxYC6qkupJ67DDAafW4aurq2pKb9aSiHrkUvCOfsS4xxNQD6YSsgbFsk1EhzZqg==", "f90ab6be-3e58-4250-b361-be4b3a7dc44f" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Activo", "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { true, new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9809), new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9811), new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9813), new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Activo", "FechaCreacion" },
                values: new object[] { true, new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Activo",
                value: true);

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9361));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Eventos");

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
    }
}
