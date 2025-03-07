using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AuditLogsTable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AuditsLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "a14701fd-f9b7-47e8-9117-d222e14af1e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "07c15e87-341d-4ad7-834f-31eed7691fe7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "b358681e-a839-463e-8a08-5f091ce336f9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dd4c267-f357-4ec2-bd95-d4457bf4316b", "AQAAAAIAAYagAAAAEICWCvAf8Pug9PLiKBEJZsBHWrXl5XQL5M0/tVyowZ4DYdfYsLTS93UaFp5NbFMEjg==", "39010e52-78c2-410a-bd28-71a563f45efb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40c6b775-82d3-4ea5-bc9c-ddcaecd4057b", "AQAAAAIAAYagAAAAEKydGRTwQjZse7ubC1PY59jAgcAngC8mX40h2YssyEhLe4zSKgj3hDkitJyoJjqbXw==", "a117954d-2be4-40f1-a171-46e537c5a589" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7fb93b8-7542-4405-bade-757221cdc930", "AQAAAAIAAYagAAAAEMHGBFkLp+eSp5J8ADd20RVRcMvjUhYylgg7ZBA33sO8ZjAtP0PpwY47VXIHl1lyoA==", "f7d203f7-18cd-46be-8252-edb19ac707a9" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(1842), new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(2092));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AuditsLogs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "2912ed0d-8685-4b3d-a61a-7bc9593afef5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "0550b8b0-c278-4d18-9257-702be23f6d43");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "d437a563-af24-4bc6-ace0-7ef2f0dc58ac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97ce5ce1-f18d-4cbd-b962-238e84d684d7", "AQAAAAIAAYagAAAAENpVJ2K0Bj8nr5NBDxms1ud8itsylnRJ3XqAe0eaC3XVsWOolDwthq68/U4FCM7BIg==", "5de5b213-f945-452b-960c-12bd7d16d9ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2453699-a38d-4d55-919e-164427736a2d", "AQAAAAIAAYagAAAAEEA2FWQSTb86kt7FOSXzaHUetxY7hjyeEIwvYdLMtAIGFdpHdyELatGVYNoeEcihlA==", "082fadea-885c-4731-82bb-a7ab86759bc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32da5c25-e5f0-4608-9a18-9b8b9ef93386", "AQAAAAIAAYagAAAAEFFy1Ic87BR8rQvh6Mfb59QhPIxR+adeeaENxsuJtKE9jqOqnluY5RwyaB/WOO61Tg==", "e114b4ed-52da-4ec6-bb11-01ac9cddf000" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 13, 19, 59, 83, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 4, 13, 19, 59, 83, DateTimeKind.Local).AddTicks(2669), new DateTime(2025, 3, 4, 13, 19, 59, 83, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 4, 13, 19, 59, 83, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 4, 13, 19, 59, 83, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 4, 13, 19, 59, 83, DateTimeKind.Local).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 13, 19, 59, 83, DateTimeKind.Local).AddTicks(2949));
        }
    }
}
