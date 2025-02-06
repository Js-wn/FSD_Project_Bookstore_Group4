using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class addedMoreGender : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "378841a7-6e0a-4760-ba6a-678e01d072c7", "AQAAAAIAAYagAAAAELfSLxczAvYBT3C4zsOf0BboEYFO4+j+YXvQme9o1NhsmuoXYqvM5QsZyRbwFc0Rrw==", "22615772-87b7-4d15-9657-f787ceb8ae8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e64757b-6c02-40db-86bf-9a39ccfd5c25", "AQAAAAIAAYagAAAAEGDlB7f6jxzQtsdRofOlWgUq1gf86SIgg7iMR3+C2s4XAEyBjozgzd7RKrGTIK81Xg==", "cdf89481-0092-4c21-a14c-74d43fdcb104" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5466), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5476), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9927), new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9943), new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9946), new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9946) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5686), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5694), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5695) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6229), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6233), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6235), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6238), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6240), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6243), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6246), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6248), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6251), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6253), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6256), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6259), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 674, DateTimeKind.Local).AddTicks(81), new DateTime(2025, 2, 6, 17, 4, 48, 674, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 674, DateTimeKind.Local).AddTicks(85), new DateTime(2025, 2, 6, 17, 4, 48, 674, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "GenderId", "GenderName", "UpdatedBy" },
                values: new object[,]
                {
                    { 3, "System", new DateTime(2025, 2, 6, 17, 4, 48, 674, DateTimeKind.Local).AddTicks(88), new DateTime(2025, 2, 6, 17, 4, 48, 674, DateTimeKind.Local).AddTicks(88), 0, "Attack-Helicopter", "System" },
                    { 4, "System", new DateTime(2025, 2, 6, 17, 4, 48, 674, DateTimeKind.Local).AddTicks(90), new DateTime(2025, 2, 6, 17, 4, 48, 674, DateTimeKind.Local).AddTicks(91), 0, "Toaster", "System" }
                });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5903), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5907), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5910), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5994), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5997), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6000), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6047), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6050), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6051) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6053), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6055), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6058), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9615), new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9626), new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9629), new DateTime(2025, 2, 6, 17, 4, 48, 673, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(8295), new DateTime(2025, 2, 6, 17, 4, 48, 797, DateTimeKind.Local).AddTicks(8296) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3f13000-9e2f-4681-9b0f-c80cb28180c6", "AQAAAAIAAYagAAAAEOyZMiqPL43TPSofgc0uu9oy7slqLeHf58yzMjIbnaDbzisYLYUW6KTxwkzvhjFM0Q==", "1dfef86d-6b63-4d28-ac6e-db5d79093e4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e32fb75e-ff4f-428d-bd09-fd2479c1b398", "AQAAAAIAAYagAAAAEMh/Fr+pyzLutPYTHnYhLy4LDu5ZnfOKTyNujtzkUfI9e4xm7pP4Qus6GTliqoZ0cw==", "463dbffb-b99a-49fc-8bfa-8024ed473ce0" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7355), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7364), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4912), new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4922), new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4925), new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7519), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7523), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7838), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7842), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7844), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7847), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7850), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7852), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7854), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7856), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7858), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7860), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7863), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7865), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(5063), new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(5067), new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7669), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7672), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7674), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7676), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7678), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7680), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7682), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7685), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7687), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7689), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7691), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4632), new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4632) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4638), new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4642), new DateTime(2025, 2, 6, 16, 44, 21, 892, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(8009), new DateTime(2025, 2, 6, 16, 44, 21, 993, DateTimeKind.Local).AddTicks(8010) });
        }
    }
}
