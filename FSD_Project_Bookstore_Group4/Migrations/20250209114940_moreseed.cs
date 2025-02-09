using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class moreseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1af69f52-5b60-4410-965e-026cd68b24b6", "AQAAAAIAAYagAAAAEPwmI7CuXEn2Lrb65fKkMBtiADGPIIXEKCoZoTrlNQuClOyZzlOG2BkB7fp/EoL7kg==", "6403856d-dc15-4727-b7b3-5abe165e3083" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b86dd0a-9c30-44ef-ae21-9a128fdf302e", "AQAAAAIAAYagAAAAEGZTTHParp/j/nl4rkAn7qOr4SVjA5NjmOO+5KK5TXlR0CmCGVZx083CZPn5y8NN2Q==", "99aa68a3-7705-44ba-8863-7ddf27ee1e7c" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9567), new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9569) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9578), new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9585), new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9594), new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2162), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2182), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2189), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2197), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2205), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2214), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9838), new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9845), new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9849), new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9853), new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9870), new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9876), new DateTime(2025, 2, 9, 19, 49, 39, 678, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(521), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(525), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(529), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(530) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(532), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(533) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(535), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(539), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(542), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(546), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(549), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(552), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(553) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(555), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(556) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(558), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(559) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(562), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(565), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(568), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(569) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(571), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2596), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2605), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2610), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2611) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2615), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(152), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(157), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(162), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(165), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(170), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(173), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(177), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(180), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(183), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(187), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(190), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(1106), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(1128), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(1135), new DateTime(2025, 2, 9, 19, 49, 39, 458, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(889), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(900), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.InsertData(
                table: "SubscriptionTier",
                columns: new[] { "Id", "Cost", "CreatedBy", "DateCreated", "DateUpdate", "Description", "Discount", "TierName", "UpdatedBy" },
                values: new object[] { 3, 25f, null, new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(904), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(904), "25% discount for all orders", 0.25, "Premium+", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a6ba1d8-5665-447c-a8ad-d4615df7983d", "AQAAAAIAAYagAAAAEOwT37NnRWPKP3CotAxJfm44gj1ZP6isr+c9Zn2Yr3G4SezjE842WJbUOMFajnAicw==", "a5861e37-8c8d-4f43-b4db-31e4788da296" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56532243-885f-4f8e-a897-f47bcdbb7135", "AQAAAAIAAYagAAAAEO3F+5kjqbhK9HBaJFFi4HE+fg4ILvzlmdaSbYtqh5mjaQIpCJ/+fnVEtkKLFMIayQ==", "0ea49366-50cf-459b-9f93-909ca6885ed2" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4230), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4260), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4272), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4282), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6216), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6227), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6231), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6235), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6239), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6242), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6243) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4488), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4497), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4499), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4502), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4510), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4512), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5048), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5049) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5052), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5055), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5055) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5058), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5059) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5061), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5064), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5066), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5069), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5072), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5074), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5077), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5080), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5083), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5086), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5088), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5091), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6399), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6403), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6406), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6409), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4820), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4823), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4826), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4829), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4832), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4834), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4837), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4840), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4842), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4845), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4846) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4848), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(5850), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(5858), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(5862), new DateTime(2025, 2, 9, 19, 38, 49, 538, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(9642), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(9654), new DateTime(2025, 2, 9, 19, 38, 49, 665, DateTimeKind.Local).AddTicks(9655) });
        }
    }
}
