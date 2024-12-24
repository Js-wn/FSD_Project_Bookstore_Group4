namespace FSD_Project_Bookstore_Group4.Domain
{
    public class SubscrptionInfo : BaseDomainModel
    {
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public int CutomerId { get; set; }
        public int TierId { get; set; }
    }
}
