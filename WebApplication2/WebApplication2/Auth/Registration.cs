using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Auth
{
    public class Registration
    {
        [Required(ErrorMessage = "Username Required")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Password Required")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Email Required")]
        public string? Email { get; set; }
    }
}
