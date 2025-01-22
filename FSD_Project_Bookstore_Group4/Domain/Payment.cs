namespace FSD_Project_Bookstore_Group4.Domain
{
    public class Payment : BaseDomainModel
    {
        public string? PaymentMethod { get; set; }
        public DateTime PaymentDate { get; set; }
        public float PaymentAmountBefDiscount { get; set; }
        public float PaymentAmountAftDiscount { get; set; }
        public int SubscriptionId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public int TierId { get; set; }
    }
}
