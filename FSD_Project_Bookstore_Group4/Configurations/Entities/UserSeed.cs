using FSD_Project_Bookstore_Group4.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FSD_Project_Bookstore_Group4.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<FSD_Project_Bookstore_Group4User>
    {
        public void Configure(EntityTypeBuilder<FSD_Project_Bookstore_Group4User> builder)
        {
            var hasher = new PasswordHasher<FSD_Project_Bookstore_Group4User>();
            builder.HasData(
            new FSD_Project_Bookstore_Group4User
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new FSD_Project_Bookstore_Group4User
            {
                Id = "5436aeb6-34ac-90f0-860f-e446d23252e4",
                Email = "customer@localhost.com",
                NormalizedEmail = "CUSTOMER@LOCALHOST.COM",
                FirstName = "Customer",
                LastName = "User",
                UserName = "customer@localhost.com",
                NormalizedUserName = "CUSTOMER@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}