using CustomerOnboarding.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerOnboarding.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Customer> Customers => Set<Customer>();
    }
}
