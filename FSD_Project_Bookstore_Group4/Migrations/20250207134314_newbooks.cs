using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class newbooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57e08428-97d3-4b69-b0ba-afa8b0f9be59", "AQAAAAIAAYagAAAAEEttUxP/gEuzfb5mDf89cZ/tCfPMx0OyALG1EMXqBTIDvGAt/wSx08w5ydBfB64XeQ==", "a376ae0f-92ce-4fa8-9ddb-311af5f75d3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c63d326e-2c0b-41f2-b3ea-70bfa679a5e1", "AQAAAAIAAYagAAAAEME0dgyDLxLLYfUEfDxDcpJ0pDQDmxIGXS7KyLOA4LYQlAt5fxI1E8FLA2cd17YyjA==", "bdbabd46-e16c-4fe9-ae12-edc86b1052c7" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5686), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5692), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5695), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5696) });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "AurthorDOB", "AuthorBio", "AuthorName", "CreatedBy", "DateCreated", "DateUpdate", "ImgLink", "UpdatedBy" },
                values: new object[] { 4, new DateTime(1951, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Hardress Wilfred Lloyd is a British comedy writer and television producer. ", "John Lloyd", null, new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5699), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5699), "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/John_lloyd_secret_comedy_podcast.jpg/1280px-John_lloyd_secret_comedy_podcast.jpg", null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4337), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4349), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4353), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4355), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "BookDesc", "BookPrice", "BookPublishDate", "BookTitle", "CreatedBy", "DateCreated", "DateUpdate", "ImgLink", "PublisherId", "UpdatedBy" },
                values: new object[,]
                {
                    { 5, "The book is a \"dictionary of things that there aren't any words for yet\". Rather than inventing new words, Adams and Lloyd picked a number of existing place-names and assigned interesting meanings to them, meanings that can be regarded as on the verge of social existence and ready to become recognisable entities.", 13.99f, new DateTime(1983, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Meaning of Liff", null, new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4358), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4359), "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9e/The_Meaning_of_Liff_1983_cover_with_sticker.jpg/800px-The_Meaning_of_Liff_1983_cover_with_sticker.jpg", 1, null },
                    { 6, "Animal Farm is a satirical allegorical novella, in the form of a beast fable, by George Orwell, first published in England on 17 August 1945. It tells the story of a group of anthropomorphic farm animals who rebel against their human farmer, hoping to create a society where the animals can be equal, free, and happy. Ultimately, the rebellion is betrayed, and under the dictatorship of a pig named Napoleon, the farm ends up in a state far worse than before. ", 5.99f, new DateTime(1945, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Animal Farm", null, new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4361), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4361), "https://upload.wikimedia.org/wikipedia/commons/f/fb/Animal_Farm_-_1st_edition.jpg", 3, null }
                });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5802), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5802) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5805), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5806), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6089), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6091), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6093), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6094), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6095) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6096), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6097), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6099), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6101), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6101) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6102), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6103) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6104), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6105), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6107), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4474), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4477), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4481), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4483), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5957), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5960), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5962), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5963), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5965), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5967), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5968), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5970), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5972), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5973), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5975), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4058), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4065), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4068), new DateTime(2025, 2, 7, 21, 43, 13, 72, DateTimeKind.Local).AddTicks(4068) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6227), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "Id", "AuthorId", "BookId", "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[,]
                {
                    { 4, 1, 5, null, new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5808), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5808), null },
                    { 5, 4, 5, null, new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5818), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5818), null },
                    { 6, 2, 6, null, new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5820), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(5834), null }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "BookId", "CreatedBy", "DateCreated", "DateUpdate", "GenreId", "UpdatedBy" },
                values: new object[,]
                {
                    { 13, 6, "System", new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6109), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6109), 6, "System" },
                    { 14, 6, "System", new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6110), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6111), 9, "System" },
                    { 15, 6, "System", new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6112), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6112), 1, "System" },
                    { 16, 5, "System", new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6113), new DateTime(2025, 2, 7, 21, 43, 13, 213, DateTimeKind.Local).AddTicks(6114), 4, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c466d24-b516-486d-9d0f-93839b084a9a", "AQAAAAIAAYagAAAAEI/lBDbBsx5DbnJQp1K9CqRDIqv0fiN2agbLRyBjg+4FOs1lFJVtiZKYwxin+x+32w==", "6e2a5557-df2a-4875-815b-4f1d7b558141" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a373ac9f-f0f9-48b3-897b-caf91dec15b7", "AQAAAAIAAYagAAAAEMkrzNclJv4Fsa/c5Bo7gcu5orUFnJ7NwFWR/L31ibELUYK9sfQWeSt/oQi9X8T+nQ==", "5b567e0d-5f02-4827-9e47-0122c8334e69" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3282), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3296), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3304), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3181), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3192), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3198), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3204), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3598), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3607), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3612), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4382), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4388), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4393), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4395) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4398), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4403), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4408), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4412), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4417), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4418) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4421), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4422) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4426), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4430), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4435), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4436) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3509), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3515), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3516) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3520), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3521) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3524), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(3525) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3923), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3929), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3934), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3939), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3973), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3974) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3978), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3979) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3983), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3987), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3988) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3992), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3993) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3996), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4001), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4002) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2697), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2708), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2714), new DateTime(2025, 2, 7, 15, 49, 34, 895, DateTimeKind.Local).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4735), new DateTime(2025, 2, 7, 15, 49, 35, 135, DateTimeKind.Local).AddTicks(4737) });
        }
    }
}
