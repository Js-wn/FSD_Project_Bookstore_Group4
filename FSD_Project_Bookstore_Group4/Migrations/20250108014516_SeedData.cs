using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 45, 15, 238, DateTimeKind.Local).AddTicks(6924), new DateTime(2025, 1, 8, 9, 45, 15, 238, DateTimeKind.Local).AddTicks(6935) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 45, 6, 801, DateTimeKind.Local).AddTicks(7562), new DateTime(2025, 1, 8, 9, 45, 6, 801, DateTimeKind.Local).AddTicks(7576) });
        }
    }
}
