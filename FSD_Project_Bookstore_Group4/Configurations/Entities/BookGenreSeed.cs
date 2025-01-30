using FSD_Project_Bookstore_Group4.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project_Bookstore_Group4.Configurations.Entities
{
    public class BookGenreSeed : IEntityTypeConfiguration<BookGenre>
    {
        public void Configure(EntityTypeBuilder<BookGenre> builder)
        {
            builder.HasData(
                new BookGenre
                {
                    Id = 1,
                    BookId = 1,
                    GenreId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new BookGenre
                {
                    Id = 2,
                    BookId = 1,
                    GenreId = 3,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new BookGenre
                {
                    Id = 3,
                    BookId = 1,
                    GenreId = 4,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new BookGenre
                {
                    Id = 4,
                    BookId = 2,
                    GenreId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new BookGenre
                {
                    Id = 5,
                    BookId = 2,
                    GenreId = 5,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },

                new BookGenre
                {
                    Id = 6,
                    BookId = 2,
                    GenreId = 6,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },

                new BookGenre
                {
                    Id = 7,
                    BookId = 2,
                    GenreId = 7,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },

                new BookGenre
                {
                    Id = 8,
                    BookId = 3,
                    GenreId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new BookGenre
                {
                    Id = 9,
                    BookId = 3,
                    GenreId = 8,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new BookGenre
                {
                    Id = 10,
                    BookId = 3,
                    GenreId = 9,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new BookGenre
                {
                    Id = 11,
                    BookId = 3,
                    GenreId = 10,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                },
                new BookGenre
                {
                    Id = 12,
                    BookId = 3,
                    GenreId = 11,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                }


            );
        }
    }
}
