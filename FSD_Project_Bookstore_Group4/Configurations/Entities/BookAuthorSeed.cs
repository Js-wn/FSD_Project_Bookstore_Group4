    using FSD_Project_Bookstore_Group4.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NuGet.Configuration;
namespace FSD_Project_Bookstore_Group4.Configurations.Entities
{
    public class BookAuthorSeed : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasData(
                new BookAuthor
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    AuthorId = 1,
                    BookId = 1,
                },
                new BookAuthor
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    AuthorId = 2,
                    BookId = 2,
                },
                new BookAuthor
                {
                    Id = 3,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    AuthorId = 3,
                    BookId = 4,
                },
                new BookAuthor
                {
                    Id= 4,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,  
                    AuthorId = 1,
                    BookId = 5,
                },
                new BookAuthor
                {
                    Id = 5,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    AuthorId = 4,
                    BookId = 5,
                },
                new BookAuthor
                {
                    Id = 6,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    AuthorId = 2,
                    BookId = 6,
                }

                );
        }
    }
}
