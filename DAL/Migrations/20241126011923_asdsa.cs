using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class asdsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deuda_Miembros_MiembroId",
                table: "Deuda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deuda",
                table: "Deuda");

            migrationBuilder.RenameTable(
                name: "Deuda",
                newName: "Deudas");

            migrationBuilder.RenameIndex(
                name: "IX_Deuda_MiembroId",
                table: "Deudas",
                newName: "IX_Deudas_MiembroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deudas",
                table: "Deudas",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "d4938581-0690-4859-b014-687682f1db18");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "efb4488c-aa09-4e6f-975f-505d1641c635");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "440d6fe4-6238-4a53-8eeb-7ab9509976dc", "AQAAAAIAAYagAAAAEKwyyUeASIRe4SewToL/UZ6bnk550TNRm+8BD7V1XXQI8N0N1Nto7gMqfOpKcyWrEw==", "fc76a36e-1506-4428-957b-12e44de6e2ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7ed9384-6cf8-4483-8e55-1da2d805744e", "AQAAAAIAAYagAAAAEHH/OIaX38mijlbkpLJUge4sFhKT6L0V1uGK1XII2cSiaw7CiJa+V24ljZcSFRRPcg==", "8b3bce13-2a53-4d85-b9c4-f83b0de5b575" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 25, 22, 19, 22, 901, DateTimeKind.Local).AddTicks(108), new DateTime(2024, 11, 25, 22, 19, 22, 901, DateTimeKind.Local).AddTicks(109), new DateTime(2024, 11, 25, 22, 19, 22, 901, DateTimeKind.Local).AddTicks(111), new DateTime(2024, 11, 25, 22, 19, 22, 901, DateTimeKind.Local).AddTicks(111), new DateTime(2024, 11, 25, 22, 19, 22, 901, DateTimeKind.Local).AddTicks(112) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 25, 22, 19, 22, 900, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.AddForeignKey(
                name: "FK_Deudas_Miembros_MiembroId",
                table: "Deudas",
                column: "MiembroId",
                principalTable: "Miembros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deudas_Miembros_MiembroId",
                table: "Deudas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deudas",
                table: "Deudas");

            migrationBuilder.RenameTable(
                name: "Deudas",
                newName: "Deuda");

            migrationBuilder.RenameIndex(
                name: "IX_Deudas_MiembroId",
                table: "Deuda",
                newName: "IX_Deuda_MiembroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deuda",
                table: "Deuda",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Deuda_Miembros_MiembroId",
                table: "Deuda",
                column: "MiembroId",
                principalTable: "Miembros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
