namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Genre : BaseDomainModel
    {
        public string? GenreName { get; set; }
        public string? GenreDesc { get; set; }
        public ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();
    }
}
