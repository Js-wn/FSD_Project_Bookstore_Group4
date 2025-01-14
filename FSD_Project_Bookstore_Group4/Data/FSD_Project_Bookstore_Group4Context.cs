using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FSD_Project_Bookstore_Group4.Domain;
using FSD_Project_Bookstore_Group4.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FSD_Project_Bookstore_Group4.Data
{
    public class FSD_Project_Bookstore_Group4Context(DbContextOptions<FSD_Project_Bookstore_Group4Context> options) :
IdentityDbContext<FSD_Project_Bookstore_Group4User>(options)
    {



        public DbSet<FSD_Project_Bookstore_Group4.Domain.SubscriptionTier> SubscriptionTier { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.SubscrptionInfo> SubscrptionInfo { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Gender> Gender { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Order> Order { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Review> Review { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Book> Book { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Genre> Genre { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Publisher> Publisher { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Author> Author { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new PublisherSeed());
            builder.ApplyConfiguration(new BookSeed());
            builder.ApplyConfiguration(new GenderSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}
