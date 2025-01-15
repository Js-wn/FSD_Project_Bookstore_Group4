using FSD_Project_Bookstore_Group4.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FSD_Project_Bookstore_Group4.Configurations.Entities
{
    public class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {   
                    Id = 1,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    BookTitle = "The Ultimate Hitchhiker's Guide to the Galaxy: Five Novels in One Outrageous Volume",
                    BookDesc  = " In one complete volume, here are the five classic novels from Douglas Adams’s beloved Hitchhiker series.\r\n\r\nNow celebrating the pivotal 42nd anniversary of The Hitchhiker’s Guide to the Galaxy, soon to be a Hulu original series!\r\n\r\nThe Hitchhiker’s Guide to the Galaxy (Nominated as one of America’s best-loved novels by PBS’s The Great American Read)\r\nSeconds before the Earth is demolished for a galactic freeway, Arthur Dent is saved by Ford Prefect, a researcher for the revised Guide. Together they stick out their thumbs to the stars and begin a wild journey through time and space.\r\n\r\nThe Restaurant at the End of the Universe\r\nThe moment before annihilation at the hands of warmongers is a curious time to crave tea. It could only happen to the cosmically displaced Arthur Dent and his comrades as they hurtle across the galaxy in a desperate search for a place to eat.\r\n\r\nLife, the Universe and Everything\r\nThe unhappy inhabitants of planet Krikkit are sick of looking at the night sky– so they plan to destroy it. The universe, that is. Now only five individuals can avert Armageddon: mild-mannered Arthur Dent and his stalwart crew.\r\n\r\nSo Long, and Thanks for All the Fish\r\nBack on Earth, Arthur Dent is ready to believe that the past eight years were all just a figment of his stressed-out imagination. But a gift-wrapped fishbowl with a cryptic inscription thrusts him back to reality. So to speak.\r\n\r\nMostly Harmless\r\nJust when Arthur Dent makes the terrible mistake of starting to enjoy life, all hell breaks loose. Can he save the Earth from total obliteration? Can he save the Guide from a hostile alien takeover? Can he save his daughter from herself?\r\n\r\nIncludes the bonus story “Young Zaphod Plays It Safe”\r\n\r\n“With droll wit, a keen eye for detail and heavy doses of insight . . . Adams makes us laugh until we cry.”―San Diego Union-Tribune\r\n\r\n“Lively, sharply satirical, brilliantly written . . . ranks with the best set pieces in Mark Twain.”―The Atlantic ",
                    ImgId = 1,
                    BookPublishDate = new DateTime(2002,04,30),
                    BookPrice = 26.65f,
                    PublisherId = 2
                },
                new Book
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    BookTitle = "Nineteen Eighty-Four",
                    BookDesc = "A masterpiece of rebellion and imprisonment where war is peace freedom is slavery and Big Brother is watching. Thought Police, Big Brother, Orwellian - these words have entered our vocabulary because of George Orwell's classic dystopian novel 1984. The story of one man's Nightmare Odyssey as he pursues a forbidden love affair through a world ruled by warring states and a power structure that controls not only information but also individual thought and memory 1984 is a prophetic haunting tale More relevant than ever before 1984 exposes the worst crimes imaginable the destruction of truth freedom and individuality. With a foreword by Thomas Pynchon. This beautiful paperback edition features deckled edges and french flaps a perfect gift for any occasion",
                    ImgId = 1,
                    BookPublishDate = new DateTime(1949, 06, 8),
                    BookPrice = 9.99f,
                    PublisherId = 3
                }


                );
        }
    }
}
