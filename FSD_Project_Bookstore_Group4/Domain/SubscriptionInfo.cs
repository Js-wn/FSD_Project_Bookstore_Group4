using System.ComponentModel.DataAnnotations.Schema;

namespace FSD_Project_Bookstore_Group4.Domain
{
    public class SubscriptionInfo : BaseDomainModel
    {
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        [ForeignKey("Customer")]
        public int CutomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("SubscriptionTier")]
        public int TierId { get; set; }
        public SubscriptionTier SubscriptionTier { get; set; }
    }
}
