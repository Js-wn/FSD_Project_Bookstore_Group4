using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class UserSeed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cebc825b-83a6-46ed-8188-8ee16a9b8a06", "AQAAAAIAAYagAAAAEK+EBpATWr4/HzknKZ88obp+ZOFe2gUNmlnX0FDYh8ZkDg6eojTF/ge4wiBUwIbGvg==", "c492ac92-2989-49dc-97c8-4765d554ec03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24a0b6c6-c882-49c3-a2a1-effc42d8cd55", "AQAAAAIAAYagAAAAEOa27mtbmJW/+cink9DSGVi5EEZr3irdSvGrIjVrx3jKT5NXS3qqmQj3TsP7aqm0ng==", "f3919936-24cf-492d-ab2a-638f1dea6a2f" });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 10, 39, 55, 104, DateTimeKind.Local).AddTicks(2316), new DateTime(2025, 1, 10, 10, 39, 55, 104, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 10, 39, 55, 104, DateTimeKind.Local).AddTicks(2319), new DateTime(2025, 1, 10, 10, 39, 55, 104, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 10, 39, 55, 104, DateTimeKind.Local).AddTicks(2079), new DateTime(2025, 1, 10, 10, 39, 55, 104, DateTimeKind.Local).AddTicks(2089) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
