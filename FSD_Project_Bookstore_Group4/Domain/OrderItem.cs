using System.ComponentModel.DataAnnotations.Schema;

namespace FSD_Project_Bookstore_Group4.Domain
{
    public class OrderItem : BaseDomainModel
    {
        public int OrderQty { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
