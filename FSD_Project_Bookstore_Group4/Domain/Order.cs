using System.ComponentModel.DataAnnotations.Schema;

namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Order : BaseDomainModel
    {
        public DateTime OrderDateTime { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public string IsInCart { get; set; } = "Yes";
    }
}
