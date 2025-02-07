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
                    AurthorDOB = new DateTime(1952, 03, 11),
                    ImgLink = "https://upload.wikimedia.org/wikipedia/commons/c/c0/Douglas_adams_portrait_cropped.jpg"
                },
                new Author
                {
                    Id = 2,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    AuthorName = "George Orwell",
                    AuthorBio = "Eric Arthur Blair was an English novelist, poet, essayist, journalist and critic who wrote under the pen name of George Orwell. His work is characterised by lucid prose, social criticism, opposition to all totalitarianism, and support of democratic socialism.",
                    AurthorDOB = new DateTime(1903,06,25),
                    ImgLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/7e/George_Orwell_press_photo.jpg/1024px-George_Orwell_press_photo.jpg"
                },
                new Author
                {
                    Id = 3,
                    DateCreated = DateTime.Now,
                    DateUpdate = DateTime.Now,
                    AuthorName = "David Alderton",
                    AuthorBio = "David Alderton is an English writer specialising in pets and natural history topics. Growing up in a home surrounded by pets, he originally trained to become a veterinary surgeon. An allergic dermatitis acquired in his final year of study forced a change of career however, and so led him into the field of writing about pets and their care. He has since become a regular contributor of articles on this subject to a wide range of newspapers and magazines in the UK and abroad, and also participates frequently in radio and television programmes.",
                    AurthorDOB = new DateTime(1956),
                    ImgLink = "https://m.media-amazon.com/images/S/amzn-author-media-prod/m84i99ih3q7o6ec59b5ftmhijp._SX272_CR0%2C0%2C272%2C272_.jpg"

                },
                new Author
                {
                    Id=4,
                    DateCreated = DateTime.Now, 
                    DateUpdate = DateTime.Now,
                    AuthorName = "John Lloyd",
                    AuthorBio = "John Hardress Wilfred Lloyd is a British comedy writer and television producer. ",
                    AurthorDOB= new DateTime(1951,09,30),
                    ImgLink = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8c/John_lloyd_secret_comedy_podcast.jpg/1280px-John_lloyd_secret_comedy_podcast.jpg"
                }


                );
        }
    }
}
