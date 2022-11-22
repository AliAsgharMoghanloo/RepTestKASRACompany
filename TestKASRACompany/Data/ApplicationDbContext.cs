using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestKASRACompany.Models;

namespace TestKASRACompany.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
         public DbSet<Product> Product { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}