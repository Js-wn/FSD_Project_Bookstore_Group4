using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
               table: "Customer",
               name: "AuthCustId",
               type: "nvarchar(max)"
               );
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1d3b559-09a0-4850-80cf-47eb7fdc8819", "AQAAAAIAAYagAAAAELOUOYV22O1nbgbernfks/1+TFWmSwBd4Iul3DzkDNMGd7vOIdlriuSXLVFKi4pLUg==", "bc98b6c9-1b4c-4933-8532-cccd688e5a22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9cf0e51-2418-4206-b1eb-bf725c5e041d", "AQAAAAIAAYagAAAAEOVRxIkKf1EuSfp7nloEl4NdPka9K7z7vpTBb/nirW+haBTdVcrQzb56VqjgHfnmMQ==", "d4b98935-bfdc-4552-9291-54d82e798d50" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(525), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(525) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(531), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9742), new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9743) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9748), new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9751), new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(638), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "BookAuthor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(641), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(872), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(874), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(876), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(876) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(877), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(879), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(880), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(882), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(883), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(885), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(886), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(888), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                table: "BookGenre",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(889), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9824), new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9825) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9829), new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9831), new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9831) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9832), new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9833) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(724), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(724) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(726), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(728), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(728) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(729), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(731), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(732), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(734), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(735), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(737), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(738), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(740), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9550), new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9551) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9559), new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9561), new DateTime(2025, 2, 6, 21, 6, 27, 260, DateTimeKind.Local).AddTicks(9561) });

            migrationBuilder.UpdateData(
                table: "SubscriptionTier",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(988), new DateTime(2025, 2, 6, 21, 6, 27, 379, DateTimeKind.Local).AddTicks(988) });
        }
    }
}
