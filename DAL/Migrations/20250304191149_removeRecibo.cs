using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class removeRecibo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recibos");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "75fb6a5a-e735-4886-ad79-f5264796a54f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "9f39bb28-8571-4f12-89b6-1e07755167cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "e5208f85-0b1c-4034-89bf-9629fb6069bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e02e3991-e159-463a-8e25-272c441f8b6e", "AQAAAAIAAYagAAAAEPkizUHPEQCyb4hWeBJvNtGuQzpZJLDr1kZlVmvvxLmWQYHgKktERGDr9XX8Gc0WgQ==", "4880b3c4-7429-4f24-945d-ccad4a7531d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a704ffa8-3cab-49ed-855e-92d291a8b0c0", "AQAAAAIAAYagAAAAEFiU5PexhWGPW2A3aTvevMSVkOvoo6pcQsb7Th432RXEn5pdNgiTFl69EmSvPHdq6A==", "926e57ca-b981-467e-be0d-a34bd1aac024" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "891719e2-8920-4d62-82fc-cec5461c8502", "AQAAAAIAAYagAAAAEA4mSC9ctiv3xC4rDoei2w/O8BNNMBNxBJvyyE39vWQAyBrUr26+dLw7Gf0fcgQLuQ==", "17229781-fcf1-4ad4-905f-c8452add0b05" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1245), new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1627));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recibos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PagoId = table.Column<int>(type: "int", nullable: true),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UpdatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recibos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recibos_Pagos_PagoId",
                        column: x => x.PagoId,
                        principalTable: "Pagos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "99b2c6dd-6903-4c1f-b511-497ab5ee6967");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "1abb0af3-909e-4b7b-abef-793bb31b0ff1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "d703adb1-d13c-4f2b-9848-c1bb4562f943");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04cf4bc9-e569-4fa1-bcb7-b95849c5328c", "AQAAAAIAAYagAAAAEMrScMk0ogV5tanofJP+xl/otMim1jVvGL1e0gBDyMO/Y1kfAFvDRmyK6LnfeyGpzg==", "6d2c98e4-2d3e-4fa6-b927-c73534491b5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aebe3e9-7ca6-4269-a0bf-635df5eb0ae2", "AQAAAAIAAYagAAAAEHZSwleoTqM/5DVzdpYK1t5hYONY/q6epenfEw+QCr+o5lcv09ewf1Cv5TKApPRV5w==", "4c2bbb60-1105-4fea-abab-92745dddbe1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b810bc3f-7b8f-45f0-b516-dc1266913ed0", "AQAAAAIAAYagAAAAEPjgfPXnyPd1rK95K4WxYavzzBnhmczSJQgle941qW4AJT9Iqy1HJoUgFymha329ow==", "1404d44d-8df7-44e9-8f9c-e9a5bd89b15d" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4168), new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.InsertData(
                table: "Recibos",
                columns: new[] { "Id", "Codigo", "CreatedDate", "Fecha", "PagoId", "Total", "UpdatedDate" },
                values: new object[] { 1, 1012, "05/05/2025", new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4562), 1, 3000m, null });

            migrationBuilder.CreateIndex(
                name: "IX_Recibos_PagoId",
                table: "Recibos",
                column: "PagoId",
                unique: true,
                filter: "[PagoId] IS NOT NULL");
        }
    }
}
