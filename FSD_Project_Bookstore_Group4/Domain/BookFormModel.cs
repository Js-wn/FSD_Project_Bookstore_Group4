using System.ComponentModel.DataAnnotations;

namespace FSD_Project_Bookstore_Group4.Domain
{
    public class BookFormModel
    {
        [Required(ErrorMessage = "Book title is required.")]
        public string? BookTitle { get; set; }

        [Required(ErrorMessage = "Book description is required.")]
        public string? BookDesc { get; set; }

        [Required(ErrorMessage = "Publish date is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
        public DateTime BookPublishDate { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, float.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public float BookPrice { get; set; }

        [Required(ErrorMessage = "Image link is required.")]
        [Url(ErrorMessage = "Please provide a valid URL.")]
        public string? ImgLink { get; set; }

        [Required(ErrorMessage = "Publisher is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a valid publisher.")]
        public int PublisherId { get; set; } = 0;

        [MinLength(1, ErrorMessage = "At least one author must be selected.")]
        public List<int> SelectedAuthors { get; set; } = new();

        [MinLength(1, ErrorMessage = "At least one genre must be selected.")]
        public List<int> SelectedGenres { get; set; } = new();
    }
}
