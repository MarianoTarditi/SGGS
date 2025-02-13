using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class sdjfda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "d6e45532-fc89-4cdc-9ae6-ada3f0cc3466");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "7ebf3225-b499-493f-b74b-bfb95d2f2d9b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "906ecef5-ba8f-4fea-9ffc-922b9df1aa04", "AQAAAAIAAYagAAAAEMoPwJXCpf0tyajZ7pXJNeFRI5bVko7KaHVWqbuHAjXBzTNz+TQIRwIliQMpaDvmIQ==", "456c3479-8380-4e83-9bad-38feb622f45d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29f7c898-cc34-4c91-8ddc-bf062ee2fe9c", "AQAAAAIAAYagAAAAEMrbAJokSF8cOzJq0GL8HPDmu4DorYTr2oaizv3+r7JcUGy21EVMu17gMdNH8P7cbA==", "f05b20e4-ad5b-4b93-8878-e6512bfead80" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 21, 37, 59, 389, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(1062), new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(1063), new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(1063), new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 21, 37, 59, 390, DateTimeKind.Local).AddTicks(600));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
