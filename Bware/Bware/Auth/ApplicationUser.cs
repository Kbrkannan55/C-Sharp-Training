using Microsoft.AspNetCore.Identity;

namespace Bware.Auth
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }
    }
}
