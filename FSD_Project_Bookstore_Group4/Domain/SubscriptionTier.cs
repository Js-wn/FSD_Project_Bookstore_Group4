namespace FSD_Project_Bookstore_Group4.Domain
{
    public class SubscriptionTier : BaseDomainModel
    {
        public string? TierName { get; set; }
        public float Cost { get; set; }
        public string? Description { get; set; }
        public double Discount { get; set; }
        public ICollection<SubscriptionInfo> SubscriptionInfo { get; set; }
    }
}
