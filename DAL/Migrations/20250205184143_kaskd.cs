using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class kaskd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Saldo",
                table: "Resumen",
                newName: "SaldoTotal");

            migrationBuilder.AddColumn<decimal>(
                name: "SaldoAfiliacion",
                table: "Resumen",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SaldoSeguroAcompañante",
                table: "Resumen",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "a42173e6-8acc-479e-a383-a31c2677574b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "cdf3aad3-eace-44c4-abfa-deb666201611");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8cfcbcc-f763-4d72-8148-3c395c63fd37", "AQAAAAIAAYagAAAAECAeKXUo5wQY3EWisuXB5US1glgmBvTMeEIpHle/SITQu22DUZH9hU1CLJwZQnlxbg==", "eae45cd2-20ae-4e67-a141-39c0875eea1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3ebfafc-9f13-48d5-acd6-0f85064143b0", "AQAAAAIAAYagAAAAEITkbdmbNvXeEHuEdvHaG6/gMSeVCCTyhhj9KcFPihZ6duI2NAOCFPFIfZDCsfDODg==", "8c6ce03b-bd70-4929-b513-6bf499c93707" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(7228), new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(7229), new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(7230), new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(7231), new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Resumen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SaldoAfiliacion", "SaldoSeguroAcompañante" },
                values: new object[] { 100m, 100m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaldoAfiliacion",
                table: "Resumen");

            migrationBuilder.DropColumn(
                name: "SaldoSeguroAcompañante",
                table: "Resumen");

            migrationBuilder.RenameColumn(
                name: "SaldoTotal",
                table: "Resumen",
                newName: "Saldo");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "ec45930e-5bb5-43ea-99db-8cdc4552a37e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "bd0ef904-52a9-4432-84ca-07025daa0e0b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f4acfd4-6e20-46bf-b00b-4a357ab0368f", "AQAAAAIAAYagAAAAEOEI/1vpZNo7EwNB7mBzoilFJiZSdZlm6eU/ERMngCFJ9JyarI2HnltdBrnLo0XThw==", "06577d1d-cce7-49fe-acb2-c1ec90ab0106" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4ca8430-e88c-445b-adbc-cec6a5c5a387", "AQAAAAIAAYagAAAAEFIbRwKZ5CHtxtN5BSVDj/aK13ED/6RSZYlZO3R8fp+iq6OCP6RMlrhCYUu1fUy/6w==", "35e8dc0d-8edc-4be3-99a4-69bdf388d0fe" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(4264), new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(4265), new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(4267), new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(4268), new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3606));
        }
    }
}
