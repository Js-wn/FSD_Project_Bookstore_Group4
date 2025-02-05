using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class bkauge_icollecRemov : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ead99a0-18c8-4a71-9811-37d4020ee1d1", "AQAAAAIAAYagAAAAEEAykXmg91gY4NGqJFT6NxS5vFJpvAfS7R2w06MreV71fpJugY94hjTuBfxVhM4YCA==", "be83d4b1-0d15-4a35-98ca-53753c3d8086" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02da9630-85ca-4a1d-82f9-7b03ec6a7b4c", "AQAAAAIAAYagAAAAEEDkaAeDqeitsUdGEpE+LK3ja+B4XJRtHY1AF+xI7xiZqTC1+cAz12d3smEKdl+WBw==", "cf31cf93-a9a9-4995-93e3-ba522008691e" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(8797), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(8804), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9420), new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9427), new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9427) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9430), new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9430) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(8977), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(8981), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9341), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9345), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9347), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9350), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9352), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9355), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9358), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9360), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9363), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9363) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9365), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9368), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9368) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9370), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9543), new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9547), new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9547) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9137), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9138) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9140), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9143), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9145), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9147), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9150), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9162) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9173), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9176), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9178), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9179) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9180), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9183), new DateTime(2025, 2, 5, 9, 1, 24, 543, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9143), new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9148), new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9151), new DateTime(2025, 2, 5, 9, 1, 24, 352, DateTimeKind.Local).AddTicks(9151) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f4c38da-3464-412f-9296-2c2d018d2bf4", "AQAAAAIAAYagAAAAELUG1Qth5SmC3SzuN3vaEqFKKmhOvcnXlAb0f5lUiVhBWRPPpALeFZfX6jXmUX95Qg==", "0dcf73d7-16b7-4afe-b31a-bc35331f2572" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d30d5de9-f676-4503-9df0-8eae59e789d8", "AQAAAAIAAYagAAAAEKwPZ+ve64qju4nIHT5jzHYn6V9sL1wGIxZU27VuobsbFx/AWM7m4n40WjfwN3W4Zg==", "d56b35e9-4942-4c27-84e8-43d1104a2459" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 30, DateTimeKind.Local).AddTicks(9862), new DateTime(2025, 2, 3, 13, 49, 16, 30, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 30, DateTimeKind.Local).AddTicks(9871), new DateTime(2025, 2, 3, 13, 49, 16, 30, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2867), new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2873), new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2874) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2876), new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(44), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(48), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(48) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(417), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(421), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(424), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(428), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(431), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(433), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(435), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(436) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(438), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(438) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(440), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(442), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(444), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(445) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(447), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2982), new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2986), new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(221), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(225), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(227), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(230), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(232), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(234), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(258), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(260), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(263), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(265), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(268), new DateTime(2025, 2, 3, 13, 49, 16, 31, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2617), new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2622), new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2626), new DateTime(2025, 2, 3, 13, 49, 15, 866, DateTimeKind.Local).AddTicks(2627) });
        }
    }
}
