using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class bookfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4e160e6-6791-4f1b-b81f-d32c88561284", "AQAAAAIAAYagAAAAEDr4Bi/AwZfLlkl5dqRu7KfsAC2pLzGg5TfOt+hjqC3C/NKHZfndLqB0RSQUcNqIoQ==", "02805db3-ee59-424f-bebe-cfcc3db92614" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d31e6d87-0a6a-469f-8b53-d2be81636e6c", "AQAAAAIAAYagAAAAEFQGGI2vFcFMveq3HVassL2bQIIYpkx3F8Dxdn+F9cbZrBtuY+oSbq6S+EtjBLIy4w==", "7da67eb2-2a6c-43a2-99de-a48ee1748811" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9386), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9397), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9407), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9416), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9417) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2424), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2425), "System" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2435), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2436), "System" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2438), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2438), "System" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2440), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2440), "System" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "PublisherId", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2442), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2443), 2, "System" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2444), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2445), "System" });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9572), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9575), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9577), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9579), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9586), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9587), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9919), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9922), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9924), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9924) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9926), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9926) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9928), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9930), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9932), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9934), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9936), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9938), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9939) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9941), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9941) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9943), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9945), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9947), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9949), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9949) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9951), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9952) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2524), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2527), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2529), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2530), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9770), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9771) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9773), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9774) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9775), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9778), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9780), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9782), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9784), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9786), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9788), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9790), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9791) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9792), new DateTime(2025, 2, 8, 2, 11, 5, 478, DateTimeKind.Local).AddTicks(9793) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2221), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2226), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2228), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 479, DateTimeKind.Local).AddTicks(82), new DateTime(2025, 2, 8, 2, 11, 5, 479, DateTimeKind.Local).AddTicks(83) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57e08428-97d3-4b69-b0ba-afa8b0f9be59", "AQAAAAIAAYagAAAAELsXapAqbsonKgqqLXj8aYPctVLgjwEArmzC+EXFWKgnmC3d0ZsgGH7uVGMxj1pBdA==", "67a92b90-71e9-4272-9e2c-c08f21c67798" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c8c0c6a-9768-4dfa-b8b0-126d14529398", "AQAAAAIAAYagAAAAEKLdutuAZFHkTAD+UuVC6jQFFwl3JABsYMw5btYe0ylAgykutGafyIMQS1Fz4WaAFQ==", "af135f78-13d9-455d-8f2f-5cfc16d1be2a" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6185), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6207), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6214), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5699), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5699) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { null, new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6277), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6280), null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { null, new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6300), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6301), null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { null, new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6306), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6308), null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { null, new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6313), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6316), null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "PublisherId", "UpdatedBy" },
                values: new object[] { null, new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4358), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4359), 1, null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { null, new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4361), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4361), null });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6833), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6840), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5806), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5808), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5818), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5820), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5834) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7537), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7542), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7546), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7550), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7554), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7558), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7562), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7742), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7747), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7751), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7755), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7759), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6109), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6110), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6112), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6113), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6798), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6811), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6819), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6879), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7151), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7156), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7161), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7165), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7169), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7173), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7177), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7181), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7185), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7189), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7193), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5012), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5029), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5036), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(8070), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(8071) });
        }
    }
}
