using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class oqoqo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "MontoAfiliacion",
                table: "Deudas",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "MontoSeguroAcompañante",
                table: "Deudas",
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
                value: "afcb6a42-e8e5-446f-ac6c-3e9df17766e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "f3b13f48-f109-4df3-9afa-d19793aaa976");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da8bfef4-b089-4cb1-9cc2-8e3bd8e08e19", "AQAAAAIAAYagAAAAEG+cYj3N4BYSqdYSh7qwXxO5lOxakHGqLcj2xpNQikPo/v0wgGkBHnaGnz2GpDI8Bg==", "dd518c5b-3e53-426d-8149-385df2565f49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e66c5e20-2009-4d3b-ac84-70cfd8bb1660", "AQAAAAIAAYagAAAAEKCeoD4r3ge9jADLNL8CNKlUA9fX3QuS94bBYdY4KCcxGYuqD6j0qRSafDl0mfiquA==", "ce31c7b7-aa07-4648-ab5c-d70694891c87" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 29, 22, 57, 11, 310, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 1, 29, 22, 57, 11, 310, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaVencimiento", "MontoAfiliacion", "MontoSeguroAcompañante" },
                values: new object[] { new DateTime(2025, 1, 29, 22, 57, 11, 310, DateTimeKind.Local).AddTicks(9368), 1000m, 2000m });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 29, 22, 57, 11, 311, DateTimeKind.Local).AddTicks(619), new DateTime(2025, 1, 29, 22, 57, 11, 311, DateTimeKind.Local).AddTicks(620), new DateTime(2025, 1, 29, 22, 57, 11, 311, DateTimeKind.Local).AddTicks(622), new DateTime(2025, 1, 29, 22, 57, 11, 311, DateTimeKind.Local).AddTicks(623), new DateTime(2025, 1, 29, 22, 57, 11, 311, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 29, 22, 57, 11, 310, DateTimeKind.Local).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 29, 22, 57, 11, 311, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 29, 22, 57, 11, 311, DateTimeKind.Local).AddTicks(58));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 29, 22, 57, 11, 310, DateTimeKind.Local).AddTicks(9849));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MontoAfiliacion",
                table: "Deudas");

            migrationBuilder.DropColumn(
                name: "MontoSeguroAcompañante",
                table: "Deudas");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "2c14c048-0c43-47f8-9d20-7cab6cbfb3f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "6f1ebd39-61a4-4bc4-a658-8815fafc4b71");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99b7a45f-2979-4156-9dc9-2ef0bbc3a2a4", "AQAAAAIAAYagAAAAEETqCGt65+Sj54HcUcGHkmmXC/WOkOsEewAomSenD0HMOW7FQ5MQ+gn4i1rEVVbboQ==", "3784e820-f2d7-4781-b568-bd7638c0c21e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c71b7332-d68c-4739-95ce-9cb4bd63408d", "AQAAAAIAAYagAAAAEFQHGrALotiRwcXpf+m3fpWu4vbPoszAwSUMiHyfxtPwt6ufU+p5qEztRbj4mSCaAQ==", "1e28c34f-441f-4c81-983f-6c7dc11ee901" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(5164), new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(5166), new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(5168), new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(5169), new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 29, 22, 4, 58, 170, DateTimeKind.Local).AddTicks(4506));
        }
    }
}
