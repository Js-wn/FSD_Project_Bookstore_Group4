using FSD_Project_Bookstore_Group4.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project_Bookstore_Group4.Configurations.Entities
{
    public class PublisherSeed : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasData(
                new Publisher
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    PublisherName = "PlaceHolder",
                    PublisherContact = "11111111",
                    PublisherEmail = "example@gmail.com",
                    PublisherAddress = "123 street",
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }

            );
        }
    }
}
