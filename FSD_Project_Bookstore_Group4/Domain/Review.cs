using System.ComponentModel.DataAnnotations.Schema;

namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Review : BaseDomainModel
    {
        public string? ReviewText { get; set; }
        public float ReviewRating { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("OrderItem")]
        public int? OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }

    }
}
