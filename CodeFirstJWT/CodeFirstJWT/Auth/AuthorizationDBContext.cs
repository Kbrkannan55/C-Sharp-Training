/*using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace JWTCodeFirst.Auth
{
    public class AuthorizationDBContext
    {
    }
}
*/

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CodeFirstJWT.Auth
{
    public class AuthorizationDBContext : IdentityDbContext<IdentityUser>
    {
        public AuthorizationDBContext(DbContextOptions<AuthorizationDBContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

   
    }
}