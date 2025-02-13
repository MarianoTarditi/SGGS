using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class sdajfada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Miembros_MiembroId",
                table: "Pagos");

            migrationBuilder.AlterColumn<int>(
                name: "MiembroId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "a938a7f6-f71f-4e12-9fc0-0be1d1d23b0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "0c0c053c-b505-41e3-b29a-22040cea90bf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ae417b1-1081-4ebd-9455-957441a68d2a", "AQAAAAIAAYagAAAAEARS/dfSKixnBtSCyWr+HARMIdOljLcQyM3J12zn0LnnMi5ZjV2EJGho7xazdAt3og==", "fcb00a74-c452-4da2-8c61-a014c95954d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd7a607-a227-4063-af70-14eb6f020f6f", "AQAAAAIAAYagAAAAECr08kSkJ45YtJ9biaCYHmxCLVxD1/NoVe5lkIpC2US2HoWk1+CHgJYemna31XKMwg==", "620d7ecc-04ea-4cb2-b2e1-d21c47f276fd" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8398), new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 22, 11, 35, 505, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Miembros_MiembroId",
                table: "Pagos",
                column: "MiembroId",
                principalTable: "Miembros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Miembros_MiembroId",
                table: "Pagos");

            migrationBuilder.AlterColumn<int>(
                name: "MiembroId",
                table: "Pagos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "c608af53-e083-498d-a228-d495f4482aeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "e796f0f1-ec44-4e0c-9340-03ab48a8c804");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67200773-a358-4158-9528-ecc338aa5965", "AQAAAAIAAYagAAAAEFJC+X0Qr52V0sTh/nSLhh8BhepfdwP+C7q0jN8nYCgjFkj6urXDQLBqLCry5zehWw==", "d2e0e431-8611-4661-b21e-0b4e3e5f408d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9b9852a-0b58-4273-b6ff-5005f3b87ed4", "AQAAAAIAAYagAAAAECf8sLMbQgp9EXyhNwImPp3+hXcc3sER+VdspeHVk7QvoL0PRku43b6ls3scbuXpGQ==", "2d60cf96-9d06-480b-81d8-bf1ce69acf93" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(8340), new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(8342), new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(8343), new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(8344), new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(8345) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 21, 48, 6, 971, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Miembros_MiembroId",
                table: "Pagos",
                column: "MiembroId",
                principalTable: "Miembros",
                principalColumn: "Id");
        }
    }
}
