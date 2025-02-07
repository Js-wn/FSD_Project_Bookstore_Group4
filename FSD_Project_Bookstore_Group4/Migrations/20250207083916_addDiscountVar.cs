using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class addDiscountVar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "SubscriptionTier",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "SubscriptionTier");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c466d24-b516-486d-9d0f-93839b084a9a", "AQAAAAIAAYagAAAAEI/lBDbBsx5DbnJQp1K9CqRDIqv0fiN2agbLRyBjg+4FOs1lFJVtiZKYwxin+x+32w==", "6e2a5557-df2a-4875-815b-4f1d7b558141" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a373ac9f-f0f9-48b3-897b-caf91dec15b7", "AQAAAAIAAYagAAAAEMkrzNclJv4Fsa/c5Bo7gcu5orUFnJ7NwFWR/L31ibELUYK9sfQWeSt/oQi9X8T+nQ==", "5b567e0d-5f02-4827-9e47-0122c8334e69" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3282), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3296), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3304), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3181), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3192), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3198), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3204), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3598), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3607), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3612), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4382), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4388), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4393), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4398), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4403), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4408), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4412), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4417), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4421), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4426), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4430), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4435), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3509), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3515), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3520), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3524), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3923), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3929), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3934), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3939), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3973), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3978), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3983), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3987), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3992), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3996), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4001), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2697), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2708), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2714), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4735), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4737) });
        }
    }
}
