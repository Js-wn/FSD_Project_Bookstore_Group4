namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Author : BaseDomainModel
    {
        public string? AuthorName { get; set; }
        public DateTime AurthorDOB { get; set; }
        public string? AuthorBio { get; set; }
        public string? ImgLink { get; set; }

    }
}
