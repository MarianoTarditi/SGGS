using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class aksdak : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "98d585eb-5942-466a-8227-ce479ad5234c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "b02a0e4c-a911-4164-8a2a-afbc8191d19e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a086370d-a143-42d2-ad86-1d32eb9e7546", "b2ed967c-5440-40d5-b28e-0007ab6c47f7", "External Member", "EXTERNAL MEMBER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b5ef702-37b5-4f4e-9ff1-583e77256d00", "AQAAAAIAAYagAAAAEOLuo8ZjwlJj3xKIMVVZufl8MTe73eElrsRiPv9WPZwGwDN290zApOMkc0CALN5QxA==", "d89cc6e8-2986-47e6-8564-12768074021f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0bc1115-e41c-4ee4-89fc-234bdb2048f0", "AQAAAAIAAYagAAAAEErgLhdFOcnhonCoFWWqkCVHsedWzqNwgfQfLwYg/v0qtPiCdZzXFaynOYVlukcMEA==", "c8575d53-d5ae-48c0-866f-067e109c237f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FileName", "FileType", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f906a15b-50f8-4e47-b44f-df9ac87dee9a", 0, "3b14b5a6-59a3-4241-8e9c-58c4ba835143", "jorgemartinez@gmail.com", false, null, null, false, null, "JORGEMARTINEZ@GMAIL.COM", "JORGE", "AQAAAAIAAYagAAAAELy4fYL6MUbvph2BAk4L3KfvSHDQFsddXTjHkGlHAvFjzt0Kd3pUUGaIVqiN6Kq23Q==", null, false, "bbdb8751-5a06-49d3-8f93-6679df9a2d46", false, "jorge" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(7121), new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(8016), new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(8017), new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(8017), new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(8019), new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(8019) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 20, 16, 16, 2, 931, DateTimeKind.Local).AddTicks(7409));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { "a086370d-a143-42d2-ad86-1d32eb9e7546", "f906a15b-50f8-4e47-b44f-df9ac87dee9a", "AppUserRole" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a086370d-a143-42d2-ad86-1d32eb9e7546", "f906a15b-50f8-4e47-b44f-df9ac87dee9a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "1bd17f99-ff51-4e0c-ad00-c9b7112a676e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "f893f7b3-d7a0-40cf-919a-8ea43093c41d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e3cbde7-12fc-47a3-befc-6f6ed9a5f70b", "AQAAAAIAAYagAAAAEA54sMn1hHG30hqAb5EoXLOnxotLjoY7EI2lHVfTr2dTRtw966ba3xydORmsm/vsPg==", "4419b81e-43ea-49a2-8998-5dc0a69858f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f3560e8-96c7-4860-8f06-9eabf100a5e7", "AQAAAAIAAYagAAAAELlshG+3FxKB6urEOGHcLTHxXHIWS/DWBXS6b4VOTSk4nBWonqHt2PPcJsSwOHABZA==", "6fab70ef-a84c-4287-8058-3b411b04dd12" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(8013), new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(9437), new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(9440), new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(9441), new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(9442), new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(8562));
        }
    }
}
