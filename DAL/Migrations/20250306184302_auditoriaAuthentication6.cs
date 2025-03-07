using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class auditoriaAuthentication6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EntityId",
                table: "AuditsLogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "59456a29-d930-4a31-84f1-f35de1fff0f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "f41f1286-d6c9-4db3-aef8-ca025870caac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "680afcd0-6941-40b5-9016-aaefe57e17a6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7371565d-d33a-446b-ba5c-803b385a9895", "AQAAAAIAAYagAAAAELc4Z6kQi5+L2NpwWrvE7h5e3FG3/cNcXI8XhbQ+073WX+ucTgLEKtCykhP9MSCyNw==", "14945a8e-116f-4195-8920-c28d62780828" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52ab1e9e-9aa3-42ac-8523-8361799a160a", "AQAAAAIAAYagAAAAEHSeE92lbyHeECTl75VRgu03EKpAdFyO7xFsM2dyLZ+h/sd8NMgXSVjhOzu9XUE94A==", "e02183a7-fb3c-4e47-90a8-9c0063807261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11e1c76a-ea35-4b84-8061-c6023d0ece82", "AQAAAAIAAYagAAAAEBnWBWTgkyeemUVrwcmazrTIASxU2ggACrkHiwnDirvIpe3lCpgsdvsJ8CscVtDWbQ==", "8da7330c-593d-489c-a0fd-2a8869f7c81e" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2054), new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2133));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 6, 15, 43, 1, 112, DateTimeKind.Local).AddTicks(2462));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EntityId",
                table: "AuditsLogs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "0c57bb45-12b4-4514-8b2c-aaa393b8fdb6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "3343e242-b0c6-4c97-9320-54b5c693ba8f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "4e4f84b2-d34a-452e-833e-249c9ec7c47f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "861ff36d-32e1-438f-b567-67f716160376", "AQAAAAIAAYagAAAAEDUqwBNGIz4VftesoVFW6bCLbYFyqZRy5m1U/2ZdBVFeKf6ho0Z4HONGYA/Vnc96Ww==", "5fa82dd9-5276-4cab-a551-1a138f880d10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb7567aa-ac0e-4643-9926-d51196a13890", "AQAAAAIAAYagAAAAEN60wa/XkevH5Lrt/i0cKxMfwJcpqJ11MQkHomIkp3uMqTBysDxifcreYa2x1OmmxQ==", "e23ffb7e-5783-4d4f-b410-9f1e6c5b1a7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cb1f594-43e8-4989-a498-8e84fe1061a0", "AQAAAAIAAYagAAAAEOuAj+qFc/Oj/ceB/ZypRovqfJOhAkxVZrY6bxgezZhDXleUGkTewa0lLqmePG11CA==", "5aa27820-b71f-495f-b932-954eab030ffd" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 5, 17, 19, 55, 260, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 5, 17, 19, 55, 260, DateTimeKind.Local).AddTicks(7561), new DateTime(2025, 3, 5, 17, 19, 55, 260, DateTimeKind.Local).AddTicks(7526) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 5, 17, 19, 55, 260, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 5, 17, 19, 55, 260, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 5, 17, 19, 55, 260, DateTimeKind.Local).AddTicks(8008));
        }
    }
}
