using FirstAPI.Modles;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Student> students { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.\\SQLEXPRESS;initial catalog=adoassessment;integrated security=SSPI; TrustServerCertificate=True");
        }
    }
}
