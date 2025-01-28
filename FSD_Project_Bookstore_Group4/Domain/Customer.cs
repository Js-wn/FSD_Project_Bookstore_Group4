using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("Gender")]
        public int GenderId { get; set; } = 1;
        public Gender Gender { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<SubscriptionInfo> SubscriptionInfos { get; set; }
    }

}
