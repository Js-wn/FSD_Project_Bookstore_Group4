using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class moreseeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ce4fdae-58c7-4a86-8ad3-80c9166be823", "AQAAAAIAAYagAAAAEB//aoIK+CiabUeGF40GLJ8Wdy6+8CU8nj4yvhMNCItleAvoKRl+HGpx/Ysauf/1gA==", "89747724-e543-4170-89c1-cb88b81c5567" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "158d1259-6312-4527-bf5b-2c74ec9c3212", "AQAAAAIAAYagAAAAEGub9SpY6gnLj80j9GKPhLpiSoBTL4YckQqy9VNAQpYJFayy/6f92Mpzd9APLODkhg==", "8f67ad21-d549-43cb-a509-1bf8064184d6" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9543), new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9554), new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9563), new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9565) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9571), new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9572) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7649), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7716), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7720), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7725), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7725) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7728), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7732), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9796), new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9797) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9801), new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9805), new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9806) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9808), new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9811), new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9814), new DateTime(2025, 2, 9, 19, 58, 1, 787, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(308), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(312), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(315), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(377), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(378) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(381), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(384), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(387), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(388) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(391), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(394), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(395) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(397), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(401), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(401) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(404), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(407), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(410), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(414), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(417), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7890), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7894), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7897), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7898) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7900), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(87), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(87) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(91), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(95), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(99), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(102), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(105), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(106) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(109), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(112), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(115), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(119), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(122), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7364), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7375), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7375) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7379), new DateTime(2025, 2, 9, 19, 58, 1, 646, DateTimeKind.Local).AddTicks(7379) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(652), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(653), "System" });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(661), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(662), "System" });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { "System", new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(665), new DateTime(2025, 2, 9, 19, 58, 1, 788, DateTimeKind.Local).AddTicks(665), "System" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { null, new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(889), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(889), null });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { null, new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(900), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(901), null });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { null, new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(904), new DateTime(2025, 2, 9, 19, 49, 39, 679, DateTimeKind.Local).AddTicks(904), null });
        }
    }
}
