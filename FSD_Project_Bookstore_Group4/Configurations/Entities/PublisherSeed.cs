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
                },
                new Publisher
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    PublisherName = "Pan Books",
                    PublisherContact = "0207 038 5000",
                    PublisherEmail = "webqueries@macmillan.co.uk",
                    PublisherAddress = "6 Briset Street",
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Publisher
                {
                    Id = 3,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    PublisherName = "Harvill Secker",
                    PublisherContact = "+44 (0)20 7139 3000",
                    PublisherEmail = "VintagePublicity@penguinrandomhouse.co.uk",
                    PublisherAddress = " 8 Viaduct Gardens",
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }

            );
        }
    }
}
