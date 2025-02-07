using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class MakeSubscriptionAndTierNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_SubscriptionTier_TierId",
                table: "Payment");

            migrationBuilder.AlterColumn<int>(
                name: "TierId",
                table: "Payment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionId",
                table: "Payment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_SubscriptionTier_TierId",
                table: "Payment",
                column: "TierId",
                principalTable: "SubscriptionTier",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_SubscriptionTier_TierId",
                table: "Payment");

            migrationBuilder.AlterColumn<int>(
                name: "TierId",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionId",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5614), new DateTime(2025, 2, 7, 17, 4, 4, 374, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_SubscriptionTier_TierId",
                table: "Payment",
                column: "TierId",
                principalTable: "SubscriptionTier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
