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
    public class FSD_Project_Bookstore_Group4Context : IdentityDbContext<FSD_Project_Bookstore_Group4User>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        // Single constructor to handle both DbContextOptions and IHttpContextAccessor
        public FSD_Project_Bookstore_Group4Context(
            DbContextOptions<FSD_Project_Bookstore_Group4Context> options,
            IHttpContextAccessor httpContextAccessor) :
            base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public DbSet<FSD_Project_Bookstore_Group4.Domain.SubscriptionTier> SubscriptionTier { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.SubscriptionInfo> SubscriptionInfo { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Gender> Gender { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Order> Order { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Review> Review { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Book> Book { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Genre> Genre { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Publisher> Publisher { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Author> Author { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.BookAuthor> BookAuthor { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.BookGenre> BookGenre { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.OrderItem> OrderItem { get; set; } = default!;
        public DbSet<FSD_Project_Bookstore_Group4.Domain.Payment> Payment { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new PublisherSeed());
            builder.ApplyConfiguration(new BookSeed());
            builder.ApplyConfiguration(new GenderSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new AuthorSeed());
            builder.ApplyConfiguration(new BookAuthorSeed());
            builder.ApplyConfiguration(new GenreSeed());
            builder.ApplyConfiguration(new BookGenreSeed());
            
        }

        public override int SaveChanges()
        {
            UpdateAuditFields();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateAuditFields();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void UpdateAuditFields()
        {
            // Get Singapore time directly
            var singaporeTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            var now = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, singaporeTimeZone);

            var currentUser = _httpContextAccessor.HttpContext?.User?.Identity?.Name ?? "System";

            foreach (var entry in ChangeTracker.Entries<BaseDomainModel>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = now;
                    entry.Entity.CreatedBy = currentUser;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.DateUpdate = now;
                    entry.Entity.UpdatedBy = currentUser;
                }
            }
        }



    }
}
