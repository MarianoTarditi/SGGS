using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class iiqq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Modulos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
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
                    PermissionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permisos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RolePermisos",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    UpdatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermisos", x => new { x.RoleId, x.ModuleId, x.PermissionId });
                    table.ForeignKey(
                        name: "FK_RolePermisos_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermisos_Modulos_ModuleId",
                        column: x => x.ModuleId,
                        principalTable: "Modulos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermisos_Permisos_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permisos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "fad09ee4-a2cf-44df-b539-dd5a5e64ba7d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "584eea23-3599-4301-915a-9eee2bce193a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "95bdcdf0-0fd5-4c4e-ba80-cce7b57f12b9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "596927e9-6f8e-43f0-bc29-b8a87b76d682", "AQAAAAIAAYagAAAAEGwmh2SYofRq9tH69JCqeWRF03QxvySJAlrJnIt/UeIbkA4oAHqFecRpz8J/1nFx/Q==", "214d6f51-0c39-4b7d-adf8-635c6f5f5dd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e292cbe2-58ef-4c82-91cc-f98b426a05fa", "AQAAAAIAAYagAAAAEKWvSVsoa0QRClS2zpPeR+ZR36jSRkoOvXywUQjNs86eIEi9V9pg6ovpsFi8sd1ucA==", "750318b3-8f0e-48d5-b97c-e5c9a7d3ebc1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9b94e5f-9885-4656-89ae-5e7bda31994c", "AQAAAAIAAYagAAAAEC2u8rcFLFoxeNeErgH+4R1u1d38YqyK6Pbva7wa6V34TyQSU2BqEPtjco5cu6mHQQ==", "571e2072-ea93-4d05-888e-2e17f2a33daf" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 27, 17, 35, 23, 917, DateTimeKind.Local).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 2, 27, 17, 35, 23, 917, DateTimeKind.Local).AddTicks(5055), new DateTime(2025, 2, 27, 17, 35, 23, 917, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 27, 17, 35, 23, 917, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.InsertData(
                table: "Modulos",
                columns: new[] { "Id", "CreatedDate", "Nombre", "UpdatedDate" },
                values: new object[] { 1, "05/05/2025", "Pagos", null });

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 27, 17, 35, 23, 917, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 27, 17, 35, 23, 917, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.InsertData(
                table: "Permisos",
                columns: new[] { "Id", "CreatedDate", "PermissionType", "UpdatedDate" },
                values: new object[] { 1, "05/05/2025", "Pagos", null });

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 27, 17, 35, 23, 917, DateTimeKind.Local).AddTicks(5457));

            migrationBuilder.InsertData(
                table: "RolePermisos",
                columns: new[] { "ModuleId", "PermissionId", "RoleId", "CreatedDate", "Id", "UpdatedDate" },
                values: new object[] { 1, 1, "a086370d-a143-42d2-ad86-1d32eb9e7546", "05/05/2025", 1122, null });

            migrationBuilder.CreateIndex(
                name: "IX_RolePermisos_ModuleId",
                table: "RolePermisos",
                column: "ModuleId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermisos_PermissionId",
                table: "RolePermisos",
                column: "PermissionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolePermisos");

            migrationBuilder.DropTable(
                name: "Modulos");

            migrationBuilder.DropTable(
                name: "Permisos");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "f5b70fd3-85e9-4b63-a036-746879b93937");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "4c4d58a0-8aea-40d8-9f8c-d68226aae822");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "d68c4f08-c46f-49da-9717-e2aba87d82b3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34d39f44-2f9e-43c0-9a6d-ced0c62094c6", "AQAAAAIAAYagAAAAEGVXK4SLfHEJ28vYgBhbnZ49tj9evZy7iUzg5OcPgpSUA9EkBCWC3m3Y43jmsD3ITg==", "9282c43f-016f-4be6-9bf9-582833110610" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1667daee-f3c5-4c55-9187-6c15d5283006", "AQAAAAIAAYagAAAAEOtLySZprgKTmKT+FoYLWs3EOfZdFrqoYxelPO1t8N/g1bnEMN7HPNowBlqKl5PYyg==", "95b9c927-e0f8-48be-a703-eb0ec0a4e156" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "255ec2e4-e0b2-465f-9eb6-8f5a9a25711b", "AQAAAAIAAYagAAAAED/wmRvg4QcqJJmlr0PeY46bxO1T4m3txCg7j++iWIciV8OcmQjn5SrfjyBCfDvnqw==", "ecf9c1ef-17f8-4c55-930a-a1bc83f76f01" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7039), new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7568));
        }
    }
}
