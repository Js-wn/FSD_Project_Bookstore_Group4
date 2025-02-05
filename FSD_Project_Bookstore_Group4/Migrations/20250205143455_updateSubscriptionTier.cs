using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class updateSubscriptionTier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SubscriptionTier",
                type: "nvarchar(max)",
                nullable: true);


            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98e2a6bc-9b1c-4e8c-a347-6d28a7a7dfec", "AQAAAAIAAYagAAAAEFAx8l3ywmrRW7SrYm4+7oVz2VHYMzL869tNl4spILZSBM3ZYmh7lDRqf4CSOAg+PQ==", "d573c6cb-e997-4c5c-b29d-8155d771824f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f590facf-cea7-4ff6-a276-aa37a055996a", "AQAAAAIAAYagAAAAEBXqZUYmf7vw57rqwWB41C0mRGBVnTO0u8ql4XL1jjVzgwlAsOswYlLf1gOlZmL2OA==", "befa56a9-45ec-4bc0-889c-dc0657f9d6b0" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(2607), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(2622), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(2623) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5685), new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5704), new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5710), new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(2853), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(2866), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3584), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3585) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3589), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3594), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3599), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3603), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3608), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3613), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3614) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3617), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3622), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3626), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3631), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3636), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5943), new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5951), new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3276), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3282), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3287), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3292), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3296), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3301), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3306), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3310), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3315), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3320), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3324), new DateTime(2025, 2, 5, 22, 34, 53, 219, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5116), new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5128), new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5135), new DateTime(2025, 2, 5, 22, 34, 52, 950, DateTimeKind.Local).AddTicks(5136) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "SubscriptionTier");

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
    }
}
