using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Auth
{
    public class Login
    {
        [Required(ErrorMessage = "Username Required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password Required")]
        public string? Password { get; set; }
    }
}
