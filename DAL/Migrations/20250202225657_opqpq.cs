using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class opqpq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categorias_Funciones_FuncionId",
                table: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Categorias_FuncionId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "FuncionId",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "InisgniaMadera",
                table: "Categorias");

            migrationBuilder.AddColumn<int>(
                name: "FuncionId",
                table: "Miembros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "InisgniaMadera",
                table: "Miembros",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "0871266d-87a9-49a4-8e70-31fbecfa3530");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "4a4b4d3d-dee4-4fb3-8fc5-4771a29c74e0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "305b00f6-8831-403d-be5f-302cfb0798ee", "AQAAAAIAAYagAAAAEF7wzyvbb3fcE9IEB/eC+xaVUVeJPU3IyM0ZW2VWaT/t3n3mbbCYWzoyuyjflF/EaA==", "86972125-feaa-4627-901f-5f9e95e11980" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "78b3d40a-7d51-492c-aa59-ca933c4cb4ad", "AQAAAAIAAYagAAAAEBqYOxPZSr19Ch3JchRI0zbYr/5Hz85S6rbxFzomGi+kyMInKp+Oz3HfWZbFyNMk1w==", "2e2fdbca-a1a4-48b1-a136-abfce8904250" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(2324));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(3057), new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(3058), new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(3059), new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(3059), new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaNacimiento", "FuncionId", "InisgniaMadera" },
                values: new object[] { new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(2193), 1, true });

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.CreateIndex(
                name: "IX_Miembros_FuncionId",
                table: "Miembros",
                column: "FuncionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Funciones_FuncionId",
                table: "Miembros",
                column: "FuncionId",
                principalTable: "Funciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Funciones_FuncionId",
                table: "Miembros");

            migrationBuilder.DropIndex(
                name: "IX_Miembros_FuncionId",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "FuncionId",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "InisgniaMadera",
                table: "Miembros");

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

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FuncionId", "InisgniaMadera" },
                values: new object[] { 1, true });

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
        }
    }
}
