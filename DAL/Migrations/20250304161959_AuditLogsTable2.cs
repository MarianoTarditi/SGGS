using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AuditLogsTable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "95d0673e-2970-4617-bdba-5a1a90847756");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "29ff365e-7504-4b71-aec3-332d4edc6c5f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "1e80983b-eab7-40e9-9128-8177b9e26889");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "913c8a3d-ce7f-4071-b5e0-48b01bc13c5f", "AQAAAAIAAYagAAAAECMHCYcgaojMiBZVQNLlc3gvf/Sln0WJEnTkBt6PLpRbeHSYBg1JYiiLcqM0wc8FCQ==", "47721512-989c-4da3-987d-dff425fde4c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77bcf868-350a-41e1-95d9-7d32f35f2a46", "AQAAAAIAAYagAAAAEN9qTdB5fWlCYk6XFFfXFVTSkK6YzOG/J1TwSxbwK09snQSkr5Sgs2stFWEnagYPRA==", "d1323ae7-106d-45ef-b8bd-e74aa74cbb18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6099364b-973d-4596-af19-75fdaeece505", "AQAAAAIAAYagAAAAEKXAdYp9M+ERm1GDvaS3mCcIxq8lc5Ajz4MpZ1cmfmqMc+g0Z36qlWep1dfN7LCa4Q==", "4e00cfc6-d970-49c8-81fd-5b02bd22ed1d" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 12, 42, 34, 354, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 4, 12, 42, 34, 354, DateTimeKind.Local).AddTicks(6963), new DateTime(2025, 3, 4, 12, 42, 34, 354, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 4, 12, 42, 34, 354, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 4, 12, 42, 34, 354, DateTimeKind.Local).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 4, 12, 42, 34, 354, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 12, 42, 34, 354, DateTimeKind.Local).AddTicks(7269));
        }
    }
}
