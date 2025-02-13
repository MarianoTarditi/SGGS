using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class sdlfdl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CreditoAfiliacion",
                table: "Resumen",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "CreditoSeguroAcompañante",
                table: "Resumen",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DebitoAfiliacion",
                table: "Resumen",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DebitoSeguroAcompañante",
                table: "Resumen",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

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

            migrationBuilder.UpdateData(
                table: "Resumen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreditoAfiliacion", "CreditoSeguroAcompañante", "DebitoAfiliacion", "DebitoSeguroAcompañante" },
                values: new object[] { 100m, 100m, 100m, 100m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditoAfiliacion",
                table: "Resumen");

            migrationBuilder.DropColumn(
                name: "CreditoSeguroAcompañante",
                table: "Resumen");

            migrationBuilder.DropColumn(
                name: "DebitoAfiliacion",
                table: "Resumen");

            migrationBuilder.DropColumn(
                name: "DebitoSeguroAcompañante",
                table: "Resumen");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "339807c2-b36f-48db-ba12-e19246857c57");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "6782919f-f977-4096-82ef-79a2732a1ab0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ce9a70a-b110-46fe-b76f-d51157fb863f", "AQAAAAIAAYagAAAAEGhbiac4Nkd+1E1dQ1bnmvPvWQP6LjPtscNkwAhI/fux1jZbrUxlVto2RWrE3RTOdQ==", "00bfddc9-4752-41a5-bd7c-37fed5c967ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "feaaa2f5-c7a1-437c-be30-a75f872a045a", "AQAAAAIAAYagAAAAEB6D4hG4qvGmfUHpO26Xs7Xz9AKWksaJRIG1jpiyrrSqwp/bEkPLfsd/s1UVjyC6zg==", "f5bf005e-fb2b-492f-b0d1-77a3853363e9" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(3770), new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(3771), new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(3772), new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(3774), new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(3314));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 5, 18, 3, 24, 131, DateTimeKind.Local).AddTicks(3194));
        }
    }
}
