using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class tryFixSubInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_SubscriptionInfo_SubscriptionInfoId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_SubscriptionInfoId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "SubscriptionInfoId",
                table: "Payment");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0cf731d8-e56b-45e3-9b51-12e5b203f4f4", "AQAAAAIAAYagAAAAELsXapAqbsonKgqqLXj8aYPctVLgjwEArmzC+EXFWKgnmC3d0ZsgGH7uVGMxj1pBdA==", "67a92b90-71e9-4272-9e2c-c08f21c67798" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c8c0c6a-9768-4dfa-b8b0-126d14529398", "AQAAAAIAAYagAAAAEKLdutuAZFHkTAD+UuVC6jQFFwl3JABsYMw5btYe0ylAgykutGafyIMQS1Fz4WaAFQ==", "af135f78-13d9-455d-8f2f-5cfc16d1be2a" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6185), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6207), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6214), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6277), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6300), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6306), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6313), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6833), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6840), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6845), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(6846) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7537), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7538) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7542), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7546), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7550), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7554), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7558), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7559) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7562), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7742), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7747), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7748) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7751), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7752) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7755), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7759), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6798), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6811), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6812) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6819), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6879), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7151), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7156), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7161), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7165), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7169), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7173), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7177), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7181), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7185), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7189), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7193), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5012), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5029), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5036), new DateTime(2025, 2, 7, 23, 28, 48, 17, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(8070), new DateTime(2025, 2, 7, 23, 28, 48, 298, DateTimeKind.Local).AddTicks(8071) });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_SubscriptionId",
                table: "Payment",
                column: "SubscriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_SubscriptionInfo_SubscriptionId",
                table: "Payment",
                column: "SubscriptionId",
                principalTable: "SubscriptionInfo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_SubscriptionInfo_SubscriptionId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_SubscriptionId",
                table: "Payment");

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionInfoId",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7daf089-7506-459a-985f-479569b802d2", "AQAAAAIAAYagAAAAEHW3G5PFuTDNvi7FTrx89pXicjJRESnSKek6sSIewyehO0F+WwSr8xV6ZljiiSKafw==", "a702bfd2-1ba1-4be2-be54-da920a4fbe40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ffe7deb-da91-4f6c-94f5-6ed1779d518e", "AQAAAAIAAYagAAAAEKWHzoyT+WZG4ggMmpV2tRSdX/uEQ5dbxQAddirMN2LYHMu+svuknMhraS+vNnsccg==", "a6a92f08-9ca9-4b0c-b4c2-8b542a46e74c" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(2315), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(2332), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(2342), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6927), new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6943), new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6949), new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6954), new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3207), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3216), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3217) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3221), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4075), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4082), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4084) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4088), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4098), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4104), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4110), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4112) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4116), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4122), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4124) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4279), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4289), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4295), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4301), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(7176), new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(7182), new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(7186), new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(7191), new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3655), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3662), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3667), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3672), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3726), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3731), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3736), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3737) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3741), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3746), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3751), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3756), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(3757) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6446), new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6457), new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6459) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6464), new DateTime(2025, 2, 7, 17, 32, 56, 67, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4733), new DateTime(2025, 2, 7, 17, 32, 56, 330, DateTimeKind.Local).AddTicks(4734) });

            migrationBuilder.CreateIndex(
                name: "IX_Payment_SubscriptionInfoId",
                table: "Payment",
                column: "SubscriptionInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_SubscriptionInfo_SubscriptionInfoId",
                table: "Payment",
                column: "SubscriptionInfoId",
                principalTable: "SubscriptionInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
