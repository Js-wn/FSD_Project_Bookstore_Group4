using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class AuthorSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookAurthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAurthor", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c55ff1d-72d6-47c1-9728-19ce3919e9a0", "AQAAAAIAAYagAAAAEDBihIV+yRqQ3ccYdO2utAY/+iEXBfW+aLyoHtHWvhg2CMvciNFyMPX+X+jZFC/Jmw==", "eab559ba-3faa-4907-8ade-4576c45041c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6aa26f2e-c25f-481e-8037-728e2e95d20b", "AQAAAAIAAYagAAAAEJDkxLUMpi9KTUgLnd2Pc+mzhK3Mulz4jtBGyyz7t6gyfVJHpt5qeajla0VSJDuqYw==", "dbbad9c8-855c-4a4d-985f-f9376b5b5d34" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "AurthorDOB", "AuthorBio", "AuthorName", "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(1952, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Douglas Noel Adams was an English author, humourist, and screenwriter, best known as the creator of The Hitchhiker's Guide to the Galaxy. Originally a 1978 BBC radio comedy, The Hitchhiker's Guide to the Galaxy developed into a \"trilogy\" of five books which sold more than 15 million copies in his lifetime.", "Douglas Adams", null, new DateTime(2025, 1, 22, 9, 46, 36, 436, DateTimeKind.Local).AddTicks(3042), new DateTime(2025, 1, 22, 9, 46, 36, 436, DateTimeKind.Local).AddTicks(3057), null },
                    { 2, new DateTime(1903, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eric Arthur Blair was an English novelist, poet, essayist, journalist and critic who wrote under the pen name of George Orwell. His work is characterised by lucid prose, social criticism, opposition to all totalitarianism, and support of democratic socialism.", "George Orwell", null, new DateTime(2025, 1, 22, 9, 46, 36, 436, DateTimeKind.Local).AddTicks(3063), new DateTime(2025, 1, 22, 9, 46, 36, 436, DateTimeKind.Local).AddTicks(3064), null }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9366), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9374), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9374) });

            migrationBuilder.InsertData(
                table: "BookAurthor",
                columns: new[] { "Id", "AuthorId", "BookId", "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 1, null, new DateTime(2025, 1, 22, 9, 46, 36, 442, DateTimeKind.Local).AddTicks(6777), new DateTime(2025, 1, 22, 9, 46, 36, 442, DateTimeKind.Local).AddTicks(6794), null },
                    { 2, 2, 2, null, new DateTime(2025, 1, 22, 9, 46, 36, 442, DateTimeKind.Local).AddTicks(6799), new DateTime(2025, 1, 22, 9, 46, 36, 442, DateTimeKind.Local).AddTicks(6800), null }
                });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9476), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9479), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9108), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9122), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9125), new DateTime(2025, 1, 22, 9, 46, 36, 234, DateTimeKind.Local).AddTicks(9126) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAurthor");

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef232037-98b6-44c8-ae0b-9a93f2423068", "AQAAAAIAAYagAAAAEN3vw2kQL3gNdKhoxPMOIKhgTcF64W7grw9eiX9u6AbYATyFBDhFX+q4Ic6A1yuOzA==", "ed25bba3-e8a5-46cd-a360-560325d3c444" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ccd1a5b-7930-430b-a889-704aeae46257", "AQAAAAIAAYagAAAAEN0DCKSC1kSNzA1ilyasaITDSBRrL6vblxilvwR4fJvwHz09/aKIAP1uWZydFbSndw==", "8181281a-2b9b-4061-b3a9-2489d7184cc9" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(3037), new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(3044), new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(3145), new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(3147), new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(2756), new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(2774), new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(2776), new DateTime(2025, 1, 17, 11, 8, 59, 161, DateTimeKind.Local).AddTicks(2777) });
        }
    }
}
