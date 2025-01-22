namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Customer : BaseDomainModel
    {
        public string? CustomerFirstName { get; set; }
        public string? CustomerLastName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerAddress { get; set; } 
        public string? CustomerContact { get; set; }
        public int CustomerPoints { get; set; }
        public int GenderId { get; set; }

        // Navigation property for related orders
        public List<Order> Orders { get; set; } = new List<Order>();
    }

}
