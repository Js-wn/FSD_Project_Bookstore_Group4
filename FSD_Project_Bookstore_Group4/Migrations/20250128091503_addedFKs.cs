using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class addedFKs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubscrptionInfoId",
                table: "Payment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "Customer",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92144bac-b6fd-4ab1-8201-c7261b96a7e8", "AQAAAAIAAYagAAAAEN8kFBuS0WfGM0eo5u6a+Cqqf8rXAvJi0lK+m5sgnwOrFLFwxp5QjbCLLCWJQ3Ev/g==", "009d335b-c916-4077-bca8-47122264aa91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "638b8e1d-44c7-4a7d-b7a2-480801aca24e", "AQAAAAIAAYagAAAAELv1crPtw2YRJvlB9kahGNKUAyxT0c1aIHQd8u5Zt7cUJhG3sz2bygzj2wYLN/CWMA==", "d879187b-e278-4359-bf5f-2c7c858ceb07" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 482, DateTimeKind.Local).AddTicks(3106), new DateTime(2025, 1, 28, 17, 15, 1, 482, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 482, DateTimeKind.Local).AddTicks(3121), new DateTime(2025, 1, 28, 17, 15, 1, 482, DateTimeKind.Local).AddTicks(3123) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5753), new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5768), new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "BookDesc", "BookPrice", "BookPublishDate", "BookTitle", "CreatedBy", "DateCreated", "DateUpdate", "ImgLink", "PublisherId", "UpdatedBy" },
                values: new object[] { 3, "Patrick Bateman moves among the young and trendy in 1980s Manhattan. Young, handsome, and well educated, Bateman earns his fortune on Wall Street by day while spending his nights in ways we cannot begin to fathom. Expressing his true self through torture and murder, Bateman prefigures an apocalyptic horror that no society could bear to confront.", 23.99f, new DateTime(1991, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Psycho", null, new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5787), new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5800), "https://m.media-amazon.com/images/I/7150fwe2f9L._SL1200_.jpg", 1, null });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 482, DateTimeKind.Local).AddTicks(4082), new DateTime(2025, 1, 28, 17, 15, 1, 482, DateTimeKind.Local).AddTicks(4083) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 482, DateTimeKind.Local).AddTicks(4092), new DateTime(2025, 1, 28, 17, 15, 1, 482, DateTimeKind.Local).AddTicks(4093) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(6123), new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(6129), new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5256), new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5267), new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5274), new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.CreateIndex(
                name: "IX_SubscrptionInfo_CutomerId",
                table: "SubscrptionInfo",
                column: "CutomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscrptionInfo_TierId",
                table: "SubscrptionInfo",
                column: "TierId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_CustomerId",
                table: "Review",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Review_OrderItemId",
                table: "Review",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerId",
                table: "Payment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_SubscrptionInfoId",
                table: "Payment",
                column: "SubscrptionInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_TierId",
                table: "Payment",
                column: "TierId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_BookId",
                table: "OrderItem",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_GenderId",
                table: "Customer",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrderItemId",
                table: "Customer",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_BookId",
                table: "BookGenre",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_GenreId",
                table: "BookGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_BookId",
                table: "BookAuthor",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_PublisherId",
                table: "Book",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Author_AuthorId",
                table: "BookAuthor",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Book_BookId",
                table: "BookAuthor",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Book_BookId",
                table: "BookGenre",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookGenre_Genre_GenreId",
                table: "BookGenre",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Gender_GenderId",
                table: "Customer",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_OrderItem_OrderItemId",
                table: "Customer",
                column: "OrderItemId",
                principalTable: "OrderItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Book_BookId",
                table: "OrderItem",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Customer_CustomerId",
                table: "Payment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_SubscriptionTier_TierId",
                table: "Payment",
                column: "TierId",
                principalTable: "SubscriptionTier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_SubscrptionInfo_SubscrptionInfoId",
                table: "Payment",
                column: "SubscrptionInfoId",
                principalTable: "SubscrptionInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Customer_CustomerId",
                table: "Review",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_OrderItem_OrderItemId",
                table: "Review",
                column: "OrderItemId",
                principalTable: "OrderItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubscrptionInfo_Customer_CutomerId",
                table: "SubscrptionInfo",
                column: "CutomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);


            migrationBuilder.AddForeignKey(
                name: "FK_SubscrptionInfo_SubscriptionTier_TierId",
                table: "SubscrptionInfo",
                column: "TierId",
                principalTable: "SubscriptionTier",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Author_AuthorId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Book_BookId",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Book_BookId",
                table: "BookGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_BookGenre_Genre_GenreId",
                table: "BookGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Gender_GenderId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_OrderItem_OrderItemId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Book_BookId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Customer_CustomerId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Order_OrderId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_SubscriptionTier_TierId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_SubscrptionInfo_SubscrptionInfoId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Customer_CustomerId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_OrderItem_OrderItemId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscrptionInfo_Customer_CutomerId",
                table: "SubscrptionInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_SubscrptionInfo_SubscriptionTier_TierId",
                table: "SubscrptionInfo");

            migrationBuilder.DropIndex(
                name: "IX_SubscrptionInfo_CutomerId",
                table: "SubscrptionInfo");

            migrationBuilder.DropIndex(
                name: "IX_SubscrptionInfo_TierId",
                table: "SubscrptionInfo");

            migrationBuilder.DropIndex(
                name: "IX_Review_CustomerId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_OrderItemId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Payment_CustomerId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_OrderId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_SubscrptionInfoId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_TierId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_BookId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_Customer_GenderId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_Customer_OrderItemId",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "IX_BookGenre_BookId",
                table: "BookGenre");

            migrationBuilder.DropIndex(
                name: "IX_BookGenre_GenreId",
                table: "BookGenre");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthor");

            migrationBuilder.DropIndex(
                name: "IX_BookAuthor_BookId",
                table: "BookAuthor");

            migrationBuilder.DropIndex(
                name: "IX_Book_PublisherId",
                table: "Book");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "SubscrptionInfoId",
                table: "Payment");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "Customer");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da4238ca-430a-4906-aabe-dbbf3d2ea3bd", "AQAAAAIAAYagAAAAEAzRTidVyiAy2lFmOKmRCKWOTrBJbbTrQvfOwi44aXj3sf9ztCgfjMCPFZEVZm3JoQ==", "059e572b-293a-42f0-9212-cea4ee822b14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a266cb0c-e127-4936-97e0-e6c28f857534", "AQAAAAIAAYagAAAAEHi2BBA7CPQNlNsU3UzuSJ2pzFVoIPQEO3oOuSax5oEjTSx0UMBBZpD+9qka7LwPXQ==", "252d7d2a-36e3-4c09-aef5-79de36e9455e" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(6819), new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(6841), new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3099), new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3105), new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(7018), new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(7021), new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3198), new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3201), new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3201) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(2855), new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(2869), new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(2872), new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(2872) });
        }
    }
}
