using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class UserSeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "5436aeb6-34ac-90f0-860f-e446d23252e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "926a23d5-3fc7-4216-9ab1-c6f4335a9e84", "AQAAAAIAAYagAAAAELz5RkmEH6UU9/9Jxzlc5ubnGB/EpUPdjUVICoz5+bnqtGUTqoQWoAfwxLy4R4CZug==", "5b6ba943-5a4f-423b-9ec2-552891c5e8f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e771978d-1a64-4ae9-8a52-3255f73fa135", "AQAAAAIAAYagAAAAEAC33POfK2DPX5WMjnKiCQUHqscCg8e4wZGTMUYWg7iOxJR5t8nk8vPJ3zBMtrFN0Q==", "6814cfc5-6042-40fb-8190-b1facd3524de" });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 10, 39, 26, 784, DateTimeKind.Local).AddTicks(3316), new DateTime(2025, 1, 10, 10, 39, 26, 784, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 10, 39, 26, 784, DateTimeKind.Local).AddTicks(3319), new DateTime(2025, 1, 10, 10, 39, 26, 784, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 10, 39, 26, 784, DateTimeKind.Local).AddTicks(3082), new DateTime(2025, 1, 10, 10, 39, 26, 784, DateTimeKind.Local).AddTicks(3093) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "5436aeb6-34ac-90f0-860f-e446d23252e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f5e766f-4760-4313-ac88-f15d79ad2b1e", "AQAAAAIAAYagAAAAEGGX/OIhAuw7l2S7WknCRYoXeyydq/8TSl5RTw2AYtm1uzrgdKo0rAnu3krLv7m+UQ==", "baf9b4e3-e2aa-4c5b-8814-adb3283f964f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "771531be-cfca-4494-96d3-61e1ccb7646b", "AQAAAAIAAYagAAAAEFcAhvWD28bf86AoQqKhfHIrTNnYz7P0ml69PY71/qWTiM3sDaeaBdbY3SX3ScB7XA==", "302784f6-04fa-4734-8d79-ae7ba3ead872" });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 10, 5, 31, 868, DateTimeKind.Local).AddTicks(6900), new DateTime(2025, 1, 10, 10, 5, 31, 868, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 10, 5, 31, 868, DateTimeKind.Local).AddTicks(6904), new DateTime(2025, 1, 10, 10, 5, 31, 868, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 10, 5, 31, 868, DateTimeKind.Local).AddTicks(6667), new DateTime(2025, 1, 10, 10, 5, 31, 868, DateTimeKind.Local).AddTicks(6686) });
        }
    }
}
