using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class opqpaq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Funciones_FuncionId",
                table: "Miembros");

            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Rama_RamaId",
                table: "Miembros");

            migrationBuilder.AlterColumn<int>(
                name: "RamaId",
                table: "Miembros",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FuncionId",
                table: "Miembros",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "ec45930e-5bb5-43ea-99db-8cdc4552a37e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "bd0ef904-52a9-4432-84ca-07025daa0e0b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f4acfd4-6e20-46bf-b00b-4a357ab0368f", "AQAAAAIAAYagAAAAEOEI/1vpZNo7EwNB7mBzoilFJiZSdZlm6eU/ERMngCFJ9JyarI2HnltdBrnLo0XThw==", "06577d1d-cce7-49fe-acb2-c1ec90ab0106" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4ca8430-e88c-445b-adbc-cec6a5c5a387", "AQAAAAIAAYagAAAAEFIbRwKZ5CHtxtN5BSVDj/aK13ED/6RSZYlZO3R8fp+iq6OCP6RMlrhCYUu1fUy/6w==", "35e8dc0d-8edc-4be3-99a4-69bdf388d0fe" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(4264), new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(4265), new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(4267), new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(4268), new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 2, 20, 25, 33, 623, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Funciones_FuncionId",
                table: "Miembros",
                column: "FuncionId",
                principalTable: "Funciones",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Rama_RamaId",
                table: "Miembros",
                column: "RamaId",
                principalTable: "Rama",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Funciones_FuncionId",
                table: "Miembros");

            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Rama_RamaId",
                table: "Miembros");

            migrationBuilder.AlterColumn<int>(
                name: "RamaId",
                table: "Miembros",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FuncionId",
                table: "Miembros",
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
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 2, 19, 56, 55, 925, DateTimeKind.Local).AddTicks(2193));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Funciones_FuncionId",
                table: "Miembros",
                column: "FuncionId",
                principalTable: "Funciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Rama_RamaId",
                table: "Miembros",
                column: "RamaId",
                principalTable: "Rama",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
