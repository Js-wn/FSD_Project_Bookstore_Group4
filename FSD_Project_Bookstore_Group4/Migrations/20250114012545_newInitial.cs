using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class newInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GenderId",
                table: "Gender",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08a29d0a-d2d2-4e51-952e-2d8ba2865a2c", "AQAAAAIAAYagAAAAEMgpTePbUMW5//GeBxb6laI5JpJAglm6V+Azmp9MEb8VFsbcrOV6V8pNckCPJpc3oA==", "cdd4e724-5653-4218-b978-79f82e8e31b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3889eb7e-5ac4-4f03-95a8-e98660a50487", "AQAAAAIAAYagAAAAENtLPyCzAS5cHcDLWbAD4zL+/GM91hytkEVCCxXsHaOGB5NcqIcu18AeFqbOU1F2kg==", "24ed78f4-844c-4887-96ef-de3cfe7514ea" });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate", "GenderId" },
                values: new object[] { new DateTime(2025, 1, 14, 9, 25, 44, 590, DateTimeKind.Local).AddTicks(4808), new DateTime(2025, 1, 14, 9, 25, 44, 590, DateTimeKind.Local).AddTicks(4809), 0 });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate", "GenderId" },
                values: new object[] { new DateTime(2025, 1, 14, 9, 25, 44, 590, DateTimeKind.Local).AddTicks(4811), new DateTime(2025, 1, 14, 9, 25, 44, 590, DateTimeKind.Local).AddTicks(4812), 0 });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 9, 25, 44, 590, DateTimeKind.Local).AddTicks(4340), new DateTime(2025, 1, 14, 9, 25, 44, 590, DateTimeKind.Local).AddTicks(4358) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderId",
                table: "Gender");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc26d72f-157b-465b-9659-9aa22c0538dd", "AQAAAAIAAYagAAAAEE/pvzA3dMZWU/i59iaraUrlqEUGllaK/MjXjUDSAEU7D2sFUrSR9lRZk/bvuNXwqA==", "1e691eb1-d26c-4caa-95dc-d5ec4e904b72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5ac4dd8-2fea-4ea3-9f81-e1ad89e7463c", "AQAAAAIAAYagAAAAEBOAgVPp2ey9ctPEDI+x4iIVuj1Pp03h7ZdfWwqJTHZq7DnE1hhkHqNKDiw7ZNbKtA==", "c3f8866c-fc6d-4abf-a964-40866050f032" });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 11, 50, 9, 465, DateTimeKind.Local).AddTicks(7311), new DateTime(2025, 1, 10, 11, 50, 9, 465, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 11, 50, 9, 465, DateTimeKind.Local).AddTicks(7314), new DateTime(2025, 1, 10, 11, 50, 9, 465, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 11, 50, 9, 465, DateTimeKind.Local).AddTicks(7025), new DateTime(2025, 1, 10, 11, 50, 9, 465, DateTimeKind.Local).AddTicks(7035) });
        }
    }
}
