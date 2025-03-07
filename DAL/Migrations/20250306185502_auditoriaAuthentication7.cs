using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class auditoriaAuthentication7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "SessionDuration",
                table: "AuditLogsAuthorizations",
                type: "time",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SessionDuration",
                table: "AuditLogsAuthorizations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "59456a29-d930-4a31-84f1-f35de1fff0f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "f41f1286-d6c9-4db3-aef8-ca025870caac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "680afcd0-6941-40b5-9016-aaefe57e17a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7371565d-d33a-446b-ba5c-803b385a9895", "AQAAAAIAAYagAAAAELc4Z6kQi5+L2NpwWrvE7h5e3FG3/cNcXI8XhbQ+073WX+ucTgLEKtCykhP9MSCyNw==", "14945a8e-116f-4195-8920-c28d62780828" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52ab1e9e-9aa3-42ac-8523-8361799a160a", "AQAAAAIAAYagAAAAEHSeE92lbyHeECTl75VRgu03EKpAdFyO7xFsM2dyLZ+h/sd8NMgXSVjhOzu9XUE94A==", "e02183a7-fb3c-4e47-90a8-9c0063807261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11e1c76a-ea35-4b84-8061-c6023d0ece82", "AQAAAAIAAYagAAAAEBnWBWTgkyeemUVrwcmazrTIASxU2ggACrkHiwnDirvIpe3lCpgsdvsJ8CscVtDWbQ==", "8da7330c-593d-489c-a0fd-2a8869f7c81e" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2054), new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2462));
        }
    }
}
