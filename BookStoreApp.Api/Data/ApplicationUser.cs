using Microsoft.AspNetCore.Identity;

namespace BookStoreApp.Api.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
