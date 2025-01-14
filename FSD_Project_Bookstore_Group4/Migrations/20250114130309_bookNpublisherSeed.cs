using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class bookNpublisherSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9428cbfd-d9aa-4e70-a47f-46d4dea03e59", "AQAAAAIAAYagAAAAEBvJwHAdPCBezZB+Om8bv9JBecBJ753EydMNnP957PecqR4f7fmAE4BUYUAaeNNJWQ==", "6b6d4984-3c5b-45d7-acd5-08fb4fd85204" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bd1bf68-0a82-4649-9740-6ba671f00187", "AQAAAAIAAYagAAAAEBa3Oh6DcoDnMWZq/46JkboX6jRWhwboZQEbc+Ywr2ffFDF9piXusvXiY52Y+HFl+Q==", "a575e5f9-59bc-4a47-9238-ae841fa466ee" });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8631), new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8634), new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8635) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8365), new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "PublisherAddress", "PublisherContact", "PublisherEmail", "PublisherName", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, "System", new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8384), new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8384), "6 Briset Street", "0207 038 5000", "webqueries@macmillan.co.uk", "Pan Books", "System" },
                    { 3, "System", new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8386), new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8386), " 8 Viaduct Gardens", "+44 (0)20 7139 3000", "VintagePublicity@penguinrandomhouse.co.uk", "Harvill Secker", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74f0e830-8f03-43bb-8473-b7faa3a6c266", "AQAAAAIAAYagAAAAEPoSVtUS+kdWBSApbt0/sdzZFW3ekDFiWaw+9To6iTOV/8zHAyaj+u93hLB/dsQTMw==", "33f4f32c-9070-472a-b135-3cc5f3538558" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3c70c84-c3eb-4a60-9a98-ee4acc0f6380", "AQAAAAIAAYagAAAAEDrLtoLHNeTGi6BhWBQXzV9d6SLW9FuDUx9jVt7Eeuzo2Ztebj7XSa6CZibIPh1KHg==", "9c9b7bf7-dd39-498c-a414-d0ae948c49d7" });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 9, 41, 29, 26, DateTimeKind.Local).AddTicks(9508), new DateTime(2025, 1, 14, 9, 41, 29, 26, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 9, 41, 29, 26, DateTimeKind.Local).AddTicks(9511), new DateTime(2025, 1, 14, 9, 41, 29, 26, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 9, 41, 29, 26, DateTimeKind.Local).AddTicks(9116), new DateTime(2025, 1, 14, 9, 41, 29, 26, DateTimeKind.Local).AddTicks(9126) });
        }
    }
}
