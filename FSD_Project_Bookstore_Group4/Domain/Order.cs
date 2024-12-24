namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Order : BaseDomainModel
    {
        public DateTime OrderDateTime { get; set; }
        public int CustomerId { get; set; }
    }
}
