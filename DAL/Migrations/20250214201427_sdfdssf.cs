using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class sdfdssf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InisgniaMadera",
                table: "Miembros",
                newName: "InsigniaMadera");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InsigniaMadera",
                table: "Miembros",
                newName: "InisgniaMadera");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "ede4196c-fef1-47c9-a9f0-0adc5823b45f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "06a7323d-2126-4938-924c-f0c498a7c4d1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "efe3341d-ae93-403e-a242-cad971bc4a3f", "AQAAAAIAAYagAAAAEJ5sZz/Xx/dQ0rcC8GewiqoudT2WBfpC+uBSKbyJV1X4fb7ToYe1wkKm9oypnABydw==", "57b107d9-6970-4bd7-8e67-f4d0e56ff465" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32ae78cd-2c3f-4e1c-8c11-e917365938f1", "AQAAAAIAAYagAAAAEEyVzJ411jzb+6jVXoO4+7Y3VyyD/9RisIPp8RDfQdWFFFmuVGvS5q+m7HgbmsMq7w==", "feadf5a1-5f3b-4c73-a3ac-8abe42180c68" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 10, 13, 32, 47, 184, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 10, 13, 32, 47, 184, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 2, 10, 13, 32, 47, 183, DateTimeKind.Local).AddTicks(9939), new DateTime(2025, 2, 10, 13, 32, 47, 183, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 10, 13, 32, 47, 184, DateTimeKind.Local).AddTicks(1989), new DateTime(2025, 2, 10, 13, 32, 47, 184, DateTimeKind.Local).AddTicks(1993), new DateTime(2025, 2, 10, 13, 32, 47, 184, DateTimeKind.Local).AddTicks(1995), new DateTime(2025, 2, 10, 13, 32, 47, 184, DateTimeKind.Local).AddTicks(1996), new DateTime(2025, 2, 10, 13, 32, 47, 184, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 10, 13, 32, 47, 184, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 10, 13, 32, 47, 184, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 10, 13, 32, 47, 184, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 10, 13, 32, 47, 184, DateTimeKind.Local).AddTicks(271));
        }
    }
}
