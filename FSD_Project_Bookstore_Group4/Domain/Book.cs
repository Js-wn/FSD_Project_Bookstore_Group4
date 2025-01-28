using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Book : BaseDomainModel
    {
        public string? BookTitle { get; set; }
        public string? BookDesc { get; set; }
        public DateTime BookPublishDate { get; set; }
        public float BookPrice { get; set; }
        public string? ImgLink { get; set; }
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<BookGenre> BookGenres { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
