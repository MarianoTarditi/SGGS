using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class fsdfds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Deuda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MontoAfiliacion = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MontoSeguroAcompañante = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Tiene = table.Column<bool>(type: "bit", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MiembroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deuda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deuda_Miembros_MiembroId",
                        column: x => x.MiembroId,
                        principalTable: "Miembros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "9fed0d83-59e9-49c1-81a4-bab158617aad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "1ec4824c-2889-4df0-9a6c-2fa29b5802be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09fc7723-5c4d-468c-b1a8-09c5fe6fa32f", "AQAAAAIAAYagAAAAEATtCZIpy+aXo4cXuxwK+byeuBynlA4PhCyeVJi+3XTMvdGrrE0mx4vcQfDQycJ7kw==", "d48faa33-6a06-4966-8a3a-2c1a8e278645" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98a13460-1555-4f79-9067-2e7a298ea520", "AQAAAAIAAYagAAAAEJPHu6HBV5bILC0CxPJTFXCTFsG4MxjCg8Ym9NILpF40/0mYTfhNl/kJnJJNZWMYlw==", "5653fadc-261e-46dc-886f-00a56d6e0153" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.InsertData(
                table: "Deuda",
                columns: new[] { "Id", "FechaVencimiento", "MiembroId", "MontoAfiliacion", "MontoSeguroAcompañante", "Tiene" },
                values: new object[] { 1, new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(8862), 1, 10000m, 5000m, true });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9796), new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9796), new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9797), new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9799), new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.CreateIndex(
                name: "IX_Deuda_MiembroId",
                table: "Deuda",
                column: "MiembroId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deuda");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "571ea9f0-467f-46b5-9c1f-a0b574e202a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "5441960c-d32f-46c9-97e7-d926ffcf825e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc86a46a-0b48-4e2c-b063-268cde770f1f", "AQAAAAIAAYagAAAAEHg1bOqwokNp7zBsFxg88m/CVCDr4msovky4GwHhMYAp5SmXvJ1sd07qStKwlz8wKQ==", "513fbbda-863f-4ba6-8373-0734c9f8a9c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bf7102b-c596-4e8c-b51c-63d44d9de116", "AQAAAAIAAYagAAAAEExjihDg2Ks+DlhMkX6t/z9iE/+0natm8/hTqRi3og2CTKQq7EJ/T4leOG82gnyz+g==", "a3013ef2-5d1a-481f-b38c-b07d7053b60d" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1735), new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1737), new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1738), new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1739), new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1313));
        }
    }
}
