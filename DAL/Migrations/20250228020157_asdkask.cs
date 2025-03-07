using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class asdkask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RolePermisos");

            migrationBuilder.RenameColumn(
                name: "PermissionType",
                table: "Permisos",
                newName: "PermissionName");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Permisos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "6a34709f-72fe-4cf1-9111-df5c3b8f663d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "6e73e19e-7f02-4ae7-8dc9-716839db45ff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "b51b41c9-6a16-41df-810c-d5cece7b19cc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03b0386d-4c55-461f-a775-da1be5dde758", "AQAAAAIAAYagAAAAEJbeliwhFDyMXoTVnkp3khU0TOXd0TQHRFLPjg+yF7iB+LrpRMH/ku4WfIJieBmKoA==", "b0e3fc2e-999d-4c04-9c58-3549402e8127" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a2b5ff1-00ad-49bb-8d64-c77ec5cc8f8d", "AQAAAAIAAYagAAAAEK2mBbveroD44K7yGsl+4Iz8IOKSphhHg0FY7Fqkt+p2vv6/oiTsHk/Yw9Ow/mMUhA==", "c83b13d7-389d-485c-9dd7-faf0222ca785" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95d4e1f3-fd74-42e9-8f02-93ac1caa5d20", "AQAAAAIAAYagAAAAENT13jCT1RC4ScvhjWpt82GC4hyKOkVEwIjheAul9dvbbGeEVgHUi+ddtvmBxomEsA==", "095d8cb6-bf4e-403a-8cf3-340486781cc0" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(899), new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Permisos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Permiso para pagos");

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 27, 23, 1, 56, 445, DateTimeKind.Local).AddTicks(1248));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Permisos");

            migrationBuilder.RenameColumn(
                name: "PermissionName",
                table: "Permisos",
                newName: "PermissionType");

            migrationBuilder.CreateTable(
                name: "RolePermisos",
                columns: table => new
                {
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ModuleId = table.Column<int>(type: "int", nullable: false),
                    PermissionId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    UpdatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true)
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
    }
}
