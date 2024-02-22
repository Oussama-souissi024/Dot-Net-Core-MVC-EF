using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace NewWebApplicationMVc_EF.Models
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Customer>Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-2SD6PP6;Database=CodeFirst2;Integrated Security=true;TrustServerCertificate=true");
        }
    }
}
