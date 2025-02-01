using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class fixedSubscriptionInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "SubscriptionInfo");

            migrationBuilder.RenameColumn(
                name: "SubscriptionInfoId",
                table: "Payment",
                newName: "SubscriptionInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_SubscriptionInfoId",
                table: "Payment",
                newName: "IX_Payment_SubscriptionInfoId");

            migrationBuilder.CreateTable(
                name: "SubscriptionInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TierId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionInfo_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionInfo_SubscriptionTier_TierId",
                        column: x => x.TierId,
                        principalTable: "SubscriptionTier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ceb6f1ca-cd1e-45a9-b6d8-0bda67a97e6b", "AQAAAAIAAYagAAAAEHRFI0dMK3A1+vD7FAPTL48VlDhTZVjGW9rbEo+3ZSfZhMVzVibk3jxaWeRuBvUWBg==", "499943d1-ea73-467e-a6bb-7a08f4ab968d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "396ee728-e8ab-4ec8-9e16-e9d61886e3ec", "AQAAAAIAAYagAAAAEBfJmDzIfZ4k3fleO0eVJLn0p7QgkuDpobMJaKeFnz4mDRaaCgqKEhqoRlvPct8Mdg==", "7019bcc5-6e21-49ae-bdf8-22d0a654ea22" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(626), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(628) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(641), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5683), new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5701), new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5704), new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5705) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(997), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(999) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1004), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1963), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1971), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1975), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1979), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1982), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1984), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1987), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1991), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1993), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1996), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1999), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(2001), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5903), new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5906), new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1600), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1606), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1611), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1615), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1619), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1622), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1655), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1658), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1664), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1667), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1670), new DateTime(2025, 2, 1, 17, 59, 17, 108, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5139), new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5156), new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5159), new DateTime(2025, 2, 1, 17, 59, 16, 975, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionInfo_CustomerId",
                table: "SubscriptionInfo",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionInfo_TierId",
                table: "SubscriptionInfo",
                column: "TierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_SubscriptionInfo_SubscriptionInfoId",
                table: "Payment",
                column: "SubscriptionInfoId",
                principalTable: "SubscriptionInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_SubscriptionInfo_SubscriptionInfoId",
                table: "Payment");

            migrationBuilder.DropTable(
                name: "SubscriptionInfo");

            migrationBuilder.RenameColumn(
                name: "SubscriptionInfoId",
                table: "Payment",
                newName: "SubscriptionInfoId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_SubscriptionInfoId",
                table: "Payment",
                newName: "IX_Payment_SubscriptionInfoId");

            migrationBuilder.CreateTable(
                name: "SubscriptionInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TierId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionInfo_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionInfo_SubscriptionTier_TierId",
                        column: x => x.TierId,
                        principalTable: "SubscriptionTier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69b24a49-8c09-4780-a15d-88739b252b35", "AQAAAAIAAYagAAAAECKe64ONar/JM0XFkPKS+hBQ6xGQsdXMw0PlGGtKUr31/lqLBc+YmRJagqFr0m4umw==", "320e40d0-cdad-4cc1-8cd6-7c3716592a1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ba3b6f0-a7b0-45d3-8d62-005846c1bec2", "AQAAAAIAAYagAAAAEPp/gz5bQBOXA4lk+Tljkz5zcTdzBkI1u05PH3DmJTaLa8kjryQO1up9uOYHf1lkzA==", "264f8d09-f722-478f-9569-99062b931bfc" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 15, DateTimeKind.Local).AddTicks(9863), new DateTime(2025, 2, 1, 10, 55, 55, 15, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 15, DateTimeKind.Local).AddTicks(9873), new DateTime(2025, 2, 1, 10, 55, 55, 15, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8285), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8298), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8298) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8300), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(36), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(37) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(159), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(606), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(609), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(611), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(614), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(617), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(617) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(619), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(619) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(621), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(622) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(624), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(626), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(628), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(631), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(633), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8419), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8426), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(394), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(394) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(397), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(399), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(399) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(401), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(403), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(406), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(408), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(408) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(410), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(412), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(414), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(417), new DateTime(2025, 2, 1, 10, 55, 55, 16, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(7999), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8008), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8011), new DateTime(2025, 2, 1, 10, 55, 54, 909, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionInfo_CustomerId",
                table: "SubscriptionInfo",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionInfo_TierId",
                table: "SubscriptionInfo",
                column: "TierId");

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
