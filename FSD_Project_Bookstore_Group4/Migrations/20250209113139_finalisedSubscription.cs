using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class finalisedSubscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cac4a81b-6ea3-4285-9eca-3bc7bb2b970e", "AQAAAAIAAYagAAAAEMBuBGzWrMqvO0bVDNd5OYEFWUIVZKO/R2otYfebDsCJU/o7mGR4PYsyQ/6HcFYSvA==", "a40fc4e9-9021-4ab3-84dd-6990385f5797" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d592fe3-397f-49b8-a76f-9a49769e5dd4", "AQAAAAIAAYagAAAAEP2aX/yDoCL4u0Uxh19eJzTbgk3PHj5USR7fq8dOeta5uBY7J+0ZoUPdjPPpnYZ2UQ==", "fba8c8a7-b003-4df7-b499-a2543a3ba3ff" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8077), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8093), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8100), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8110), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1450), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1468), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1474), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1481), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1486), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1492), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8374), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8375) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8384), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8385) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8388), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8392), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8393) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8410), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8411) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8414), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8980), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8981) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8985), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8989), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8993), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8997), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9001), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9005), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9008), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9012), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9016), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9019), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9023), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9027), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9031), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9034), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9038), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1776), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1784), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1788), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1794), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8708), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8709) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8713), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8717), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8722), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8725), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8729), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8733), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8737), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8741), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8744), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8748), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(857), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(872), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(879), new DateTime(2025, 2, 9, 19, 31, 37, 782, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate", "Description" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9288), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9289), "15% discount for all orders" });

            migrationBuilder.InsertData(
                table: "SubscriptionTier",
                columns: new[] { "Id", "Cost", "CreatedBy", "DateCreated", "DateUpdate", "Description", "Discount", "TierName", "UpdatedBy" },
                values: new object[] { 2, 20f, null, new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9298), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9300), "20% discount for all orders", 0.20000000000000001, "Premium", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 2);

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
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2424), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2435), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2438), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2440), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2442), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2444), new DateTime(2025, 2, 8, 2, 11, 5, 339, DateTimeKind.Local).AddTicks(2445) });

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
                columns: new[] { "DateCreated", "DateUpdate", "Description" },
                values: new object[] { new DateTime(2025, 2, 8, 2, 11, 5, 479, DateTimeKind.Local).AddTicks(82), new DateTime(2025, 2, 8, 2, 11, 5, 479, DateTimeKind.Local).AddTicks(83), null });
        }
    }
}
