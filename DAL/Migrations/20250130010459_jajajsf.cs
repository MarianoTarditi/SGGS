using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class jajajsf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deudas_Organismos_OrganismoId",
                table: "Deudas");

            migrationBuilder.DropIndex(
                name: "IX_Deudas_OrganismoId",
                table: "Deudas");

            migrationBuilder.AlterColumn<int>(
                name: "OrganismoId",
                table: "Deudas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_Deudas_OrganismoId",
                table: "Deudas",
                column: "OrganismoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deudas_Organismos_OrganismoId",
                table: "Deudas",
                column: "OrganismoId",
                principalTable: "Organismos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.AlterColumn<int>(
                name: "OrganismoId",
                table: "Deudas",
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
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 29, 16, 55, 4, 152, DateTimeKind.Local).AddTicks(9055));

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
    }
}
