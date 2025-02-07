using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class updatedCustAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fa4966c-0ab4-4746-802a-e60a122c2c32", "AQAAAAIAAYagAAAAEAJkSPlT5Umer0OJrAbelgvcW+f4h2Gd6/Qzfed6/ltybfjE36/t0nC1BqvxeEGt5Q==", "37d6caf3-a8ff-4dd5-a17c-99ac278869f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f2d9822-c8c1-41b1-9d27-be6c1b66156d", "AQAAAAIAAYagAAAAEAUZ4yKy4iiZFPD59q8mb385sxqIcLyO78PrBukEdX+DHi/7C1yXnUlG31dlC3lYAQ==", "67403401-ebb3-445b-a1b6-3131bf7cb6d0" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5110), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5118), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5122), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7452), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7463), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7466), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7469), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7469) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5317), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5321), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5323), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5324) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5999), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6003), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6005), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6007), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6010), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6012), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6014), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6017), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6019), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6021), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6023), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6026), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7573), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7576), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7578), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7580), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5787), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5791), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5793), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5796), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5818), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5821), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5823), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5825), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5827), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5829), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5832), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7198), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7204), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7207), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6179), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6180) });
        }
    }
}
