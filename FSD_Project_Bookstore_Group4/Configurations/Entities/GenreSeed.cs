using FSD_Project_Bookstore_Group4.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project_Bookstore_Group4.Configurations.Entities
{
    public class GenreSeed : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre
                {
                    Id = 1,
                    GenreName = "Fiction",
                    GenreDesc = "Fiction is any creative work, chiefly any narrative work, portraying individuals, events, or places that are imaginary or in ways that are imaginary.",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Genre
                {
                    Id = 2,
                    GenreName = "Non-fiction",
                    GenreDesc = "Non-fiction (or nonfiction) is any document or media content that attempts, in good faith, to convey information only about the real world, rather than being grounded in imagination.",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Genre
                {
                    Id = 3,
                    GenreName = "Science fiction",
                    GenreDesc = "Science fiction (sometimes shortened to sci-fi or abbreviated SF) is a genre of speculative fiction which typically deals with imaginative and futuristic concepts such as advanced science and technology, space exploration, time travel, parallel universes, and extraterrestrial life.",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Genre
                {
                    Id = 4,
                    GenreName = "Comedy",
                    GenreDesc = "Comedy is a genre that consists of discourses or works intended to be humorous or amusing by inducing laughter, especially in theatre, film, stand-up comedy, television, radio, books, or any other entertainment medium.",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Genre
                {
                    Id = 5,
                    GenreName = "Dystopian Fiction",
                    GenreDesc = "Utopian and dystopian fiction are subgenres of speculative fiction that explore social and political structures. Utopian fiction portrays a setting that agrees with the author's ethos, having various attributes of another reality intended to appeal to readers. ",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Genre
                {
                    Id = 6,
                    GenreName = "Political fiction",
                    GenreDesc = "Political fiction employs narrative to comment on political events, systems and theories. Works of political fiction, such as political novels, often \"directly criticize an existing society or present an alternative, even fantastic, reality\".",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Genre
                {
                    Id = 7,
                    GenreName = "Social science fiction",
                    GenreDesc = "Social science fiction is a subgenre of science fiction, usually (but not necessarily) soft science fiction, concerned less with technology or space opera and more with speculation about society. In other words, it \"absorbs and discusses anthropology\" and speculates about human behavior and interactions.",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Genre
                {
                    Id = 8,
                    GenreName = "Transgressive fiction",
                    GenreDesc = "Transgressive fiction is a genre of literature which focuses on characters who feel confined by the norms and expectations of society and who break free of those confines in unusual or illicit ways.",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Genre
                {
                    Id = 9,
                    GenreName = "Satire",
                    GenreDesc = "Satire is a genre of the visual, literary, and performing arts, usually in the form of fiction and less frequently non-fiction, in which vices, follies, abuses, and shortcomings are held up to ridicule, often with the intent of exposing or shaming the perceived flaws of individuals, corporations, government, or society itself into improvement.",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Genre
                {
                    Id = 10,
                    GenreName = "Black comedy",
                    GenreDesc = "Black comedy, also known as black humor, bleak comedy, dark comedy, dark humor, gallows humor or morbid humor, is a style of comedy that makes light of subject matter that is generally considered taboo, particularly subjects that are normally considered serious or painful to discuss.",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new Genre
                {
                    Id = 11,
                    GenreName = "Horror",
                    GenreDesc = "Horror is a genre of speculative fiction that is intended to disturb, frighten, or scare.[1] Horror is often divided into the sub-genres of psychological horror and supernatural horror.",
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                }

            );
        }
    }
}
