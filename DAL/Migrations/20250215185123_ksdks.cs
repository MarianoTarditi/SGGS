using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class ksdks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DeudaPendiente",
                table: "Deudas",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "DeudaPendiente", "FechaCreacion", "FechaVencimiento" },
                values: new object[] { true, new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(1722), new DateTime(2025, 2, 15, 15, 51, 22, 274, DateTimeKind.Local).AddTicks(1717) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeudaPendiente",
                table: "Deudas");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "0ab40178-2e98-4f00-9a26-dca7f016948f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "d38d0de5-fd11-442c-876e-8802fa50f4c2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e548c31-b883-44c3-a78a-f2c7ea8adae5", "AQAAAAIAAYagAAAAEPlux9yqE4gl/HfdPgRBeNt8hZtkIPOBgq3mHPtE7Yur8fyvx3GwLi3b7LRGfDXTCg==", "8168d000-625e-4a41-9b23-7ac91398a599" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97a5411d-0a89-493d-8d11-cba01eb06b2e", "AQAAAAIAAYagAAAAEMiNNqiejFF81FUaAnEiHHzEJnUpdQYYNTc0KIJNj5JmidExNgTfkKKPMTcyX59RFQ==", "2544c788-3708-4384-b764-f4ea1884d9a5" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(2507), new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(3575), new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(3576), new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(3577), new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(3578), new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 14, 17, 14, 26, 670, DateTimeKind.Local).AddTicks(2909));
        }
    }
}
