using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AuditLogAuthorization2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "AuditLogsAuthorizations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "AuditLogsAuthorizations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "c4de60be-0d29-4d2d-a470-b794d85ab888");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "0f699f9c-2c86-4164-8d0a-c63b13f91ed8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "eda01df3-f6c6-4d04-9360-0333294248c8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fc9212d-d2e7-43ad-8909-12c8acb37c5a", "AQAAAAIAAYagAAAAEGHP2MMh4HDzwhvQ3pc9uBYlOdmb459McJioVkjSjx2riPAnlvQyzTKRNoxVD12uDA==", "6722a8e5-9419-4fc6-8301-ecbfca449820" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f38f3c74-5464-47a7-a692-6579680e770a", "AQAAAAIAAYagAAAAEB+Wjt4J9lZOhexczLykWauFTcgJ0hEtYfQBe+7crd3M0TdyBHE1mO6EN4mwcgWofw==", "632ca469-c1de-41ff-a4f6-0d47e0d994d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2641d68a-b946-4bea-9516-2e9939971467", "AQAAAAIAAYagAAAAEKBs6nkodn2vO4CzMxrAmsSkgDaOJ9hhhnkoTF5nblRBZNzev3Nq0oQhuJkdpMe8nQ==", "88cdac7a-8274-4529-95d1-9b3a67b137ec" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 5, 16, 54, 21, 749, DateTimeKind.Local).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 5, 16, 54, 21, 749, DateTimeKind.Local).AddTicks(1168), new DateTime(2025, 3, 5, 16, 54, 21, 749, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 5, 16, 54, 21, 749, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 5, 16, 54, 21, 749, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 5, 16, 54, 21, 749, DateTimeKind.Local).AddTicks(1626));
        }
    }
}
