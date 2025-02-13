using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class askdksad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Funciones_FuncionId",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Categorias");

            migrationBuilder.RenameColumn(
                name: "FuncionId",
                table: "Miembros",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Miembros_FuncionId",
                table: "Miembros",
                newName: "IX_Miembros_CategoriaId");

            migrationBuilder.AddColumn<int>(
                name: "FuncionId",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "InisgniaMadera",
                table: "Categorias",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "fcbb8068-ad24-4a02-9559-49e79c41d5fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "13aa390d-1cc7-43d3-b054-26e6de658f5e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7e2a945-72ca-45b1-adc9-cacbe905f17a", "AQAAAAIAAYagAAAAELkFrTks6YXpEGK7SNawfUl+4uNx7uWqQAnnaAvOU23kZWct81i0xqOEqiMegJZAxg==", "5131b537-6cdb-45e1-9a7e-0db4a99f56b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d9c38c7-b1f5-4f25-ae9d-701109f7d78f", "AQAAAAIAAYagAAAAEOhWk91OupCB4b8m1A04STIh7qoydR8s1oZrkld4IxBA7hCbxY+oXI4wNT7/MZTtcg==", "a0aab272-6c50-419b-ba74-b6b4c4689b65" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "CreatedDate", "FuncionId", "InisgniaMadera", "Nombre", "UpdatedDate" },
                values: new object[] { 1, "05/05/2025", 1, true, "Protagonista", null });

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(9036), new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(9038), new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(9040), new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(9040), new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 18, 4, 55, 27, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.CreateIndex(
                name: "IX_Categorias_FuncionId",
                table: "Categorias",
                column: "FuncionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categorias_Funciones_FuncionId",
                table: "Categorias",
                column: "FuncionId",
                principalTable: "Funciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Categorias_CategoriaId",
                table: "Miembros",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Funciones_FuncionId",
                table: "Categorias");

            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Categorias_CategoriaId",
                table: "Miembros");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_FuncionId",
                table: "Categorias");

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "FuncionId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "InisgniaMadera",
                table: "Categorias");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Miembros",
                newName: "FuncionId");

            migrationBuilder.RenameIndex(
                name: "IX_Miembros_CategoriaId",
                table: "Miembros",
                newName: "IX_Miembros_FuncionId");

            migrationBuilder.AddColumn<decimal>(
                name: "Monto",
                table: "Categorias",
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
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 29, 22, 57, 11, 310, DateTimeKind.Local).AddTicks(9368));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Funciones_FuncionId",
                table: "Miembros",
                column: "FuncionId",
                principalTable: "Funciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
