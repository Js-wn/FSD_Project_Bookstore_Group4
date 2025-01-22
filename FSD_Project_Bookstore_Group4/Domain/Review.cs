namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Review : BaseDomainModel
    {
        public string? ReviewText {  get; set; }
        public float ReviewRating { get; set; }
        public int CustomerId { get; set; }
        public int OrderItemId { get; set; }

    }
}
