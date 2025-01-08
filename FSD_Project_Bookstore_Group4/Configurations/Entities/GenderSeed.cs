﻿using FSD_Project_Bookstore_Group4.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSD_Project_Bookstore_Group4.Configurations.Entities
{
    public class GenderSeed : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasData(
                new Gender
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    GenderName = "Male"
                    
                },
                new Gender
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    GenderName = "Female"

                }

            );
        }
    }
}
