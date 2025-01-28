using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class fixedFKs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the incorrect foreign key.
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Gender_GenderId",
                table: "Customer"
            );

            // Add the correct foreign key that links Customer.GenderId to Gender.Id.
            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Gender_GenderId",
                table: "Customer",
                column: "GenderId", // Ensure the column is GenderId in Customer.
                principalTable: "Gender",
                principalColumn: "Id", // Ensure the column is Id in Gender.
                onDelete: ReferentialAction.Cascade
            );


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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the correct foreign key.
            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Gender_GenderId",
                table: "Customer"
            );

            // Re-add the old foreign key if necessary.
            migrationBuilder.AddForeignKey(
                name: "FK_Customer_Gender_GenderId",
                table: "Customer",
                column: "GenderId", // Still GenderId in Customer.
                principalTable: "Gender",
                principalColumn: "GenderId", // Revert back to GenderId if necessary.
                onDelete: ReferentialAction.Cascade
            );

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

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5787), new DateTime(2025, 1, 28, 17, 15, 1, 212, DateTimeKind.Local).AddTicks(5800) });

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
        }
    }
}
