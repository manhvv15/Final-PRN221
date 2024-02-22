using Final_PRN221.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Final_PRN221.Areas.Identity.Pages
{
    [Authorize]
    public class UserModel : PageModel
    {
        public ApplicationUser? appUser;
        public UserModel(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public UserManager<ApplicationUser> userManager { get; }

        public void OnGet()
        {
            var task = userManager.GetUserAsync(User);
            task.Wait(); 
            appUser = task.Result;
        }
    }
}
