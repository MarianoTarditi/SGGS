using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class aksdsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "ef2b2cdb-9ac7-4b11-8e73-719f12fcea03");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "58382c93-b088-405d-87ba-dcb846285a78");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "d84bba56-6138-4e6f-8475-6041e15fa44a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6ec2373-1f6e-466d-8a22-fd7fa5ea28bf", "AQAAAAIAAYagAAAAENUga5dLNGE97Fcczp/2Ro9WvJ8o4u+mJazHZ0KOwJKT19UFX6uxtoZguhx0eKpjYA==", "7dd3d6b9-9e41-4083-8928-42de4a6fd417" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0ddc17d-c581-4622-a2de-46a6f8404fe6", "AQAAAAIAAYagAAAAECcrFivHciwRDgvqbJxDL7ERpMQqW+3Ijs0G6DmdHvtKjqkPljmhkyEtFAJmyIbV9g==", "163a9568-e861-4b22-9cdb-fa0a35eb3a93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aed568a0-2051-4169-9c83-b00c468652ef", "AQAAAAIAAYagAAAAEETpZUNxO+C6ojjk6KJKgLa0uRczDZm8WUvk66/lU6UMw5SWI2+eGatcVnnCSNJ3vA==", "553060fb-d4e9-4cbf-976d-8034786bbe02" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 9, 21, 5, 54, 897, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 9, 21, 5, 54, 897, DateTimeKind.Local).AddTicks(7339), new DateTime(2025, 3, 9, 21, 5, 54, 897, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 9, 21, 5, 54, 897, DateTimeKind.Local).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 9, 21, 5, 54, 897, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 9, 21, 5, 54, 897, DateTimeKind.Local).AddTicks(7861));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b67832b-7091-48e8-aa0a-f1b3baeca418",
                column: "ConcurrencyStamp",
                value: "1e26ff29-202a-479a-a243-e0559b3b1124");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "39b141d2-3429-4c14-91c2-8e9e9af7b1d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "45925e92-1293-4d35-964c-125619b8f5c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff470b5-130d-4f4d-b676-b0ffab4026b9", "AQAAAAIAAYagAAAAEI689wMbu8KunWcCKKGx/4y3iiM+6qlHJ26aYjum88jf8grVkaQKmP0BO/pvknnK9A==", "877cb63d-ada6-4b0f-bd87-da2bbfff0f32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "129758b6-fb14-4a31-988a-a70e3e874b2d", "AQAAAAIAAYagAAAAEOvNBnr4wq89RT+eInkGqVHXdXObrgjS2HhaXM4OjhV2+FqdV4Lja5Fc3/giggUzTA==", "2d9cbaba-6bd9-4df2-ac3b-2b4c8622953a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1856613d-740d-4a9e-aee7-4548d92b42a5", "AQAAAAIAAYagAAAAEE4ltPWwLa0jmqgQ1E7/udsPugSCvlmO0H/FaFnaVWf9iluJ6aSAHSseT/aGyHK0XA==", "a6ca75b8-4649-4914-8b9d-c3d8d0f0bb0d" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 6, 16, 43, 41, 60, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 6, 16, 43, 41, 60, DateTimeKind.Local).AddTicks(6742), new DateTime(2025, 3, 6, 16, 43, 41, 60, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 6, 16, 43, 41, 60, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 6, 16, 43, 41, 60, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 6, 16, 43, 41, 60, DateTimeKind.Local).AddTicks(7292));
        }
    }
}
