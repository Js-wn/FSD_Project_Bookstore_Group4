using FSD_Project_Bookstore_Group4.Data;
using Microsoft.AspNetCore.Identity;

namespace FSD_Project_Bookstore_Group4.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<FSD_Project_Bookstore_Group4User> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<FSD_Project_Bookstore_Group4User> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
