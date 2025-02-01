using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class addedCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsInCart",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69b24a49-8c09-4780-a15d-88739b252b35", "AQAAAAIAAYagAAAAECKe64ONar/JM0XFkPKS+hBQ6xGQsdXMw0PlGGtKUr31/lqLBc+YmRJagqFr0m4umw==", "320e40d0-cdad-4cc1-8cd6-7c3716592a1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ba3b6f0-a7b0-45d3-8d62-005846c1bec2", "AQAAAAIAAYagAAAAEPp/gz5bQBOXA4lk+Tljkz5zcTdzBkI1u05PH3DmJTaLa8kjryQO1up9uOYHf1lkzA==", "264f8d09-f722-478f-9569-99062b931bfc" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 15, DateTimeKind.Local).AddTicks(9863), new DateTime(2025, 2, 1, 10, 55, 55, 15, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 15, DateTimeKind.Local).AddTicks(9873), new DateTime(2025, 2, 1, 10, 55, 55, 15, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8285), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8298), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8300), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(36), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(159), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(606), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(609), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(611), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(614), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(617), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(619), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(621), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(624), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(626), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(628), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(631), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(633), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8419), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8426), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(394), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(397), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(399), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(401), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(403), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(406), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(408), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(410), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(412), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(414), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(417), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(7999), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8008), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8011), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8011) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInCart",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9829adf5-c845-4583-8ee2-5da8b3d66f8c", "AQAAAAIAAYagAAAAEORQx3fm94sDTrBo4iOCt90KgSjSETV+Gt4idaH1eD/a/zGgYgi+CupfkLHSy5QErQ==", "bcd30926-b73b-4b2e-85cf-ad9166ee84e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bea4522-a6a0-4f43-8841-290b2588427f", "AQAAAAIAAYagAAAAEM/NNBybMno4GUDhNfdWmauL0kDnGhMz3WibBf4lBPIHXTWRCxXehDLVDT/0YEwTnw==", "af840481-e4ae-4293-a139-b0f51ca9b3c9" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(2866), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(2866) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(2872), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3374), new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3381), new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3384), new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(2983), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(2987), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3303), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3306), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3307), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3309), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3311), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3313), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3314), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3316), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3318), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3319), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3321), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3323), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3462), new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3465), new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3101), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3103), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3106), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3107), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3109), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3111), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3138), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3138) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3140), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3141), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3208), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3210), new DateTime(2025, 1, 30, 15, 16, 48, 286, DateTimeKind.Local).AddTicks(3210) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3189), new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3194), new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3197), new DateTime(2025, 1, 30, 15, 16, 48, 154, DateTimeKind.Local).AddTicks(3197) });
        }
    }
}
