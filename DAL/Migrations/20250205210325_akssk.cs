using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class akssk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DeudaOriginalAfiliacion",
                table: "DetallesPagos",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DeudaOriginalSeguro",
                table: "DetallesPagos",
                type: "decimal(18,2)",
                nullable: true);

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
                table: "DetallesPagos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DeudaOriginalAfiliacion", "DeudaOriginalSeguro" },
                values: new object[] { 200m, 100m });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeudaOriginalAfiliacion",
                table: "DetallesPagos");

            migrationBuilder.DropColumn(
                name: "DeudaOriginalSeguro",
                table: "DetallesPagos");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "a42173e6-8acc-479e-a383-a31c2677574b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "cdf3aad3-eace-44c4-abfa-deb666201611");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8cfcbcc-f763-4d72-8148-3c395c63fd37", "AQAAAAIAAYagAAAAECAeKXUo5wQY3EWisuXB5US1glgmBvTMeEIpHle/SITQu22DUZH9hU1CLJwZQnlxbg==", "eae45cd2-20ae-4e67-a141-39c0875eea1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3ebfafc-9f13-48d5-acd6-0f85064143b0", "AQAAAAIAAYagAAAAEITkbdmbNvXeEHuEdvHaG6/gMSeVCCTyhhj9KcFPihZ6duI2NAOCFPFIfZDCsfDODg==", "8c6ce03b-bd70-4929-b513-6bf499c93707" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(7228), new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(7229), new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(7230), new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(7231), new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(7232) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 5, 15, 41, 42, 386, DateTimeKind.Local).AddTicks(6619));
        }
    }
}
