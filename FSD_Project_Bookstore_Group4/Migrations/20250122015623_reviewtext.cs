using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class reviewtext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReviewTest",
                table: "Review",
                newName: "ReviewText");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ed29e83-c6b5-4f56-b1f7-7c237f0e3a20", "AQAAAAIAAYagAAAAEEXVW/7Qh2hRodWX5/UT2SoV/+1ZX+IC+B+i50x1MdQz5hZ6walsGK/68mUp0XaCJg==", "5a61d292-d270-4f76-9961-942c7738f24b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c323f38c-edb4-4981-9be2-20bd82342cd9", "AQAAAAIAAYagAAAAEHcJN+2/9ztZNMj8EjMO4ozCHqwsdY8f6Efy6On9fysbAeBlsY+j3aCtbg3MCLNMOQ==", "bc2dbede-0626-4b7c-9e99-b0d0782a6403" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 353, DateTimeKind.Local).AddTicks(351), new DateTime(2025, 1, 22, 9, 56, 22, 353, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 353, DateTimeKind.Local).AddTicks(376), new DateTime(2025, 1, 22, 9, 56, 22, 353, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(699), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(708), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "BookAurthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 354, DateTimeKind.Local).AddTicks(759), new DateTime(2025, 1, 22, 9, 56, 22, 354, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "BookAurthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 354, DateTimeKind.Local).AddTicks(765), new DateTime(2025, 1, 22, 9, 56, 22, 354, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(902), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(905), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(416), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(439), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(442), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerId",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "ReviewText",
                table: "Review",
                newName: "ReviewTest");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c55ff1d-72d6-47c1-9728-19ce3919e9a0", "AQAAAAIAAYagAAAAEDBihIV+yRqQ3ccYdO2utAY/+iEXBfW+aLyoHtHWvhg2CMvciNFyMPX+X+jZFC/Jmw==", "eab559ba-3faa-4907-8ade-4576c45041c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6aa26f2e-c25f-481e-8037-728e2e95d20b", "AQAAAAIAAYagAAAAEJDkxLUMpi9KTUgLnd2Pc+mzhK3Mulz4jtBGyyz7t6gyfVJHpt5qeajla0VSJDuqYw==", "dbbad9c8-855c-4a4d-985f-f9376b5b5d34" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 436, DateTimeKind.Local).AddTicks(3042), new DateTime(2025, 1, 22, 9, 46, 36, 436, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 436, DateTimeKind.Local).AddTicks(3063), new DateTime(2025, 1, 22, 9, 46, 36, 436, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9366), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9374), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "BookAurthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 442, DateTimeKind.Local).AddTicks(6777), new DateTime(2025, 1, 22, 9, 46, 36, 442, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "BookAurthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 442, DateTimeKind.Local).AddTicks(6799), new DateTime(2025, 1, 22, 9, 46, 36, 442, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9476), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9479), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9108), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9122), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9125), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9126) });
        }
    }
}
