using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class custSubVariable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasActiveSubscription",
                table: "Customer",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasActiveSubscription",
                table: "Customer");

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

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1823), new DateTime(2025, 2, 6, 15, 50, 18, 937, DateTimeKind.Local).AddTicks(1824) });
        }
    }
}
