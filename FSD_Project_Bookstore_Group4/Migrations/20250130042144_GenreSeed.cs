using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class GenreSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_OrderItem_OrderItemId",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "OrderItemId",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
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
                values: new object[] { "954a029f-6025-4bcd-a30b-6369a1f4e0f7", "AQAAAAIAAYagAAAAEPjY6/qcuwr1qplj0wwmrLIK9Uis2jzFR+9NGxVPX1+onFQ5tGy5jLHFihTWQOHX+w==", "45ad91a8-80ae-4d61-ba8b-2cf652924b83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a145fd55-8088-45f3-97c6-c1cb92a43fe2", "AQAAAAIAAYagAAAAENeFEY4XeCyXEKbvbLfkL3nrlqUsqF9s+1f3EVyzKmE12usZJ/SWhvjKvglvPUJaNA==", "70a0715d-83c4-4355-b12b-e6f79342cd7a" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 315, DateTimeKind.Local).AddTicks(6619), new DateTime(2025, 1, 30, 12, 21, 43, 315, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 315, DateTimeKind.Local).AddTicks(6624), new DateTime(2025, 1, 30, 12, 21, 43, 315, DateTimeKind.Local).AddTicks(6624) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(340), new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(347), new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(349), new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 315, DateTimeKind.Local).AddTicks(7333), new DateTime(2025, 1, 30, 12, 21, 43, 315, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 315, DateTimeKind.Local).AddTicks(7395), new DateTime(2025, 1, 30, 12, 21, 43, 315, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(425), new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(429), new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(134), new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(138), new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(138) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(140), new DateTime(2025, 1, 30, 12, 21, 43, 192, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_OrderItem_OrderItemId",
                table: "Review",
                column: "OrderItemId",
                principalTable: "OrderItem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_OrderItem_OrderItemId",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "OrderItemId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
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
                values: new object[] { "20feb648-cd35-40d6-a32e-62d68d1fb6fe", "AQAAAAIAAYagAAAAEHM9eEi9dav+eKsjWVDS6GrU2sZrPWLnIBaYoB5MZLbs/nIDxzQYySHHywZJgTXVrw==", "e2f12507-7123-4292-ba7b-c8173cd9c8c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c55927e-023c-4915-9fc9-654738603423", "AQAAAAIAAYagAAAAEIuQ6evUEaehyCQYKUMM/zL0BoY9Tpam9z1gG2Gc22i4+rjJ7OJSE3ZBL/a+XZDFgw==", "dae45884-2392-4a8a-910a-e976f70ace7b" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 770, DateTimeKind.Local).AddTicks(8420), new DateTime(2025, 1, 29, 0, 43, 29, 770, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 770, DateTimeKind.Local).AddTicks(8437), new DateTime(2025, 1, 29, 0, 43, 29, 770, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(3206), new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(3226), new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(3232), new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 770, DateTimeKind.Local).AddTicks(8737), new DateTime(2025, 1, 29, 0, 43, 29, 770, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 770, DateTimeKind.Local).AddTicks(8748), new DateTime(2025, 1, 29, 0, 43, 29, 770, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(3448), new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(3458), new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(2681), new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(2691), new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(2693) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(2698), new DateTime(2025, 1, 29, 0, 43, 29, 540, DateTimeKind.Local).AddTicks(2699) });

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_OrderItem_OrderItemId",
                table: "Review",
                column: "OrderItemId",
                principalTable: "OrderItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
