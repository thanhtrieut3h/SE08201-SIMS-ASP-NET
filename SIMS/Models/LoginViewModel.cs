using System.ComponentModel.DataAnnotations;

namespace SIMS.Models
{
    public class LoginViewModel
    {
        // khai bao cac thuoc tinh cho Form login
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; } = null!;
    }
}
