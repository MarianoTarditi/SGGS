using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class dassa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MiembroId",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "b7af2372-324c-4680-a8f3-6439697b083f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "6a236e79-aebc-4c0e-9330-8d1fff319b6b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "602cb6f2-296e-499b-834e-c3dc5bb48756", "AQAAAAIAAYagAAAAEExx0wXVyb8nnMbQHcEoARyC/IWiJKQoW+jDDb1740IKq6OWTRdD1SXyfyEM5yR74w==", "c2f4db1e-d943-4a53-8d20-968c868555da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f98abbe-5074-45bf-9ee5-56d045063dc0", "AQAAAAIAAYagAAAAEL/xIP6zl28riuMc2ZsMJa4OST+mVJN9Bgeh8CQ1D8m//5fkfGvvhDmdsbA4FU02ag==", "74292397-e07d-42ce-99c1-f658cb2a78b5" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "Deuda",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(6329), new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(6330), new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(6331), new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(6332), new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(5833));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 1,
                column: "MiembroId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 23, 18, 39, 40, 107, DateTimeKind.Local).AddTicks(5900));

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_MiembroId",
                table: "Pagos",
                column: "MiembroId");

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

            migrationBuilder.DropIndex(
                name: "IX_Pagos_MiembroId",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "MiembroId",
                table: "Pagos");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "9fed0d83-59e9-49c1-81a4-bab158617aad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "1ec4824c-2889-4df0-9a6c-2fa29b5802be");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09fc7723-5c4d-468c-b1a8-09c5fe6fa32f", "AQAAAAIAAYagAAAAEATtCZIpy+aXo4cXuxwK+byeuBynlA4PhCyeVJi+3XTMvdGrrE0mx4vcQfDQycJ7kw==", "d48faa33-6a06-4966-8a3a-2c1a8e278645" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98a13460-1555-4f79-9067-2e7a298ea520", "AQAAAAIAAYagAAAAEJPHu6HBV5bILC0CxPJTFXCTFsG4MxjCg8Ym9NILpF40/0mYTfhNl/kJnJJNZWMYlw==", "5653fadc-261e-46dc-886f-00a56d6e0153" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Deuda",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9796), new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9796), new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9797), new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9799), new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 17, 17, 48, 45, 152, DateTimeKind.Local).AddTicks(9399));
        }
    }
}
