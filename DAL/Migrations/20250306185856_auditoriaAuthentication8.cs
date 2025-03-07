using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class auditoriaAuthentication8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "611c315a-eb10-4b11-a37d-e3f7c17d7513");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "8f44e13c-31d3-4b71-9429-3682087797ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "2695573c-731b-4511-ac1d-e2e818cde83f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0640b2b1-4489-47f6-bebc-487229de0338", "AQAAAAIAAYagAAAAEBcawnOhLXxYIeJiBRXGc6fB0hOV1/BCTgsh/FjBo/800x3v2LhwNJTK1AqGYybqEA==", "25cf6a20-9394-4d3e-8545-a48ea112d0b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce795105-9508-4b82-be7f-8ea457e8a4bc", "AQAAAAIAAYagAAAAEHwWv2NbCNHEofuSXlsv1u9CjdRdwnVsiT2s6ZfTKNsbN0M8wBmrdASJSbpRxj3d+A==", "a5d0c50d-3262-48c0-9dab-18b8c76726e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d245b1bd-5e39-434a-b08c-a1eb4959b4c2", "AQAAAAIAAYagAAAAEO2FOluTyiypUm2Vj+oJXP2alOf/5hXCmARlWXPlHMx6JhXP0/DSZhXtYUrN6ISVNQ==", "3508fdd1-86a0-47e4-8cbc-94dd2a965d16" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1203), new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1587));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "cd6c3235-6150-4cec-8dfe-83d89b5aba4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "789255ef-e8cd-46d6-a654-923735e377e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "77caff61-46f5-4345-8b2d-cb10a83e6a92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "327a3039-9a86-4798-bf07-cfc1f1f0b103", "AQAAAAIAAYagAAAAEOTcxq33m2FUTOFO0QeKvPwSUnHhjGdqtA4ohIJXTvEfgk2dxqhZVzOAnhDezOByhA==", "09d376db-176e-419f-8595-27cb6bac0802" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "837135b0-89ba-4c39-a971-f5396dccebc5", "AQAAAAIAAYagAAAAELFGstnKE7w/f+Kpb5QuIZRYU+LOO32+4H0DDmLGMUSlElFlB/HStr65FY3hYGz+CQ==", "e31ea568-6007-434b-949e-5a7459679d3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7b9dff3-1ba4-4948-b524-9b81f55a2f62", "AQAAAAIAAYagAAAAEAN3EPxtn+XE9SOTBN53Y165b7VGiI0X6DrTdQZPAQ3c0hszx/H/gSf7LY+S8QW96Q==", "2e6d5442-067b-44f1-a656-5fcf059ef332" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 6, 15, 55, 1, 291, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 6, 15, 55, 1, 291, DateTimeKind.Local).AddTicks(2019), new DateTime(2025, 3, 6, 15, 55, 1, 291, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 6, 15, 55, 1, 291, DateTimeKind.Local).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 6, 15, 55, 1, 291, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 6, 15, 55, 1, 291, DateTimeKind.Local).AddTicks(2423));
        }
    }
}
