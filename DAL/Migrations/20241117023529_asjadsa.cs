using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class asjadsa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BancoOrigen",
                table: "PagoModalidad");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "PagoModalidad");

            migrationBuilder.DropColumn(
                name: "Dni",
                table: "PagoModalidad");

            migrationBuilder.DropColumn(
                name: "NroCuentaOrigenFondo",
                table: "PagoModalidad");

            migrationBuilder.DropColumn(
                name: "NumeroCuenta",
                table: "PagoModalidad");

            migrationBuilder.DropColumn(
                name: "NumeroOperacion",
                table: "PagoModalidad");

            migrationBuilder.DropColumn(
                name: "NumeroSucursal",
                table: "PagoModalidad");

            migrationBuilder.DropColumn(
                name: "Transferencia_NumeroOperacion",
                table: "PagoModalidad");

            migrationBuilder.CreateTable(
                name: "ModalidadDeposito",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NumeroSucursal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroOperacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroCuenta = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadDeposito", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModalidadDeposito_PagoModalidad_Id",
                        column: x => x.Id,
                        principalTable: "PagoModalidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadEfectivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadEfectivo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModalidadEfectivo_PagoModalidad_Id",
                        column: x => x.Id,
                        principalTable: "PagoModalidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadTransferencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    NroCuentaOrigenFondo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BancoOrigen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroOperacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dni = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadTransferencia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModalidadTransferencia_PagoModalidad_Id",
                        column: x => x.Id,
                        principalTable: "PagoModalidad",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "571ea9f0-467f-46b5-9c1f-a0b574e202a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "5441960c-d32f-46c9-97e7-d926ffcf825e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc86a46a-0b48-4e2c-b063-268cde770f1f", "AQAAAAIAAYagAAAAEHg1bOqwokNp7zBsFxg88m/CVCDr4msovky4GwHhMYAp5SmXvJ1sd07qStKwlz8wKQ==", "513fbbda-863f-4ba6-8373-0734c9f8a9c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bf7102b-c596-4e8c-b51c-63d44d9de116", "AQAAAAIAAYagAAAAEExjihDg2Ks+DlhMkX6t/z9iE/+0natm8/hTqRi3og2CTKQq7EJ/T4leOG82gnyz+g==", "a3013ef2-5d1a-481f-b38c-b07d7053b60d" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1735), new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1737), new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1738), new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1739), new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaRegistro",
                value: new DateTime(2024, 11, 16, 23, 35, 28, 703, DateTimeKind.Local).AddTicks(1313));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ModalidadDeposito");

            migrationBuilder.DropTable(
                name: "ModalidadEfectivo");

            migrationBuilder.DropTable(
                name: "ModalidadTransferencia");

            migrationBuilder.DeleteData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "BancoOrigen",
                table: "PagoModalidad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "PagoModalidad",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Dni",
                table: "PagoModalidad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NroCuentaOrigenFondo",
                table: "PagoModalidad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroCuenta",
                table: "PagoModalidad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroOperacion",
                table: "PagoModalidad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroSucursal",
                table: "PagoModalidad",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Transferencia_NumeroOperacion",
                table: "PagoModalidad",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "PagoModalidad",
                columns: new[] { "Id", "Discriminator", "FechaDePago", "NombreCompleto", "Observacion", "PagoId" },
                values: new object[] { 1, "ModalidadPago", new DateTime(2024, 11, 16, 23, 32, 21, 654, DateTimeKind.Local).AddTicks(4548), "Mariano Tarditi", "Pago hecho con transferencia", 1 });

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
    }
}
