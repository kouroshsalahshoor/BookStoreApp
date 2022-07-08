using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.Api.Data
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
