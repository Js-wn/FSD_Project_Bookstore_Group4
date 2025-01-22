using FSD_Project_Bookstore_Group4.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace FSD_Project_Bookstore_Group4.Configurations.Entities
{
    public class AuthorSeed : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(
                new Author
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    AuthorName = "Douglas Adams",
                    AuthorBio = "Douglas Noel Adams was an English author, humourist, and screenwriter, best known as the creator of The Hitchhiker's Guide to the Galaxy. Originally a 1978 BBC radio comedy, The Hitchhiker's Guide to the Galaxy developed into a \"trilogy\" of five books which sold more than 15 million copies in his lifetime.",
                    AurthorDOB = new DateTime(19552, 03, 11)
                },
                new Author
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    AuthorName = "George Orwell",
                    AuthorBio = "Eric Arthur Blair was an English novelist, poet, essayist, journalist and critic who wrote under the pen name of George Orwell. His work is characterised by lucid prose, social criticism, opposition to all totalitarianism, and support of democratic socialism.",
                    AurthorDOB = new DateTime(1903,06,25)
                }


                );
        }
    }
}
