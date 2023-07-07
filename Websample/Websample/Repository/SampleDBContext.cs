using Microsoft.EntityFrameworkCore;

namespace Websample.Repository
{
    public class SampleDBContext :DbContext
    {
        public SampleDBContext(DbContextOptions<SampleDBContext> options):base (options) { }
        DbSet<customer> customers { get; set; }
        DbSet<product> products { get; set; }

    }
}
