using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class authorImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgLink",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "DateCreated", "DateUpdate", "ImgLink" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3406), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3406), "https://upload.wikimedia.org/wikipedia/commons/c/c0/Douglas_adams_portrait_cropped.jpg" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate", "ImgLink" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3412), new DateTime(2025, 2, 6, 21, 33, 32, 155, DateTimeKind.Local).AddTicks(3412), "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7e/George_Orwell_press_photo.jpg/1024px-George_Orwell_press_photo.jpg" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgLink",
                table: "Author");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d178b860-806d-450f-a3ce-db2e30d331f7", "AQAAAAIAAYagAAAAEK7mf+6JobmMU7Mta1KHp1JlZnFsaktyOcibG4xIyPKxBSBKc70zhchJrHdylEtZbg==", "f250ba45-8318-442a-941d-ba9cb01714ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "074a193f-1b17-49bd-89dd-c56077f67ee4", "AQAAAAIAAYagAAAAECFjE27nYin0SFduRWMixBg+DGDxBktAgdvF1HjWi/6OgFleN3GJeEGGOdqR4EvJag==", "ab203bfd-bb7d-4731-94c6-16571d1a976b" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(3182), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(3191), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8924), new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8924) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8930), new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8932), new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(3719), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(3736), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4174), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4176), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4178), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4180), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4181), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4182) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4183), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4183) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4185), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4186), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4188), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4190), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4191), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4193), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(9005), new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(9008), new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(9009), new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(9011), new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4045), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4048), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4050), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4051), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4053), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4053) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4054), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4073), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4074), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4076), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4077), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4079), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8759), new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8764), new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8766), new DateTime(2025, 2, 6, 21, 13, 20, 116, DateTimeKind.Local).AddTicks(8766) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4315), new DateTime(2025, 2, 6, 21, 13, 20, 231, DateTimeKind.Local).AddTicks(4316) });
        }
    }
}
