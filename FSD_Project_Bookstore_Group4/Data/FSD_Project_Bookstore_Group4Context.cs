using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FSD_Project_Bookstore_Group4.Domain;

namespace FSD_Project_Bookstore_Group4.Data
{
    public class FSD_Project_Bookstore_Group4Context : DbContext
    {
        public FSD_Project_Bookstore_Group4Context (DbContextOptions<FSD_Project_Bookstore_Group4Context> options)
            : base(options)
        {
        }

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
    }
}
