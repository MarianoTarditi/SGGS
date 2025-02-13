using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class iaskdksa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Discapacidades_DiscapacidadId",
                table: "Miembros");

            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Estudio_EstudioId",
                table: "Miembros");

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Pagos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Pagos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "Pagos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EstudioId",
                table: "Miembros",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DiscapacidadId",
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
                value: "e7bec80a-2437-4036-8054-7f7e14622e89");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "231a740b-b2aa-4c05-976e-c8f2d1a9e23a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d3ae44b-943d-404f-b689-e39f63e6d39f", "AQAAAAIAAYagAAAAEESQp+hB4RPjZ/MaaDtcdBAqZiuIc+EqglpQoAAObasl7/K9m2WoP7uJyFKkKgF9qQ==", "752d3743-a159-45f5-800d-5c4d4a92905d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d797a193-6a1c-4126-b3cc-2a1c48edeff3", "AQAAAAIAAYagAAAAEP4LizlBxcn4uuIffe9KXl/JVTdJH7C9va1GkBYxqb+otKKEXioF8Oil7LlWXk+BkQ==", "335cbf56-430c-4610-88f3-46393a178577" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(8084), new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(8085), new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(8087), new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(8088), new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Pagos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { "05/05/2025", null });

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2025, 1, 5, 21, 58, 43, 931, DateTimeKind.Local).AddTicks(7527));

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Discapacidades_DiscapacidadId",
                table: "Miembros",
                column: "DiscapacidadId",
                principalTable: "Discapacidades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Estudio_EstudioId",
                table: "Miembros",
                column: "EstudioId",
                principalTable: "Estudio",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Discapacidades_DiscapacidadId",
                table: "Miembros");

            migrationBuilder.DropForeignKey(
                name: "FK_Miembros_Estudio_EstudioId",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Pagos");

            migrationBuilder.AlterColumn<int>(
                name: "EstudioId",
                table: "Miembros",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DiscapacidadId",
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
                value: "5f316902-1737-4698-8136-a2d60e0eb72c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "8286ebc1-e78f-4bcb-bc9b-54a47c00de91");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d782067-a169-4463-b2af-a1a57892ef7f", "AQAAAAIAAYagAAAAEOtfJpXin7WiVCFEcTgbqfE92G6vMFGWkwtWrfRsZeOejJaKtlEaNr7NIz4tPdFaDg==", "238e61b5-5ddd-4b8b-a7f3-f79fe7fb28f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d910dada-848e-4a74-9351-426155bc58cb", "AQAAAAIAAYagAAAAECwrxYC6qkupJ67DDAafW4aurq2pKb9aSiHrkUvCOfsS4xxNQD6YSsgbFsk1EhzZqg==", "f90ab6be-3e58-4250-b361-be4b3a7dc44f" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9809), new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9810), new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9811), new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9813), new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 27, 22, 32, 46, 708, DateTimeKind.Local).AddTicks(9361));

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Discapacidades_DiscapacidadId",
                table: "Miembros",
                column: "DiscapacidadId",
                principalTable: "Discapacidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Miembros_Estudio_EstudioId",
                table: "Miembros",
                column: "EstudioId",
                principalTable: "Estudio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
