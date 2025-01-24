using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class bookUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAurthor");

            migrationBuilder.DropColumn(
                name: "ImgId",
                table: "Book");

            migrationBuilder.AddColumn<string>(
                name: "ImgLink",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookAuthor",
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
                    table.PrimaryKey("PK_BookAuthor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookGenre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderQty = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentAmountBefDiscount = table.Column<float>(type: "real", nullable: false),
                    PaymentAmountAftDiscount = table.Column<float>(type: "real", nullable: false),
                    SubscriptionId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    TierId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

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
                columns: new[] { "DateCreated", "DateUpdate", "ImgLink" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3099), new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3100), "https://m.media-amazon.com/images/I/91Mu7rVLIFL.jpg" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate", "ImgLink" },
                values: new object[] { new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3105), new DateTime(2025, 1, 24, 9, 22, 15, 592, DateTimeKind.Local).AddTicks(3106), "https://m.media-amazon.com/images/I/612ADI+BVlL.jpg" });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "Id", "AuthorId", "BookId", "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 1, null, new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(7018), new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(7019), null },
                    { 2, 2, 2, null, new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(7021), new DateTime(2025, 1, 24, 9, 22, 15, 760, DateTimeKind.Local).AddTicks(7022), null }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropColumn(
                name: "ImgLink",
                table: "Book");

            migrationBuilder.AddColumn<int>(
                name: "ImgId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BookAurthor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                values: new object[] { "4ed29e83-c6b5-4f56-b1f7-7c237f0e3a20", "AQAAAAIAAYagAAAAEEXVW/7Qh2hRodWX5/UT2SoV/+1ZX+IC+B+i50x1MdQz5hZ6walsGK/68mUp0XaCJg==", "5a61d292-d270-4f76-9961-942c7738f24b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c323f38c-edb4-4981-9be2-20bd82342cd9", "AQAAAAIAAYagAAAAEHcJN+2/9ztZNMj8EjMO4ozCHqwsdY8f6Efy6On9fysbAeBlsY+j3aCtbg3MCLNMOQ==", "bc2dbede-0626-4b7c-9e99-b0d0782a6403" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 353, DateTimeKind.Local).AddTicks(351), new DateTime(2025, 1, 22, 9, 56, 22, 353, DateTimeKind.Local).AddTicks(368) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 353, DateTimeKind.Local).AddTicks(376), new DateTime(2025, 1, 22, 9, 56, 22, 353, DateTimeKind.Local).AddTicks(377) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate", "ImgId" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(699), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(700), 1 });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate", "ImgId" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(708), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(708), 1 });

            migrationBuilder.InsertData(
                table: "BookAurthor",
                columns: new[] { "Id", "AuthorId", "BookId", "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 1, null, new DateTime(2025, 1, 22, 9, 56, 22, 354, DateTimeKind.Local).AddTicks(759), new DateTime(2025, 1, 22, 9, 56, 22, 354, DateTimeKind.Local).AddTicks(762), null },
                    { 2, 2, 2, null, new DateTime(2025, 1, 22, 9, 56, 22, 354, DateTimeKind.Local).AddTicks(765), new DateTime(2025, 1, 22, 9, 56, 22, 354, DateTimeKind.Local).AddTicks(766), null }
                });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(902), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(905), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(416), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(439), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(440) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(442), new DateTime(2025, 1, 22, 9, 56, 22, 254, DateTimeKind.Local).AddTicks(442) });
        }
    }
}
