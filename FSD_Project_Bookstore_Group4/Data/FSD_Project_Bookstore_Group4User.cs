using Microsoft.AspNetCore.Identity;

namespace FSD_Project_Bookstore_Group4.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class FSD_Project_Bookstore_Group4User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
