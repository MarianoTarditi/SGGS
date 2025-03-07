using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class ororo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Modulos");

            migrationBuilder.DropTable(
                name: "Permisos");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    UpdatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modulos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permisos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    UpdatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "61da21ae-e6d1-4a92-824b-2e819b3c47f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "613d608f-93b8-44a6-a38e-f20190ffb21f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "cf9b78fa-8cff-41e2-afd4-df72096a2ad8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a18f513-c9de-4419-b6a7-fb1e2bbcd64f", "AQAAAAIAAYagAAAAEKoHMBRRlM+pqipedgg5S4CeUi1k5p6A+9gwoY8x28gVJaL4yR/ZuK3EYB90ZomSRw==", "bb2a3f16-0204-4dbb-92b1-43ede8ec3da5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df9c7876-1c94-49f1-b803-78a02d46fc71", "AQAAAAIAAYagAAAAEMqIAjVuoiPgR51ub/0GqG7S/BU+/su790Vfd6uZFHmR6tEwNEmslyCdgG71bPaY9g==", "c330c570-2fd3-43e2-85cd-96c7c7b1d37b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3972b946-b55d-4def-8cae-2270d591c21d", "AQAAAAIAAYagAAAAECwExavC6d3Pi/z5zQoXJ8PZuvLd9NmKrWp6cNqBb5GfRLCgdIHQLhJs8nSPfHZBnQ==", "08b251fd-21b4-440d-a254-9099735c7949" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8351), new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.InsertData(
                table: "Modulos",
                columns: new[] { "Id", "CreatedDate", "Nombre", "UpdatedDate" },
                values: new object[] { 1, "05/05/2025", "Pagos", null });

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "Id", "CreatedDate", "Description", "PermissionName", "UpdatedDate" },
                values: new object[] { 1, "05/05/2025", "Permiso para pagos", "Pagos", null });

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 3, 3, 2, 58, 8, 578, DateTimeKind.Local).AddTicks(8718));
        }
    }
}
