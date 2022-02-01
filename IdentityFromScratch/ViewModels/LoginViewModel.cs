using System.ComponentModel.DataAnnotations;

namespace IdentityFromScratch.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]

        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Your Password")]

        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
