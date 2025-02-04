using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class tryNew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "738fd5d6-18fd-4450-b932-92486b165bb7", "AQAAAAIAAYagAAAAEPiQRAZpkuzmYYwdMGal6LEkIirkJQkzI9ZzVm9xRPiNJR+v3e6kh5pWqH3D+wJcRA==", "d0caf92e-7c90-4fa5-96a6-560e64ac5131" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e329c3c-b1dc-43e3-b073-a86126f9546d", "AQAAAAIAAYagAAAAEJJfyYhM4TuDHk9DCog9WkFBqK3dqmeKzPjwukeZNTTyZnFSMZwSEKdVVO+2Y+u5/w==", "365465e8-a06d-4ac3-a990-cafd1f000cd5" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(1288), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(1305), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5568), new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5589), new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5596), new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(1818), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(1831), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2983), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2989), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2991) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2995), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2997) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3001), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3002) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3007), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3012), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3014) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3018), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3019) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3024), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3030), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3031) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3035), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3036) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3041), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3042) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3047), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5830), new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5839), new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2460), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2468), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2475), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2481), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2487), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2493), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2553), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2559), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2561) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2565), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2572), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2578), new DateTime(2025, 2, 5, 1, 57, 25, 551, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5083), new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5095), new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5103), new DateTime(2025, 2, 5, 1, 57, 25, 277, DateTimeKind.Local).AddTicks(5104) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "551af800-28f5-464f-8166-10558812ff9e", "AQAAAAIAAYagAAAAEOsTwd13d/uXQFY9V2pq5NqU6B+t4UBfKhmR8GOPZwbrohDfJ7iAIURk3doCIwepWQ==", "3a00206d-51e3-4c0a-8a1d-f5d91ae25c15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e771698-1fbb-4535-a741-a65e61a6d224", "AQAAAAIAAYagAAAAEPAFM0XLOvNqqof6FE8s2yTP8aH5U4pYRwbWR3vla1f230ulL1nhfgvvtbcKUJhvBQ==", "951b2705-3b70-40a7-a7be-98613ed7ab85" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9274), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9281), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9282) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7425), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7434), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7434) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7437), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9471), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9475), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9827), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9828) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9830), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9833), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9835), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9838), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9840), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9842), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9845), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9847), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9849), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9852), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9854), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7593), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7596), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9624), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9628), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9630), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9632), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9633) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9635), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9637), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9668), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9669) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9671), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9671) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9673), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9675), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9677), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7181), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7187), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7190), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7190) });
        }
    }
}
