using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AurthorDOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorBio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenreDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionTier",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TierName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cost = table.Column<float>(type: "real", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionTier", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookPublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookPrice = table.Column<float>(type: "real", nullable: false),
                    ImgLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    table.ForeignKey(
                        name: "FK_BookAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_BookGenre_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookGenre_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPoints = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    OrderItemId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IsInCart = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TierId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubscriptionInfo_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubscriptionInfo_SubscriptionTier_TierId",
                        column: x => x.TierId,
                        principalTable: "SubscriptionTier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_OrderItem_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    SubscriptionInfoId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    TierId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payment_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Payment_SubscriptionInfo_SubscriptionInfoId",
                        column: x => x.SubscriptionInfoId,
                        principalTable: "SubscriptionInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_SubscriptionTier_TierId",
                        column: x => x.TierId,
                        principalTable: "SubscriptionTier",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewRating = table.Column<float>(type: "real", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    OrderItemId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Review_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_OrderItem_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItem",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "551af800-28f5-464f-8166-10558812ff9e", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEOsTwd13d/uXQFY9V2pq5NqU6B+t4UBfKhmR8GOPZwbrohDfJ7iAIURk3doCIwepWQ==", null, false, "3a00206d-51e3-4c0a-8a1d-f5d91ae25c15", false, "admin@localhost.com" },
                    { "5436aeb6-34ac-90f0-860f-e446d23252e4", 0, "3e771698-1fbb-4535-a741-a65e61a6d224", "customer@localhost.com", true, "Customer", "User", false, null, "CUSTOMER@LOCALHOST.COM", "CUSTOMER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPAFM0XLOvNqqof6FE8s2yTP8aH5U4pYRwbWR3vla1f230ulL1nhfgvvtbcKUJhvBQ==", null, false, "951b2705-3b70-40a7-a7be-98613ed7ab85", false, "customer@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "AurthorDOB", "AuthorBio", "AuthorName", "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(1952, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Douglas Noel Adams was an English author, humourist, and screenwriter, best known as the creator of The Hitchhiker's Guide to the Galaxy. Originally a 1978 BBC radio comedy, The Hitchhiker's Guide to the Galaxy developed into a \"trilogy\" of five books which sold more than 15 million copies in his lifetime.", "Douglas Adams", null, new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9274), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9274), null },
                    { 2, new DateTime(1903, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eric Arthur Blair was an English novelist, poet, essayist, journalist and critic who wrote under the pen name of George Orwell. His work is characterised by lucid prose, social criticism, opposition to all totalitarianism, and support of democratic socialism.", "George Orwell", null, new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9281), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9282), null }
                });

            migrationBuilder.InsertData(
                table: "Gender",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "GenderId", "GenderName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7593), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7593), 0, "Male", "System" },
                    { 2, "System", new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7596), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7597), 0, "Female", "System" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "GenreDesc", "GenreName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9624), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9625), "Fiction is any creative work, chiefly any narrative work, portraying individuals, events, or places that are imaginary or in ways that are imaginary.", "Fiction", "System" },
                    { 2, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9628), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9628), "Non-fiction (or nonfiction) is any document or media content that attempts, in good faith, to convey information only about the real world, rather than being grounded in imagination.", "Non-fiction", "System" },
                    { 3, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9630), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9631), "Science fiction (sometimes shortened to sci-fi or abbreviated SF) is a genre of speculative fiction which typically deals with imaginative and futuristic concepts such as advanced science and technology, space exploration, time travel, parallel universes, and extraterrestrial life.", "Science fiction", "System" },
                    { 4, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9632), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9633), "Comedy is a genre that consists of discourses or works intended to be humorous or amusing by inducing laughter, especially in theatre, film, stand-up comedy, television, radio, books, or any other entertainment medium.", "Comedy", "System" },
                    { 5, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9635), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9636), "Utopian and dystopian fiction are subgenres of speculative fiction that explore social and political structures. Utopian fiction portrays a setting that agrees with the author's ethos, having various attributes of another reality intended to appeal to readers. ", "Dystopian Fiction", "System" },
                    { 6, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9637), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9653), "Political fiction employs narrative to comment on political events, systems and theories. Works of political fiction, such as political novels, often \"directly criticize an existing society or present an alternative, even fantastic, reality\".", "Political fiction", "System" },
                    { 7, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9668), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9669), "Social science fiction is a subgenre of science fiction, usually (but not necessarily) soft science fiction, concerned less with technology or space opera and more with speculation about society. In other words, it \"absorbs and discusses anthropology\" and speculates about human behavior and interactions.", "Social science fiction", "System" },
                    { 8, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9671), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9671), "Transgressive fiction is a genre of literature which focuses on characters who feel confined by the norms and expectations of society and who break free of those confines in unusual or illicit ways.", "Transgressive fiction", "System" },
                    { 9, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9673), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9673), "Satire is a genre of the visual, literary, and performing arts, usually in the form of fiction and less frequently non-fiction, in which vices, follies, abuses, and shortcomings are held up to ridicule, often with the intent of exposing or shaming the perceived flaws of individuals, corporations, government, or society itself into improvement.", "Satire", "System" },
                    { 10, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9675), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9676), "Black comedy, also known as black humor, bleak comedy, dark comedy, dark humor, gallows humor or morbid humor, is a style of comedy that makes light of subject matter that is generally considered taboo, particularly subjects that are normally considered serious or painful to discuss.", "Black comedy", "System" },
                    { 11, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9677), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9678), "Horror is a genre of speculative fiction that is intended to disturb, frighten, or scare.[1] Horror is often divided into the sub-genres of psychological horror and supernatural horror.", "Horror", "System" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdate", "PublisherAddress", "PublisherContact", "PublisherEmail", "PublisherName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7181), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7182), "123 street", "11111111", "example@gmail.com", "PlaceHolder", "System" },
                    { 2, "System", new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7187), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7187), "6 Briset Street", "0207 038 5000", "webqueries@macmillan.co.uk", "Pan Books", "System" },
                    { 3, "System", new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7190), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7190), " 8 Viaduct Gardens", "+44 (0)20 7139 3000", "VintagePublicity@penguinrandomhouse.co.uk", "Harvill Secker", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "5436aeb6-34ac-90f0-860f-e446d23252e4" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "BookDesc", "BookPrice", "BookPublishDate", "BookTitle", "CreatedBy", "DateCreated", "DateUpdate", "ImgLink", "PublisherId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, " In one complete volume, here are the five classic novels from Douglas Adams’s beloved Hitchhiker series.\r\n\r\nNow celebrating the pivotal 42nd anniversary of The Hitchhiker’s Guide to the Galaxy, soon to be a Hulu original series!\r\n\r\nThe Hitchhiker’s Guide to the Galaxy (Nominated as one of America’s best-loved novels by PBS’s The Great American Read)\r\nSeconds before the Earth is demolished for a galactic freeway, Arthur Dent is saved by Ford Prefect, a researcher for the revised Guide. Together they stick out their thumbs to the stars and begin a wild journey through time and space.\r\n\r\nThe Restaurant at the End of the Universe\r\nThe moment before annihilation at the hands of warmongers is a curious time to crave tea. It could only happen to the cosmically displaced Arthur Dent and his comrades as they hurtle across the galaxy in a desperate search for a place to eat.\r\n\r\nLife, the Universe and Everything\r\nThe unhappy inhabitants of planet Krikkit are sick of looking at the night sky– so they plan to destroy it. The universe, that is. Now only five individuals can avert Armageddon: mild-mannered Arthur Dent and his stalwart crew.\r\n\r\nSo Long, and Thanks for All the Fish\r\nBack on Earth, Arthur Dent is ready to believe that the past eight years were all just a figment of his stressed-out imagination. But a gift-wrapped fishbowl with a cryptic inscription thrusts him back to reality. So to speak.\r\n\r\nMostly Harmless\r\nJust when Arthur Dent makes the terrible mistake of starting to enjoy life, all hell breaks loose. Can he save the Earth from total obliteration? Can he save the Guide from a hostile alien takeover? Can he save his daughter from herself?\r\n\r\nIncludes the bonus story “Young Zaphod Plays It Safe”\r\n\r\n“With droll wit, a keen eye for detail and heavy doses of insight . . . Adams makes us laugh until we cry.”―San Diego Union-Tribune\r\n\r\n“Lively, sharply satirical, brilliantly written . . . ranks with the best set pieces in Mark Twain.”―The Atlantic ", 26.65f, new DateTime(2002, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ultimate Hitchhiker's Guide to the Galaxy: Five Novels in One Outrageous Volume", null, new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7425), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7425), "https://m.media-amazon.com/images/I/91Mu7rVLIFL.jpg", 2, null },
                    { 2, "A masterpiece of rebellion and imprisonment where war is peace freedom is slavery and Big Brother is watching. Thought Police, Big Brother, Orwellian - these words have entered our vocabulary because of George Orwell's classic dystopian novel 1984. The story of one man's Nightmare Odyssey as he pursues a forbidden love affair through a world ruled by warring states and a power structure that controls not only information but also individual thought and memory 1984 is a prophetic haunting tale More relevant than ever before 1984 exposes the worst crimes imaginable the destruction of truth freedom and individuality. With a foreword by Thomas Pynchon. This beautiful paperback edition features deckled edges and french flaps a perfect gift for any occasion", 9.99f, new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nineteen Eighty-Four", null, new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7434), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7434), "https://m.media-amazon.com/images/I/612ADI+BVlL.jpg", 3, null },
                    { 3, "Patrick Bateman moves among the young and trendy in 1980s Manhattan. Young, handsome, and well educated, Bateman earns his fortune on Wall Street by day while spending his nights in ways we cannot begin to fathom. Expressing his true self through torture and murder, Bateman prefigures an apocalyptic horror that no society could bear to confront.", 23.99f, new DateTime(1991, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Psycho", null, new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7437), new DateTime(2025, 2, 3, 8, 33, 28, 878, DateTimeKind.Local).AddTicks(7437), "https://m.media-amazon.com/images/I/7150fwe2f9L._SL1200_.jpg", 1, null }
                });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "Id", "AuthorId", "BookId", "CreatedBy", "DateCreated", "DateUpdate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, 1, null, new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9471), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9471), null },
                    { 2, 2, 2, null, new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9475), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9475), null }
                });

            migrationBuilder.InsertData(
                table: "BookGenre",
                columns: new[] { "Id", "BookId", "CreatedBy", "DateCreated", "DateUpdate", "GenreId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9827), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9828), 1, "System" },
                    { 2, 1, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9830), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9831), 3, "System" },
                    { 3, 1, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9833), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9833), 4, "System" },
                    { 4, 2, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9835), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9836), 1, "System" },
                    { 5, 2, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9838), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9838), 5, "System" },
                    { 6, 2, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9840), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9840), 6, "System" },
                    { 7, 2, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9842), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9843), 7, "System" },
                    { 8, 3, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9845), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9845), 1, "System" },
                    { 9, 3, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9847), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9847), 8, "System" },
                    { 10, 3, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9849), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9850), 9, "System" },
                    { 11, 3, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9852), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9852), 10, "System" },
                    { 12, 3, "System", new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9854), new DateTime(2025, 2, 3, 8, 33, 29, 46, DateTimeKind.Local).AddTicks(9854), 11, "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_BookId",
                table: "BookAuthor",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_BookId",
                table: "BookGenre",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookGenre_GenreId",
                table: "BookGenre",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_GenderId",
                table: "Customer",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_OrderItemId",
                table: "Customer",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_BookId",
                table: "OrderItem",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerId",
                table: "Payment",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderId",
                table: "Payment",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_SubscriptionInfoId",
                table: "Payment",
                column: "SubscriptionInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_TierId",
                table: "Payment",
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
                name: "IX_SubscriptionInfo_CustomerId",
                table: "SubscriptionInfo",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_SubscriptionInfo_TierId",
                table: "SubscriptionInfo",
                column: "TierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customer_OrderItem_OrderItemId",
                table: "Customer",
                column: "OrderItemId",
                principalTable: "OrderItem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Book_BookId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_Gender_GenderId",
                table: "Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Customer_OrderItem_OrderItemId",
                table: "Customer");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "BookGenre");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Review");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "SubscriptionInfo");

            migrationBuilder.DropTable(
                name: "SubscriptionTier");

            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
