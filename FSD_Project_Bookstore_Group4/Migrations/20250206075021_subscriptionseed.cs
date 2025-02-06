using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class subscriptionseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f553377-6994-4315-a442-6292e996a293", "AQAAAAIAAYagAAAAEGfT/33S7c9n3dlrWKNaymmnGe++n89FDIMzI5rAY52xWBG2Zqev+4qBJdm2eJnZLA==", "f334fb79-216f-4aa1-9822-5b902037ab7a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4907b27a-dffd-475e-b92a-455cec594d70", "AQAAAAIAAYagAAAAEJvakW23DHDWGwz4bARcxKUX8K7xCclbb31DuFbRcuNU8xY86jX2BxftZqD5DpnBNw==", "5ab2db97-146d-4ea8-99fe-881ff522bc68" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(134), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(148), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(2496), new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(2513), new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(2521), new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(619), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(625), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1305), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1311), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1312) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1316), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1317) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1320), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1325), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1329), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1334), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1339), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1343), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1344) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1348), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1352), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1357), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(2880), new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(2889), new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(924), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(933), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(939), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(944), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(948), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(953), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1005), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1007) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1010), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1015), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1019), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1024), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1025) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(702), new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(713), new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(1249), new DateTime(2025, 2, 6, 15, 50, 18, 626, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.InsertData(
                table: "SubscriptionTier",
                columns: new[] { "Id", "Cost", "CreatedBy", "DateCreated", "DateUpdate", "Description", "TierName", "UpdatedBy" },
                values: new object[] { 1, 15f, null, new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1823), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1824), null, "Basic", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1);

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
    }
}
