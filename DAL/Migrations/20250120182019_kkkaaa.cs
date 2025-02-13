using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class kkkaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AsociacionId",
                table: "Deudas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "a034b5fc-5c85-412b-a701-5abae635e834");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "eac3d198-cfb6-48e2-aae5-c2b53a4b0d72");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f54d4ea7-0ff1-4cb2-b683-46c6a5e8c3c3", "AQAAAAIAAYagAAAAEA+TSTdmoOqPjwWTWCpegV/vHpGmohltvC4Fp+cGqveIgjp/ppN9Ihu223NYrSu6PA==", "0fec9662-2d68-4de7-af8b-4de4be6f21e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c7f45c0-c8fe-4967-ba24-2ba117cd6d3f", "AQAAAAIAAYagAAAAEBuHAuKogH2wYIzSuu5NsU0x3VHw/KbNp6YSsuPIB1+bKhSOnGHiEyNpj/m5y/bFLg==", "4b55bf3e-e154-4a24-8e77-8f1ab7d4e0cb" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AsociacionId", "FechaVencimiento" },
                values: new object[] { 0, new DateTime(2025, 1, 20, 15, 20, 18, 549, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(391), new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(392), new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(394), new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(394), new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 20, 15, 20, 18, 549, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 20, 15, 20, 18, 549, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 20, 15, 20, 18, 549, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 20, 15, 20, 18, 549, DateTimeKind.Local).AddTicks(9780));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AsociacionId",
                table: "Deudas");

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
    }
}
