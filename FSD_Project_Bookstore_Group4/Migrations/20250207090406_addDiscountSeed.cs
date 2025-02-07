using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class addDiscountSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Discount",
                table: "SubscriptionTier",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cf55fc6-f1ac-4780-884f-712aae11601a", "AQAAAAIAAYagAAAAEDrphBXyPIAbxJQ/uTbzC35Dv52DUM3WjIm69shKnqgNRMYckSItLgPwokZc9+0khQ==", "934c0955-0da6-45b1-9c4d-6f2993185bb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b15efaf0-0971-4eeb-8390-7c69e828dd62", "AQAAAAIAAYagAAAAEEqTHhPoahm5OAjIPdrXuP1da093x/Y8bngtIVyvnJPOPfwZLrxa2EVSlXLGecSOlA==", "65650902-3f3f-4604-8c72-afd565cb4053" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3496), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3497) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3513), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3522), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5873), new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5891), new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5896), new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5902), new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3977), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3987), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3993), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5231), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5237), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5243), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5248), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5253), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5258), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5263), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5267), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5272), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5273) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5276), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5281), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5285), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(6122), new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(6131), new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(6132) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(6136), new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(6141), new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4730), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4732) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4741), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4747), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4755), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4760), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4766), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4772), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4777), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4783), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4789), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4794), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5349), new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5359), new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5365), new DateTime(2025, 2, 7, 17, 4, 4, 103, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate", "Discount" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5614), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5616), 0.14999999999999999 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Discount",
                table: "SubscriptionTier",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25e614ce-5176-4ab5-81eb-db11e6941bd2", "AQAAAAIAAYagAAAAECiO7jbvGF8VmmPMS2PSI8Nr2a7ETlWsWqL1pJtjhdoe7ZapD7DSNUKRiKXFOozGJA==", "f5328bfe-db43-44fa-914a-6d489ffc95b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "838a469e-7ef3-4627-aaae-210a786b099d", "AQAAAAIAAYagAAAAEPYt/93IOz4poizC/4W8yieFY9cM/f9AKhpLEfIyGA/SKlXyFkDr6GfNZugb9J0gJA==", "b7bd5425-758d-4c45-ae69-030e73b5514e" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(6598), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(6614), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(6621), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1602), new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1615), new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1621), new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1626), new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7020), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7021) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7027), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7032), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7725), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7727) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7730), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7735), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7739), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7744), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7748), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7752), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7757), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7758) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7761), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7762) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7765), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7770), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7774), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1844), new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1850), new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1855), new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1860), new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7353), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7358), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7367), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7368) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7372), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7385) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7410), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7411) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7414), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7419), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7424), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7428), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7433), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7437), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(7438) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1082), new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1093), new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1094) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1100), new DateTime(2025, 2, 7, 16, 39, 13, 994, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate", "Discount" },
                values: new object[] { new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(8104), new DateTime(2025, 2, 7, 16, 39, 14, 288, DateTimeKind.Local).AddTicks(8106), 0m });
        }
    }
}
