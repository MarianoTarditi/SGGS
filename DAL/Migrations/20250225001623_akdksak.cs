using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class akdksak : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "f5b70fd3-85e9-4b63-a036-746879b93937");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "4c4d58a0-8aea-40d8-9f8c-d68226aae822");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "d68c4f08-c46f-49da-9717-e2aba87d82b3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34d39f44-2f9e-43c0-9a6d-ced0c62094c6", "AQAAAAIAAYagAAAAEGVXK4SLfHEJ28vYgBhbnZ49tj9evZy7iUzg5OcPgpSUA9EkBCWC3m3Y43jmsD3ITg==", "9282c43f-016f-4be6-9bf9-582833110610" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1667daee-f3c5-4c55-9187-6c15d5283006", "AQAAAAIAAYagAAAAEOtLySZprgKTmKT+FoYLWs3EOfZdFrqoYxelPO1t8N/g1bnEMN7HPNowBlqKl5PYyg==", "95b9c927-e0f8-48be-a703-eb0ec0a4e156" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "255ec2e4-e0b2-465f-9eb6-8f5a9a25711b", "AQAAAAIAAYagAAAAED/wmRvg4QcqJJmlr0PeY46bxO1T4m3txCg7j++iWIciV8OcmQjn5SrfjyBCfDvnqw==", "ecf9c1ef-17f8-4c55-930a-a1bc83f76f01" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7039), new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 24, 21, 16, 21, 655, DateTimeKind.Local).AddTicks(7568));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "821ddb95-e6e1-41a7-b8b9-6354f47b1ac6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "5d49039a-1624-420a-b7d2-71c5295c2aad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "2bef322a-0f59-4187-b978-10b3b1795dc6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eecf1667-2514-4a2f-b7dd-16a63abf5bee", "AQAAAAIAAYagAAAAEE17r1YefSqe7n6MkHLycHjOfUuxwewV8gtCOkQaTnFUkuV6xXSIzoUvZccRWdocPg==", "b206557a-8ab6-4902-9857-ac458377de56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbfac2c4-9169-44b5-8ca9-7ceef7724b79", "AQAAAAIAAYagAAAAEOqLgSv2vDAy99nDfsFUwJnnb9pmrZ1Efmehh0H0FtqLUzJ8byu6426OTxCb3kj+Cw==", "be645ff4-2320-4ff0-b8d0-c1b85b153d7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85ecd9ed-0ec1-4e6b-8b42-19146ff1b476", "AQAAAAIAAYagAAAAEAovA3LwG3JXnaAgzCxOB4bk2WA/1fBDu2rRhX+yj2JlnuQdX/cjLhYWirFFw5pdZA==", "c0a29870-461b-4eb5-949b-ec1bf96d8292" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 2, 21, 16, 38, 57, 869, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 38, 57, 869, DateTimeKind.Local).AddTicks(506), new DateTime(2025, 2, 21, 16, 38, 57, 869, DateTimeKind.Local).AddTicks(499) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 2, 21, 16, 38, 57, 869, DateTimeKind.Local).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 2, 21, 16, 38, 57, 869, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 2, 21, 16, 38, 57, 869, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Recibos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2025, 2, 21, 16, 38, 57, 869, DateTimeKind.Local).AddTicks(777));
        }
    }
}
