using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class GenderSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9ca89ad-802c-4e46-a009-d2dce3a3b027", "AQAAAAIAAYagAAAAELM4dETKkuYqG0Jzz5RGgSXmSBw34DajDNRZanx7JoOdKzCXXA9witrfRhcUUJljlw==", "5376286e-973a-4db5-819f-4587fb1fb16b" });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 8, 9, 48, 46, 626, DateTimeKind.Local).AddTicks(1220), new DateTime(2025, 1, 8, 9, 48, 46, 626, DateTimeKind.Local).AddTicks(1233) });
        }
    }
}
