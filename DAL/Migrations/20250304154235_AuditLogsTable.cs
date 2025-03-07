using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AuditLogsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditsLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Changes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditsLogs", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditsLogs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "d401bce4-cb77-4836-b33f-ec899ef3fa8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "da0d2f1d-9d38-4401-bea2-d2be1e5da8c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "455edbf5-57f0-49ce-98df-a8a23f68b56a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf98708d-5e51-41ec-8f60-e8d613fb3f9c", "AQAAAAIAAYagAAAAEDv6VXlMO1sJTtVL8cb7K19H+56/GxxsRej6t3bhT1yyYMSmtCE8MWKFnbgeyy2alg==", "ec411a6d-09ae-4678-8ca4-5865cde347d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "458521ca-a2e4-478e-9cf0-6d97b49044b4", "AQAAAAIAAYagAAAAEIVHfWumHElwpvKtXlyhTvEoGub/mazEgqEdxefIXJHzAPZm8MUcIIz8MX4t4kGkVw==", "b7ee6b1a-a0c3-499f-8157-6e09eb0dd3a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7e111a9-4ce8-47da-ab5e-6cff160cf806", "AQAAAAIAAYagAAAAEKMD7o/EjANPJ9t5ITaS4ikChWxkxOV4drX+vS/7FzImRQ087IAELUz5NtiCjFuFrw==", "0ce55884-bc58-4cea-b077-76b4f4982660" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 12, 35, 45, 647, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 4, 12, 35, 45, 647, DateTimeKind.Local).AddTicks(123), new DateTime(2025, 3, 4, 12, 35, 45, 647, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 4, 12, 35, 45, 647, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 4, 12, 35, 45, 647, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 4, 12, 35, 45, 647, DateTimeKind.Local).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 12, 35, 45, 647, DateTimeKind.Local).AddTicks(387));
        }
    }
}
