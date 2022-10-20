using Microsoft.Extensions.Primitives;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage ="Your username must be between 5 and 15 characters.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Your password must be between 6 and 20 characters.")]
        public string Password { get; set; }
        [EmailAddress(ErrorMessage = "Must be a valid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Verify password is required.")]
        public string VerifyPassword { get; set; }
    }
}
