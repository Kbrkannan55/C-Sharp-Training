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


namespace Websample.Auth
{
    public class AuthorizationDbContext : IdentityDbContext<IdentityUser>
    {
        public AuthorizationDbContext(DbContextOptions<AuthorizationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}