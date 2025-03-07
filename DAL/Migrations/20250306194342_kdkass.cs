using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class kdkass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogsAuthorizations");

            migrationBuilder.CreateTable(
                name: "AuditLogsAuthentications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SessionDuration = table.Column<TimeSpan>(type: "time", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLogsAuthentications", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLogsAuthentications");

            migrationBuilder.CreateTable(
                name: "AuditLogsAuthorizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionDuration = table.Column<TimeSpan>(type: "time", nullable: true),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                value: "611c315a-eb10-4b11-a37d-e3f7c17d7513");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a086370d-a143-42d2-ad86-1d32eb9e7546",
                column: "ConcurrencyStamp",
                value: "8f44e13c-31d3-4b71-9429-3682087797ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "affedc34-9713-423a-880e-4a61ceefb7b1",
                column: "ConcurrencyStamp",
                value: "2695573c-731b-4511-ac1d-e2e818cde83f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070a9212-d4a9-44da-8479-4ec813b63621",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0640b2b1-4489-47f6-bebc-487229de0338", "AQAAAAIAAYagAAAAEBcawnOhLXxYIeJiBRXGc6fB0hOV1/BCTgsh/FjBo/800x3v2LhwNJTK1AqGYybqEA==", "25cf6a20-9394-4d3e-8545-a48ea112d0b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b0e483c-ebae-4ed3-827e-8ed27f7d9131",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce795105-9508-4b82-be7f-8ea457e8a4bc", "AQAAAAIAAYagAAAAEHwWv2NbCNHEofuSXlsv1u9CjdRdwnVsiT2s6ZfTKNsbN0M8wBmrdASJSbpRxj3d+A==", "a5d0c50d-3262-48c0-9dab-18b8c76726e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f906a15b-50f8-4e47-b44f-df9ac87dee9a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d245b1bd-5e39-434a-b08c-a1eb4959b4c2", "AQAAAAIAAYagAAAAEO2FOluTyiypUm2Vj+oJXP2alOf/5hXCmARlWXPlHMx6JhXP0/DSZhXtYUrN6ISVNQ==", "3508fdd1-86a0-47e4-8cbc-94dd2a965d16" });

            migrationBuilder.UpdateData(
                table: "AutorizacionesPagos",
                keyColumn: "Id",
                keyValue: 1122,
                column: "Fecha",
                value: new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Deudas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaCreacion", "FechaVencimiento" },
                values: new object[] { new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1203), new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1191) });

            migrationBuilder.UpdateData(
                table: "Miembros",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaNacimiento",
                value: new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Organismos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaCreacion",
                value: new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "PagoModalidad",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaDePago",
                value: new DateTime(2025, 3, 6, 15, 58, 55, 618, DateTimeKind.Local).AddTicks(1587));
        }
    }
}
