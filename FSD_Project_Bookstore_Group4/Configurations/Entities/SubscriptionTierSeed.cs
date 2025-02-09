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
                    Description = "15% discount for all orders",
                    Discount = 0.15,
                    Cost = 15,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new SubscriptionTier
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    TierName = "Premium",
                    Description = "20% discount for all orders",
                    Discount = 0.20,
                    Cost = 20,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new SubscriptionTier
                {
                    Id = 3,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    TierName = "Premium+",
                    Description = "25% discount for all orders",
                    Discount = 0.25,
                    Cost = 25,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
