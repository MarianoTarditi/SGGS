using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class sdjfada : Migration
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

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Miembros_MiembroId",
                table: "Pagos",
                column: "MiembroId",
                principalTable: "Miembros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
