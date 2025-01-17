namespace FSD_Project_Bookstore_Group4.Domain
{
    public class OrderItem : BaseDomainModel
    {
        public int OrderQty { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
    }
}
