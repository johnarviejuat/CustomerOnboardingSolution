using CustomerOnboarding.Application.DTOs;
using CustomerOnboarding.Domain.Entities;
using CustomerOnboarding.Domain.Repositories;

namespace CustomerOnboarding.Application.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Customer> RegisterCustomerAsync(RegisterCustomerDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.FirstName) || string.IsNullOrWhiteSpace(dto.LastName))
                throw new ArgumentException("First and Last name are required.");

            if (string.IsNullOrWhiteSpace(dto.Email) || !dto.Email.Contains("@"))
                throw new ArgumentException("A valid email address is required.");

            if (string.IsNullOrWhiteSpace(dto.SignatureBase64))
                throw new ArgumentException("Customer signature capture is required.");

            var customer = new Customer
            {
                Id = Guid.NewGuid(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                PhoneNumber = dto.PhoneNumber,
                SignatureBase64 = dto.SignatureBase64,
                DateCreated = DateTime.UtcNow
            };

            await _repository.AddAsync(customer);
            return customer;
        }

        public async Task<Customer?> GetCustomerByIdAsync(Guid id) => await _repository.GetByIdAsync(id);

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync() => await _repository.GetAllAsync();
    }
}
