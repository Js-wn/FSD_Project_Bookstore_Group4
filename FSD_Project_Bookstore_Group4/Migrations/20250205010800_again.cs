using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class again : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea1b4cc8-ab5f-4168-9af4-95b05a9e717a", "AQAAAAIAAYagAAAAEBXNEeEAEXeHjlwwTKw7exOhtcs4BILOsKg/9LhKkLP+WtKRT5Qz4tGqIsl5HvfRkQ==", "6e60161d-9161-4aeb-8979-58c811b8813d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8fee306-38bb-45c5-832b-9ec6551b0e84", "AQAAAAIAAYagAAAAENWuk9svEuFyl/apLnOqihQlnc9hxudQcMsskZ8BmAC2rWuTKEKFNISTLwEp2P+uKw==", "c6973638-8167-425b-96fd-5d39b3f76d63" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(6986), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(6994), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(9088), new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(9095), new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(9098), new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7170), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7173), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7605), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7605) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7608), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7611), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7613), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7616), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7618), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7619) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7622), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7624), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7627), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7629), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7631), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7635), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(9203), new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(9207), new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7395), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7399), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7401), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7403), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7406), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7408), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7433), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7436), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7436) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7438), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7439) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7441), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7443), new DateTime(2025, 2, 5, 9, 7, 59, 592, DateTimeKind.Local).AddTicks(7444) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(8802), new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(8806), new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(8809), new DateTime(2025, 2, 5, 9, 7, 59, 424, DateTimeKind.Local).AddTicks(8810) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
