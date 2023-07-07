using ApiDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDemo.Data
{
    public class StudentDataContext : DbContext
    {
      

        public DbSet<Student> students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer("data source=.\\SQLEXPRESS;initial catalog=adoassessment;integrated security=SSPI; TrustServerCertificate=True");
        }
    }
}
