using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class GenderSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "724896b7-f634-4ee5-9563-58d4d7899fb4", "AQAAAAIAAYagAAAAEJ1KXzy7mMq1ykCy8IUI0o6kgTljRhJQZ5ahkl5S+39UC3XbiA72gshg/2nwmNCTDw==", "e8a341fb-2134-4b92-939e-e089332c3372" });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "DateCreated", "DateUpdate", "GenderName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 8, 10, 20, 29, 720, DateTimeKind.Local).AddTicks(6235), new DateTime(2025, 1, 8, 10, 20, 29, 720, DateTimeKind.Local).AddTicks(6236), "Male" },
                    { 2, new DateTime(2025, 1, 8, 10, 20, 29, 720, DateTimeKind.Local).AddTicks(6238), new DateTime(2025, 1, 8, 10, 20, 29, 720, DateTimeKind.Local).AddTicks(6238), "Female" }
                });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 8, 10, 20, 29, 720, DateTimeKind.Local).AddTicks(6013), new DateTime(2025, 1, 8, 10, 20, 29, 720, DateTimeKind.Local).AddTicks(6023) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a9d2268-1286-45dd-9075-7bbcc91110da", "AQAAAAIAAYagAAAAEH7BNXzktaviSMN4ZW+QY9sl+xM4qsd9q82/rxv+7u8n6Ik3JKCzbUVcISnOhccnDg==", "0695a41d-8b6f-4bf0-8619-7ed2c2812ee0" });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 8, 10, 18, 58, 367, DateTimeKind.Local).AddTicks(1613), new DateTime(2025, 1, 8, 10, 18, 58, 367, DateTimeKind.Local).AddTicks(1623) });
        }
    }
}
