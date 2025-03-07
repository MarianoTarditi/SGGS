using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class AuditLogAuthorization : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditLogsAuthorizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogsAuthorizations", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogsAuthorizations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "75fb6a5a-e735-4886-ad79-f5264796a54f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "9f39bb28-8571-4f12-89b6-1e07755167cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "e5208f85-0b1c-4034-89bf-9629fb6069bc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e02e3991-e159-463a-8e25-272c441f8b6e", "AQAAAAIAAYagAAAAEPkizUHPEQCyb4hWeBJvNtGuQzpZJLDr1kZlVmvvxLmWQYHgKktERGDr9XX8Gc0WgQ==", "4880b3c4-7429-4f24-945d-ccad4a7531d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a704ffa8-3cab-49ed-855e-92d291a8b0c0", "AQAAAAIAAYagAAAAEFiU5PexhWGPW2A3aTvevMSVkOvoo6pcQsb7Th432RXEn5pdNgiTFl69EmSvPHdq6A==", "926e57ca-b981-467e-be0d-a34bd1aac024" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "891719e2-8920-4d62-82fc-cec5461c8502", "AQAAAAIAAYagAAAAEA4mSC9ctiv3xC4rDoei2w/O8BNNMBNxBJvyyE39vWQAyBrUr26+dLw7Gf0fcgQLuQ==", "17229781-fcf1-4ad4-905f-c8452add0b05" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1245), new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 4, 16, 11, 48, 829, DateTimeKind.Local).AddTicks(1627));
        }
    }
}
