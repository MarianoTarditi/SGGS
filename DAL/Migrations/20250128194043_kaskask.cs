using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class kaskask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Celular",
                table: "Organismos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Organismos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Latitud",
                table: "Organismos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Longitud",
                table: "Organismos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<long>(
                name: "Telefono",
                table: "Organismos",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "86216806-b925-4ba1-979a-dd4f31b6e397");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "70dfcb84-7d1f-495d-99a9-ddc687c32f9d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a5c90d-c93e-4980-a9d2-c0f01038008f", "AQAAAAIAAYagAAAAEPOQ3K0Rfdd2i3hq/a8EUsBBjjym0r5jYHVBbyaH27fucuq87YY32+Jx/uDoXDyyrA==", "72600615-50e1-4d94-b58e-0a0696a3e975" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ba55b5a-8e1a-4ef5-9ab6-e335699e1e99", "AQAAAAIAAYagAAAAEJuHVH6zfbkLnR4uv3TOX/iq5iMftKHUzMypmr/mV7mBYuXqdzXHP3otV3WFeyrRTw==", "490e26e1-4e95-48ff-991a-2c936ba69cb6" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 28, 16, 40, 42, 399, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 1, 28, 16, 40, 42, 399, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 28, 16, 40, 42, 399, DateTimeKind.Local).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(842), new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(843), new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(845), new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(845), new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 28, 16, 40, 42, 399, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Celular", "Email", "FechaCreacion", "Latitud", "Longitud", "Telefono" },
                values: new object[] { 24643456L, "sggs@gmail.com", new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(440), "-33.03604633935", "-59.008276462555", 24564534L });

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(141));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "Latitud",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "Longitud",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Organismos");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "001099d6-41c7-451d-aae3-71b39d1b2a8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "c70078ef-5cdb-4b16-a4a8-5eb274dc358a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8274cf4-e9e8-459c-9439-353a9e1ff5c5", "AQAAAAIAAYagAAAAEGQW3GAeWZ0TeKK5O7mnhPWGDTn9CTB6fmTKYYgC0kCGiEkN2iPFSmYwWFfOSdduKg==", "d5f65186-ad58-49a1-8dd9-4f5d3a29ce7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da0c909f-a4d9-4320-87a5-4cfea77c7184", "AQAAAAIAAYagAAAAEFwWju7FUJxxJTZTDr+5l4LbyvOjGYmvKxXvotY/A6b1kVii/5WDFOrVAZiKQbrNYg==", "1f735d88-70c1-44e9-a960-3cef01f3f3ac" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(9222), new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(9227), new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(9229), new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(9230), new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(9233) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 18, 11, 13, 329, DateTimeKind.Local).AddTicks(8444));
        }
    }
}
