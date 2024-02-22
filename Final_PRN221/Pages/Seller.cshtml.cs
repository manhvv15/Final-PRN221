using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Final_PRN221.Pages
{
    [Authorize(Roles = "seller")]
    public class SellerModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
