using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class UserSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d34fe08-7c5c-4376-b47e-5acf9dd720d3", "AQAAAAIAAYagAAAAEAoYo9S2PphpMs8M/Ng8xBxQlltq7ZET1/jO+lahHvx85Z4r+g+xzDxb8Kdj4aQ7+w==", "713a995a-0748-4a52-b1e7-30426579f195" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5436aeb6-34ac-90f0-860f-e446d23252e4", 0, "9c7271f7-0832-4780-a789-06e40c74dc24", "customer@localhost.com", true, "Customer", "User", false, null, "CUSTOMER@LOCALHOST.COM", "CUSTOMER@LOCALHOST.COM", "AQAAAAIAAYagAAAAECmyHjjO1tkPHvs1JM2ysrcvlfH8ksMCS6BZ/I9GELY5pIKfYY4M9MAlem2Vdw/+9g==", null, false, "b9ec427a-0ff8-4698-85e6-d685ce0bb379", false, "customer@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 9, 58, 19, 132, DateTimeKind.Local).AddTicks(670), new DateTime(2025, 1, 10, 9, 58, 19, 132, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 9, 58, 19, 132, DateTimeKind.Local).AddTicks(674), new DateTime(2025, 1, 10, 9, 58, 19, 132, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 9, 58, 19, 132, DateTimeKind.Local).AddTicks(430), new DateTime(2025, 1, 10, 9, 58, 19, 132, DateTimeKind.Local).AddTicks(439) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7fe12a5-953e-4bc8-bcb4-7beda0dd11f4", "AQAAAAIAAYagAAAAEEpQMjiLOTLtlV838oQhsr0bnYCKs6UM27CFE6H92Y+EOqsC4g56QaAfI1Nrb5C28A==", "d06250ad-59c9-4258-977a-c5f81dd91b23" });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 9, 47, 1, 297, DateTimeKind.Local).AddTicks(6281), new DateTime(2025, 1, 10, 9, 47, 1, 297, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 9, 47, 1, 297, DateTimeKind.Local).AddTicks(6284), new DateTime(2025, 1, 10, 9, 47, 1, 297, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 10, 9, 47, 1, 297, DateTimeKind.Local).AddTicks(6068), new DateTime(2025, 1, 10, 9, 47, 1, 297, DateTimeKind.Local).AddTicks(6078) });
        }
    }
}
