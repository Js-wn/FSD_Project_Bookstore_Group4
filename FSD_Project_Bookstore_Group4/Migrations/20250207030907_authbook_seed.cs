using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class authbook_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fa4966c-0ab4-4746-802a-e60a122c2c32", "AQAAAAIAAYagAAAAEAJkSPlT5Umer0OJrAbelgvcW+f4h2Gd6/Qzfed6/ltybfjE36/t0nC1BqvxeEGt5Q==", "37d6caf3-a8ff-4dd5-a17c-99ac278869f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f2d9822-c8c1-41b1-9d27-be6c1b66156d", "AQAAAAIAAYagAAAAEAUZ4yKy4iiZFPD59q8mb385sxqIcLyO78PrBukEdX+DHi/7C1yXnUlG31dlC3lYAQ==", "67403401-ebb3-445b-a1b6-3131bf7cb6d0" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5110), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5118), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "AurthorDOB", "AuthorBio", "AuthorName", "CreatedBy", "DateCreated", "DateUpdate", "ImgLink", "UpdatedBy" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1956), "David Alderton is an English writer specialising in pets and natural history topics. Growing up in a home surrounded by pets, he originally trained to become a veterinary surgeon. An allergic dermatitis acquired in his final year of study forced a change of career however, and so led him into the field of writing about pets and their care. He has since become a regular contributor of articles on this subject to a wide range of newspapers and magazines in the UK and abroad, and also participates frequently in radio and television programmes.", "David Alderton", null, new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5122), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5123), "https://m.media-amazon.com/images/S/amzn-author-media-prod/m84i99ih3q7o6ec59b5ftmhijp._SX272_CR0%2C0%2C272%2C272_.jpg", null });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7452), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7463), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7466), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "BookDesc", "BookPrice", "BookPublishDate", "BookTitle", "CreatedBy", "DateCreated", "DateUpdate", "ImgLink", "PublisherId", "UpdatedBy" },
                values: new object[] { 4, "Features the birds of the Americas, Europe, Africa, Asia, Australia and the Polar regions, with analyses of size, shape, plumage, habitat, breeding, nests, eggs and food. Explores key habitats such as the ocean, seashore, estuaries, lakes, ponds and rivers, woodland, open country, and cities and gardens.", 41.07f, new DateTime(2018, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Complete Illustrated Encyclopedia of Birds of the World: A Detailed Visual Reference Guide to 1600 Birds and Their Habitats, Shown in More Than 1800 Pictures", null, new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7469), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7469), "https://m.media-amazon.com/images/I/61wRoaVqXyL._SY385_.jpg", 1, null });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5317), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5321), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5321) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5999), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6003), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6005), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6007), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6010), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6012), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6013) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6014), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6015) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6017), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6017) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6019), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6019) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6021), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6022) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6023), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6026), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7573), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7576), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7578), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7580), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5787), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5791), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5791) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5793), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5796), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5818), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5821), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5823), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5825), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5827), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5829), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5832), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5832) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7198), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7204), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7207), new DateTime(2025, 2, 7, 11, 9, 5, 523, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6179), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "Id", "AuthorId", "BookId", "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[] { 3, 3, 4, null, new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5323), new DateTime(2025, 2, 7, 11, 9, 5, 682, DateTimeKind.Local).AddTicks(5324), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed6aa851-e426-4abd-83d2-81e5930760b5", "AQAAAAIAAYagAAAAEENm94+9HmyMdz2t/KLSpkSJpBZxwu37MJEA/EGuWenPjX9Pk/rPzvRgdmYebNwjMQ==", "e20713b8-2ba8-4347-b402-baabbef49a6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae5e832b-f5ba-4478-a23a-756decaeef4c", "AQAAAAIAAYagAAAAEHwI9FuW2e8uiaDTxicXpsVRRKg9zyM62Sq2lpU/O40ih3Mh7e9VVB2JHXuQmjI8/Q==", "110226dc-41a6-414c-a33a-e8560c92fab0" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3406), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3412), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3073), new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3077), new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3080), new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3548), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3552), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4134), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4136), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4137) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4138), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4139) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4140), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4141), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4143), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4145), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4146), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4147) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4148), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4150), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4151), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4152) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4153), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4153) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3151), new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3153), new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3155), new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3157), new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3938), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3941), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3943), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3945), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3945) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3946), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3948), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3956) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3962), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3964), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3966), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3968), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3969), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(2902), new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(2907), new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(2910), new DateTime(2025, 2, 6, 21, 33, 32, 31, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4292), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(4292) });
        }
    }
}
