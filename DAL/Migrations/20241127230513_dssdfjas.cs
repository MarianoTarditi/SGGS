using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class dssdfjas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "677d2641-df35-4a7a-9b9f-cedf92a4c397");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "690eb36e-cf5d-4667-b1e5-9be5abcbf2bb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45792439-832b-417a-9a19-866dda030cac", "AQAAAAIAAYagAAAAEJliu02dVWj4x79kTb+wNX8WuWbmv8KeEEIae4PuHtKYqv+KPL/gwCH3Cu7ualOFoQ==", "dcaacc5c-1575-4dfd-90e1-fb7069647c8f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7218b7c4-b0f9-417c-9e24-9d370fe01f8c", "AQAAAAIAAYagAAAAENdpyIUSzcAjlILdv+GaDKI3KECLl1cH4Hmr39wlgWl09NeCFwP9vMsDfYuIcUXpMQ==", "5e82b4eb-e180-42b3-9c2e-a408403da021" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(2165), new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(2166), new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(2168), new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(2168), new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 20, 5, 13, 30, DateTimeKind.Local).AddTicks(1683));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "e96a7b24-4bdd-4f39-95fc-5aa5f87bb153");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "92d6e313-2aa3-46ef-aab2-2ee800a9a6c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2171cbe-41d0-4424-ab18-2f0a93fc76d6", "AQAAAAIAAYagAAAAEHjTs+mCKKN485XfK3Gop6pdgWpIVx//k7FItsDaK2ykj9nYaMxQKg7cgj4zyP/kxA==", "28d37134-f1d5-47dd-9e81-45e182f92cee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d32e5924-63ca-4a32-82eb-3b64105f4ce0", "AQAAAAIAAYagAAAAEBZW5f3XjLB70sIjDeDzbe0xyc5IW9t9E35WFsZ4SCOqY6eO6pffPpUfh8jy6CVmPw==", "f24b6ae4-d2fc-4bed-a945-e6c20be9b58b" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5856), new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5858), new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5859), new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5860), new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 19, 47, 54, 673, DateTimeKind.Local).AddTicks(5382));
        }
    }
}
