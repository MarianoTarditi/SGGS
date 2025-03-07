using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AuditLogsTable4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Sexos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Resumen");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Religiones");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Recibos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Rama");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Provincias");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "PagoModalidad");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Organismos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Nacionalidades");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Miembros");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Localidades");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Idiomas");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Funciones");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Estudio");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "EstadoCivil");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "EstadoAutorizaciones");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Educadores");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Discapacidades");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Deudas");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "DetallesPagos");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "CategoriaPago");

            migrationBuilder.DropColumn(
                name: "RowVersion",
                table: "AutorizacionesPagos");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "99b2c6dd-6903-4c1f-b511-497ab5ee6967");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "1abb0af3-909e-4b7b-abef-793bb31b0ff1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "d703adb1-d13c-4f2b-9848-c1bb4562f943");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04cf4bc9-e569-4fa1-bcb7-b95849c5328c", "AQAAAAIAAYagAAAAEMrScMk0ogV5tanofJP+xl/otMim1jVvGL1e0gBDyMO/Y1kfAFvDRmyK6LnfeyGpzg==", "6d2c98e4-2d3e-4fa6-b927-c73534491b5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4aebe3e9-7ca6-4269-a0bf-635df5eb0ae2", "AQAAAAIAAYagAAAAEHZSwleoTqM/5DVzdpYK1t5hYONY/q6epenfEw+QCr+o5lcv09ewf1Cv5TKApPRV5w==", "4c2bbb60-1105-4fea-abab-92745dddbe1a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b810bc3f-7b8f-45f0-b516-dc1266913ed0", "AQAAAAIAAYagAAAAEPjgfPXnyPd1rK95K4WxYavzzBnhmczSJQgle941qW4AJT9Iqy1HJoUgFymha329ow==", "1404d44d-8df7-44e9-8f9c-e9a5bd89b15d" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4168), new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 13, 34, 57, 912, DateTimeKind.Local).AddTicks(4562));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Sexos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Resumen",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Religiones",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Recibos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Rama",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Provincias",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Pagos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "PagoModalidad",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Organismos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Nacionalidades",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Miembros",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Localidades",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Idiomas",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Funciones",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Estudio",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "EstadoCivil",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "EstadoAutorizaciones",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Educadores",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Discapacidades",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Deudas",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "DetallesPagos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "Categorias",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "CategoriaPago",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "RowVersion",
                table: "AutorizacionesPagos",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "a14701fd-f9b7-47e8-9117-d222e14af1e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "07c15e87-341d-4ad7-834f-31eed7691fe7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "b358681e-a839-463e-8a08-5f091ce336f9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dd4c267-f357-4ec2-bd95-d4457bf4316b", "AQAAAAIAAYagAAAAEICWCvAf8Pug9PLiKBEJZsBHWrXl5XQL5M0/tVyowZ4DYdfYsLTS93UaFp5NbFMEjg==", "39010e52-78c2-410a-bd28-71a563f45efb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40c6b775-82d3-4ea5-bc9c-ddcaecd4057b", "AQAAAAIAAYagAAAAEKydGRTwQjZse7ubC1PY59jAgcAngC8mX40h2YssyEhLe4zSKgj3hDkitJyoJjqbXw==", "a117954d-2be4-40f1-a171-46e537c5a589" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7fb93b8-7542-4405-bade-757221cdc930", "AQAAAAIAAYagAAAAEMHGBFkLp+eSp5J8ADd20RVRcMvjUhYylgg7ZBA33sO8ZjAtP0PpwY47VXIHl1lyoA==", "f7d203f7-18cd-46be-8252-edb19ac707a9" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(1842), new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 13, 28, 53, 33, DateTimeKind.Local).AddTicks(2092));
        }
    }
}
