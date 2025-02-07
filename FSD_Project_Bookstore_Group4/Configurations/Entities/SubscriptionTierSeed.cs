using FSD_Project_Bookstore_Group4.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FSD_Project_Bookstore_Group4.Configurations.Entities
{
    public class SubscriptionTierSeed : IEntityTypeConfiguration<SubscriptionTier>
    {
        public void Configure(EntityTypeBuilder<SubscriptionTier> builder)
        {
            builder.HasData(
                new SubscriptionTier
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    TierName = "Basic",
                    Discount = 0.15,
                    Cost = 15,
                }
            );
        }
    }
}
