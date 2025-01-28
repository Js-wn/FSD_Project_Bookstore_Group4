namespace FSD_Project_Bookstore_Group4.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        protected BaseDomainModel()
        {
            DateUpdate = DateTime.Now;
        }
    }


}
