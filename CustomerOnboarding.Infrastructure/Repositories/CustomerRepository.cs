using CustomerOnboarding.Domain.Entities;
using CustomerOnboarding.Domain.Repositories;
using CustomerOnboarding.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace CustomerOnboarding.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Customer?> GetByIdAsync(Guid id) => await _context.Customers.FindAsync(id);

        public async Task<IEnumerable<Customer>> GetAllAsync() => await _context.Customers.ToListAsync();

        public async Task AddAsync(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            await _context.SaveChangesAsync();
        }
    }
}
