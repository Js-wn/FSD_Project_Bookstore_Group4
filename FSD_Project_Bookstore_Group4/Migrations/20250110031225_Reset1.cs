using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class Reset1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8536c1c-24cc-4a75-ba04-3667fcab62e3", "AQAAAAIAAYagAAAAEGdznNfLffYXRLICFuiY65qRmXtvgbiw2L5t4eXvBosGjReLpOb03Ak0b6UabYhbDQ==", "ce5f70ed-823e-491c-94a6-410725228b13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cfa437d-d8f1-483a-99bb-436e928689e9", "AQAAAAIAAYagAAAAEHE/seotlSVUOARsJAn4tCQHk2N6vdw+AGA4mR4GVd/RpCKfjdMtyrCGDBpazZ7dpw==", "fd6510ae-ec8e-4fa2-9922-11075d591eb3" });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 11, 12, 24, 628, DateTimeKind.Local).AddTicks(4619), new DateTime(2025, 1, 10, 11, 12, 24, 628, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 11, 12, 24, 628, DateTimeKind.Local).AddTicks(4623), new DateTime(2025, 1, 10, 11, 12, 24, 628, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 11, 12, 24, 628, DateTimeKind.Local).AddTicks(4373), new DateTime(2025, 1, 10, 11, 12, 24, 628, DateTimeKind.Local).AddTicks(4384) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
