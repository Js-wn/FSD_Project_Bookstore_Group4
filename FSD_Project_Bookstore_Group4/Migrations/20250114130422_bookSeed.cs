using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FSD_Project_Bookstore_Group4.Migrations
{
    /// <inheritdoc />
    public partial class bookSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fd29395-2df8-48db-ad2a-dfe64759aa4e", "AQAAAAIAAYagAAAAEBjIQipbhdHubIKRkF0YilyD5Pw31PaWDUCN8Yux5SmmU6CbJJZNCtXD5ySuOfnk1A==", "bd640aad-f300-4e7a-8d06-06cb674bc6b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5436aeb6-34ac-90f0-860f-e446d23252e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1a35a38-72c2-4f28-9399-775cc223cd23", "AQAAAAIAAYagAAAAEFOBrBv4B7hc3er2EyMCv5adD/jUriEfIrlgSTvpccwik/O3BVXCokWbSuAGPiT5tw==", "c17721ca-f80a-4fd4-bfb5-911592cf69be" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "BookCoverImg", "BookDesc", "BookPrice", "BookPublishDate", "BookTitle", "CreatedBy", "DateCreated", "DateUpdate", "PublisherId", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "", " In one complete volume, here are the five classic novels from Douglas Adams’s beloved Hitchhiker series.\r\n\r\nNow celebrating the pivotal 42nd anniversary of The Hitchhiker’s Guide to the Galaxy, soon to be a Hulu original series!\r\n\r\nThe Hitchhiker’s Guide to the Galaxy (Nominated as one of America’s best-loved novels by PBS’s The Great American Read)\r\nSeconds before the Earth is demolished for a galactic freeway, Arthur Dent is saved by Ford Prefect, a researcher for the revised Guide. Together they stick out their thumbs to the stars and begin a wild journey through time and space.\r\n\r\nThe Restaurant at the End of the Universe\r\nThe moment before annihilation at the hands of warmongers is a curious time to crave tea. It could only happen to the cosmically displaced Arthur Dent and his comrades as they hurtle across the galaxy in a desperate search for a place to eat.\r\n\r\nLife, the Universe and Everything\r\nThe unhappy inhabitants of planet Krikkit are sick of looking at the night sky– so they plan to destroy it. The universe, that is. Now only five individuals can avert Armageddon: mild-mannered Arthur Dent and his stalwart crew.\r\n\r\nSo Long, and Thanks for All the Fish\r\nBack on Earth, Arthur Dent is ready to believe that the past eight years were all just a figment of his stressed-out imagination. But a gift-wrapped fishbowl with a cryptic inscription thrusts him back to reality. So to speak.\r\n\r\nMostly Harmless\r\nJust when Arthur Dent makes the terrible mistake of starting to enjoy life, all hell breaks loose. Can he save the Earth from total obliteration? Can he save the Guide from a hostile alien takeover? Can he save his daughter from herself?\r\n\r\nIncludes the bonus story “Young Zaphod Plays It Safe”\r\n\r\n“With droll wit, a keen eye for detail and heavy doses of insight . . . Adams makes us laugh until we cry.”―San Diego Union-Tribune\r\n\r\n“Lively, sharply satirical, brilliantly written . . . ranks with the best set pieces in Mark Twain.”―The Atlantic ", 26.65f, new DateTime(2002, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Ultimate Hitchhiker's Guide to the Galaxy: Five Novels in One Outrageous Volume", null, new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1841), new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1842), 2, null },
                    { 2, "", "A masterpiece of rebellion and imprisonment where war is peace freedom is slavery and Big Brother is watching. Thought Police, Big Brother, Orwellian - these words have entered our vocabulary because of George Orwell's classic dystopian novel 1984. The story of one man's Nightmare Odyssey as he pursues a forbidden love affair through a world ruled by warring states and a power structure that controls not only information but also individual thought and memory 1984 is a prophetic haunting tale More relevant than ever before 1984 exposes the worst crimes imaginable the destruction of truth freedom and individuality. With a foreword by Thomas Pynchon. This beautiful paperback edition features deckled edges and french flaps a perfect gift for any occasion", 9.99f, new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nineteen Eighty-Four", null, new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1846), new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1846), 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1911), new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1913), new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1523), new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1588), new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1591), new DateTime(2025, 1, 14, 21, 4, 22, 80, DateTimeKind.Local).AddTicks(1591) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8384), new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdate" },
                values: new object[] { new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8386), new DateTime(2025, 1, 14, 21, 3, 8, 396, DateTimeKind.Local).AddTicks(8386) });
        }
    }
}
