using Microsoft.AspNetCore.Identity;

namespace Final_PRN221.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string FirstName { get; set; } = null;
        public string LastName { get; set; } = null;
        public string Address { get; set; } = null;
        public DateTime CreatedAt { get; set; } 
    }
}
