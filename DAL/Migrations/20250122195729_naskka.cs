using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class naskka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacionesEventos_Eventos_EventoId",
                table: "AutorizacionesEventos");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacionesPagos_Pagos_PagoId",
                table: "AutorizacionesPagos");

            migrationBuilder.DropIndex(
                name: "IX_AutorizacionesPagos_PagoId",
                table: "AutorizacionesPagos");

            migrationBuilder.DropIndex(
                name: "IX_AutorizacionesEventos_EventoId",
                table: "AutorizacionesEventos");

            migrationBuilder.DeleteData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DropColumn(
                name: "PagoId",
                table: "AutorizacionesPagos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AutorizacionesPagos");

            migrationBuilder.DropColumn(
                name: "EventoId",
                table: "AutorizacionesEventos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "AutorizacionesEventos");

            migrationBuilder.AddColumn<int>(
                name: "AutorizacionId",
                table: "Eventos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "AutorizacionesPagos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Observacion",
                table: "AutorizacionesPagos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "AutorizacionesEventos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "AutorizacionesEventos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Observacion",
                table: "AutorizacionesEventos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "AutorizacionesEventos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedDate",
                table: "AutorizacionesEventos",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "28b45fc0-1158-4a6d-986e-4ec1069b4635");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "bd38ac23-c149-4153-bedb-59f3f86d1472");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "063b661a-7149-4374-a42a-a4517a8389bd", "AQAAAAIAAYagAAAAEMQJtDqK4MBMu9ix7iOFU5Mr43B9gSCM/Lqm9W0bpc2Wd6yXh2B9Ifa/nrim8jQCCw==", "61519d6d-5456-405d-ad9d-368ed1dced78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "648ae05a-97d7-4810-ba97-1bbd3984676e", "AQAAAAIAAYagAAAAEAXed6jdaJ/y3wKcvbtAkkfbVfO/iGUAiDWr96SGg3O2c8+SEKG++J0HHLbz9IH+BQ==", "5fcf1d70-29f9-4701-aead-ee47ad042ba0" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Autorizado", "CreatedDate", "Estado", "Fecha", "Observacion", "UpdatedDate" },
                values: new object[] { true, "05/05/2025", "Aprobado", new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(44), "Evento Autorizado con exito", null });

            migrationBuilder.InsertData(
                table: "AutorizacionesPagos",
                columns: new[] { "Id", "Autorizado", "CreatedDate", "Estado", "Fecha", "Observacion", "UpdatedDate" },
                values: new object[] { 1, true, "05/05/2025", "Aprobado", new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(77), "Pago Autorizado con exito", null });

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AsociacionId", "FechaVencimiento" },
                values: new object[] { 1, new DateTime(2025, 1, 22, 16, 57, 29, 80, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AutorizacionId", "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { 1, new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(866), new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(867), new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(869), new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(871), new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 22, 16, 57, 29, 81, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_AutorizacionId",
                table: "Eventos",
                column: "AutorizacionId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_AutorizacionesEventos_AutorizacionId",
                table: "Eventos",
                column: "AutorizacionId",
                principalTable: "AutorizacionesEventos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_AutorizacionesEventos_AutorizacionId",
                table: "Eventos");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_AutorizacionId",
                table: "Eventos");

            migrationBuilder.DeleteData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "AutorizacionId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "AutorizacionesPagos");

            migrationBuilder.DropColumn(
                name: "Observacion",
                table: "AutorizacionesPagos");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AutorizacionesEventos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "AutorizacionesEventos");

            migrationBuilder.DropColumn(
                name: "Observacion",
                table: "AutorizacionesEventos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "AutorizacionesEventos");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AutorizacionesEventos");

            migrationBuilder.AddColumn<int>(
                name: "PagoId",
                table: "AutorizacionesPagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "AutorizacionesPagos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EventoId",
                table: "AutorizacionesEventos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "AutorizacionesEventos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "a034b5fc-5c85-412b-a701-5abae635e834");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "eac3d198-cfb6-48e2-aae5-c2b53a4b0d72");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f54d4ea7-0ff1-4cb2-b683-46c6a5e8c3c3", "AQAAAAIAAYagAAAAEA+TSTdmoOqPjwWTWCpegV/vHpGmohltvC4Fp+cGqveIgjp/ppN9Ihu223NYrSu6PA==", "0fec9662-2d68-4de7-af8b-4de4be6f21e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c7f45c0-c8fe-4967-ba24-2ba117cd6d3f", "AQAAAAIAAYagAAAAEBuHAuKogH2wYIzSuu5NsU0x3VHw/KbNp6YSsuPIB1+bKhSOnGHiEyNpj/m5y/bFLg==", "4b55bf3e-e154-4a24-8e77-8f1ab7d4e0cb" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesEventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Autorizado", "EventoId", "Fecha", "UsuarioId" },
                values: new object[] { false, 1, new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(124), 1 });

            migrationBuilder.InsertData(
                table: "AutorizacionesPagos",
                columns: new[] { "Id", "Autorizado", "CreatedDate", "Fecha", "PagoId", "UpdatedDate", "UsuarioId" },
                values: new object[] { 1096, false, "05/05/2025", new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(146), 1, null, 1 });

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AsociacionId", "FechaVencimiento" },
                values: new object[] { 0, new DateTime(2025, 1, 20, 15, 20, 18, 549, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Fecha", "FechaLlegada", "FechaSalida", "HoraLlegada", "HoraSalida" },
                values: new object[] { new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(391), new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(392), new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(394), new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(394), new DateTime(2025, 1, 20, 15, 20, 18, 550, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 1, 20, 15, 20, 18, 549, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 1, 20, 15, 20, 18, 549, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 1, 20, 15, 20, 18, 549, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 1, 20, 15, 20, 18, 549, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesPagos_PagoId",
                table: "AutorizacionesPagos",
                column: "PagoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesEventos_EventoId",
                table: "AutorizacionesEventos",
                column: "EventoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacionesEventos_Eventos_EventoId",
                table: "AutorizacionesEventos",
                column: "EventoId",
                principalTable: "Eventos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacionesPagos_Pagos_PagoId",
                table: "AutorizacionesPagos",
                column: "PagoId",
                principalTable: "Pagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
