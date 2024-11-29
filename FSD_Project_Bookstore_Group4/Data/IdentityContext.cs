using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FSD_Project_Bookstore_Group4.Data;

namespace FSD_Project_Bookstore_Group4.Data
{
    public class IdentityContext(DbContextOptions<IdentityContext> options) : IdentityDbContext<FSD_Project_Bookstore_Group4User>(options)
    {
    }
}
