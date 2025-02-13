using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class sdjfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recibos_Pagos_PagoId",
                table: "Recibos");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "71dce429-30f6-48d8-810b-198532160c88");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "7bec9cc3-9423-4176-b758-240b00ccb3f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b949af0-471d-4f66-886c-22069977ffcf", "AQAAAAIAAYagAAAAEIT5H/hz9+c9K+iRgZwdcEMl8tTUPFalFYpS1p+Z2WPza2zymwdf6bNGTkZEw2nQhQ==", "618603e5-7314-4807-8283-d674baa64188" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee89e58d-41f6-44f1-8e17-861286f7946c", "AQAAAAIAAYagAAAAEO6UbPzIHYIzOc91WZxfmFijiMe6gjyq7oWKUSjSZv7uqfRofeweP9ZjCZwxJXU29g==", "1891572f-4372-43f0-bf50-56e3997d1bad" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(5785), new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(5787), new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(5788), new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(5789), new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 21, 33, 35, 156, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.AddForeignKey(
                name: "FK_Recibos_Pagos_PagoId",
                table: "Recibos",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recibos_Pagos_PagoId",
                table: "Recibos");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Recibos_Pagos_PagoId",
                table: "Recibos",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "Id");
        }
    }
}
