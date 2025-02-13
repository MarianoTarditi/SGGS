using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class asjads : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "96a03a26-55ca-4cc3-993e-cda14a0b24e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "84205f4f-51e2-4d96-baa2-7dec67d36ab8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd57ef6-4206-44f3-af0b-c0fddf3c95e3", "AQAAAAIAAYagAAAAEMEFf5/ykEnqHcnakEPV4F+9l0Vd2mFbxAXxp1TJWeahnc+GZhgXAReVAaftLoheAw==", "841ff356-42db-4714-b30b-b68c32023dba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7aabfe7a-a161-4777-9bed-a478abb47847", "AQAAAAIAAYagAAAAEOHpIGCHrRc2mr7Febfmwerkzrh1GTdL8H8+MhsueORoeGvO+W+cmd7cKbHs9IeMLw==", "c961047b-d864-487a-a598-339950effdcc" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(5107), new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(5109), new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(5110), new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(5111) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(4705));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "401f6c20-1949-446e-b192-c8a1c75135d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "3875c360-8ee1-44f3-aed4-16d779ce98d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a6431a7-e229-4813-827c-f0caf3006fae", "AQAAAAIAAYagAAAAEIVmeARgWAfIqaJXJBL2iBe78lsj10ywMCCdy5i4WB61EkFfEVERe2or6E9HK4idbw==", "8cca75e5-3e45-44aa-927f-a883d9b91314" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "455b9201-b9e9-4abe-88fa-aa7163f023d0", "AQAAAAIAAYagAAAAEEgBVEM3qs/tJu64PFywGA+g6QPzki6t/VqgKktWKkj3InrQKhl+4Yq9yOwXl21/+w==", "1f750c8d-4cf3-42d8-83be-671c40f3d549" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6945), new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6947), new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6948), new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6949), new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 16, 23, 29, 29, 935, DateTimeKind.Local).AddTicks(6475));
        }
    }
}
