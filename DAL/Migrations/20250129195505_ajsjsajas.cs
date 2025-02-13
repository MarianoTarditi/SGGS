using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class ajsjsajas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Organismos_Asociaciones_AsociacionId",
                table: "Organismos");

            migrationBuilder.DropTable(
                name: "Asociaciones");

            migrationBuilder.DropIndex(
                name: "IX_Organismos_AsociacionId",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "AsociacionId",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "MontoAfiliacion",
                table: "Deudas");

            migrationBuilder.DropColumn(
                name: "MontoSeguroAcompañante",
                table: "Deudas");

            migrationBuilder.RenameColumn(
                name: "AsociacionId",
                table: "Deudas",
                newName: "OrganismoId");

            migrationBuilder.AddColumn<decimal>(
                name: "ValorAfiliacion",
                table: "Organismos",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorSeguro",
                table: "Organismos",
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
                value: "afdd1e12-d4c3-4af8-9fe4-59c70b1205f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "1642e80d-982d-4066-9ee2-cfc6e768eb7a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "975e2cc9-1200-431d-bc46-fc401ec2687f", "AQAAAAIAAYagAAAAEJ/UzAZt51ib+dxvxWPyVOiVmv70PC/QZkrZVrUWoi3V8fop3T5i4yGKkPKiewWZIA==", "906b7855-d3c0-4ed2-95a6-486c062cbfea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e62cb21-5ca0-475d-bb72-b647f9d55ab2", "AQAAAAIAAYagAAAAEBN1KR19A8ev9K2hekYMOzd0ab0tAPc6QhogpFW1/mYIlYFG3TlUQEdJyQ1dV+OW3w==", "9808d460-88b4-4771-bca2-53f3c66e2721" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaVencimiento",
                value: new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(9417), new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(9417), new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(9418), new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(9419), new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "ValorAfiliacion", "ValorSeguro" },
                values: new object[] { new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(9055), 3000m, 2000m });

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.CreateIndex(
                name: "IX_Deudas_OrganismoId",
                table: "Deudas",
                column: "OrganismoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Deudas_Organismos_OrganismoId",
                table: "Deudas",
                column: "OrganismoId",
                principalTable: "Organismos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deudas_Organismos_OrganismoId",
                table: "Deudas");

            migrationBuilder.DropIndex(
                name: "IX_Deudas_OrganismoId",
                table: "Deudas");

            migrationBuilder.DropColumn(
                name: "ValorAfiliacion",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "ValorSeguro",
                table: "Organismos");

            migrationBuilder.RenameColumn(
                name: "OrganismoId",
                table: "Deudas",
                newName: "AsociacionId");

            migrationBuilder.AddColumn<int>(
                name: "AsociacionId",
                table: "Organismos",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateTable(
                name: "Asociaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AsociacionNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    UpdatedDate = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ValorAfiliacion = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ValorSeguro = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asociaciones", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Asociaciones",
                columns: new[] { "Id", "AsociacionNombre", "CreatedDate", "UpdatedDate", "ValorAfiliacion", "ValorSeguro" },
                values: new object[] { 1, "ScoutsArgentina", "05/05/2025", null, 1000m, 2000m });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "86216806-b925-4ba1-979a-dd4f31b6e397");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "70dfcb84-7d1f-495d-99a9-ddc687c32f9d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a5c90d-c93e-4980-a9d2-c0f01038008f", "AQAAAAIAAYagAAAAEPOQ3K0Rfdd2i3hq/a8EUsBBjjym0r5jYHVBbyaH27fucuq87YY32+Jx/uDoXDyyrA==", "72600615-50e1-4d94-b58e-0a0696a3e975" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ba55b5a-8e1a-4ef5-9ab6-e335699e1e99", "AQAAAAIAAYagAAAAEJuHVH6zfbkLnR4uv3TOX/iq5iMftKHUzMypmr/mV7mBYuXqdzXHP3otV3WFeyrRTw==", "490e26e1-4e95-48ff-991a-2c936ba69cb6" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 28, 16, 40, 42, 399, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 1, 28, 16, 40, 42, 399, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaVencimiento", "MontoAfiliacion", "MontoSeguroAcompañante" },
                values: new object[] { new DateTime(2025, 1, 28, 16, 40, 42, 399, DateTimeKind.Local).AddTicks(9773), 10000m, 5000m });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(842), new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(843), new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(845), new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(845), new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 28, 16, 40, 42, 399, DateTimeKind.Local).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AsociacionId", "FechaCreacion" },
                values: new object[] { 1, new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 28, 16, 40, 42, 400, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.CreateIndex(
                name: "IX_Organismos_AsociacionId",
                table: "Organismos",
                column: "AsociacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Organismos_Asociaciones_AsociacionId",
                table: "Organismos",
                column: "AsociacionId",
                principalTable: "Asociaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
