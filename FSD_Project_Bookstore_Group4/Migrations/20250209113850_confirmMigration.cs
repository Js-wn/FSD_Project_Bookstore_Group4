using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class confirmMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9288), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9298), new DateTime(2025, 2, 9, 19, 31, 37, 995, DateTimeKind.Local).AddTicks(9300) });
        }
    }
}
