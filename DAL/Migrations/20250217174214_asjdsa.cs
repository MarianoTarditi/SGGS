using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class asjdsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "SaldoDebitado",
                table: "Deudas",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "FechaCreacion", "FechaVencimiento", "SaldoDebitado" },
                values: new object[] { new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(8013), new DateTime(2025, 2, 17, 14, 42, 12, 833, DateTimeKind.Local).AddTicks(8005), false });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaldoDebitado",
                table: "Deudas");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "e0f87719-ccdd-48ca-89de-156deea793fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "efba535e-49b2-40dc-891d-d6e8a5e3c706");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afe49e68-9da8-4f08-9f74-be0ad10ee844", "AQAAAAIAAYagAAAAEMbwOmbEytSac8a0zj5eC2IjolRquCBB3d4v1D+1NEkv9/iFlj+rK4zv9ZWO1OhmZQ==", "51180755-8897-406a-8be2-d6ed91365113" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7766dc1a-91cb-4cfb-99ed-70977ad944a9", "AQAAAAIAAYagAAAAEE/iAu+5uFBjfAhuxGJMZCtG7NBpYXIxmt8hSTj5UrjLfxoKHNXJmzYEbcJOZybruA==", "a9f398d2-ff68-48da-a1de-409eadabc620" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(1722), new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(2719), new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(2719), new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(2720), new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(2721), new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(2055));
        }
    }
}
