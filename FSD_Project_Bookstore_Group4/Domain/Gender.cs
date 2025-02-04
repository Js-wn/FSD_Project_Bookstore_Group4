namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Gender : BaseDomainModel
    {
        public int GenderId { get; set; }
        public string? GenderName { get; set; }
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}
