using FSD_Project_Bookstore_Group4.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FSD_Project_Bookstore_Group4.Configurations.Entities
{
    public class BookItemSeed : IEntityTypeConfiguration<BookItem>
    {
        public void Configure(EntityTypeBuilder<BookItem> builder)
        {
            builder.HasData(
                new BookItem
                {   
                    Id = 1,
                    BookId = 1,
                },
                new BookItem
                {
                    Id = 2,
                    BookId = 1
                },
                new BookItem
                {
                    Id = 3,
                    BookId = 1
                },
                new BookItem
                {
                    Id = 4,
                    BookId = 2
                },
                new BookItem
                {
                    Id = 5,
                    BookId = 2
                }
                );
        }
    }
}
