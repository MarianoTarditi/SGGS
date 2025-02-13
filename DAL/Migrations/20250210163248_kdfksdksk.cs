using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class kdfksdksk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaCreacion",
                table: "Deudas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaCreacion",
                table: "Deudas");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "352affce-dba4-4216-a4a6-d6c80a566d44");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "929b2490-2244-49a1-8481-a908c9719af8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d42fbd5d-e881-4aa0-b92c-4b688186f36c", "AQAAAAIAAYagAAAAEEOuM5cH+3n9JzmHipky4oPijt/bSR5XVRDX09Vh6EHgnC6x896OofthxhNt/bH9aw==", "29dd5ab7-31d3-4a3e-a2c1-b1c2bb37a228" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2d7f533-32c3-48e2-b0e9-38b3814faa6e", "AQAAAAIAAYagAAAAEOZiYroVfECzIs/l2PWhogCBJzEhTI6cuiqPvTmI2qs5He9Os7EIOIF2u0flndwRLw==", "394734fb-f9a4-4700-890e-738b5d6a77ea" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 6, 12, 29, 34, 864, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 6, 12, 29, 34, 864, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 2, 6, 12, 29, 34, 864, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 6, 12, 29, 34, 865, DateTimeKind.Local).AddTicks(232), new DateTime(2025, 2, 6, 12, 29, 34, 865, DateTimeKind.Local).AddTicks(234), new DateTime(2025, 2, 6, 12, 29, 34, 865, DateTimeKind.Local).AddTicks(235), new DateTime(2025, 2, 6, 12, 29, 34, 865, DateTimeKind.Local).AddTicks(236), new DateTime(2025, 2, 6, 12, 29, 34, 865, DateTimeKind.Local).AddTicks(237) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 6, 12, 29, 34, 864, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 6, 12, 29, 34, 864, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 6, 12, 29, 34, 864, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 6, 12, 29, 34, 864, DateTimeKind.Local).AddTicks(9640));
        }
    }
}
