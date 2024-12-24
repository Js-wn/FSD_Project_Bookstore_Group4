using System.Security.Permissions;

namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Book : BaseDomainModel
    {
        public string? BookTitle { get; set; }
        public string? BookDesc { get; set; }
        public string? BookCoverImg { get; set; }

        public DateTime BookPublishDate { get; set; }
        public float BookPrice { get; set; }
        public int PublisherId { get; set; }
    
    }
}
