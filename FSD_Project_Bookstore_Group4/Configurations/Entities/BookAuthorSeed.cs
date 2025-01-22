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
                }


                );
        }
    }
}
