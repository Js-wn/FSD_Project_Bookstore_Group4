using System.ComponentModel.DataAnnotations.Schema;

namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Payment : BaseDomainModel
    {
        public string? PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public float PaymentAmountBefDiscount { get; set; }
        public float PaymentAmountAftDiscount { get; set; }
        [ForeignKey("SubscriptionInfo")]
        public int SubscriptionId { get; set; }
        public SubscriptionInfo SubscrptionInfo { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [ForeignKey("Order")]
        public int? OrderId { get; set; }
        public Order Order { get; set; }
        [ForeignKey("SubscriptionTier")]
        public int TierId { get; set; }
        public SubscriptionTier SubscriptionTier { get; set; }
    }
}
