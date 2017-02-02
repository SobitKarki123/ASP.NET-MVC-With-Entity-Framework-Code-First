using CustomerMgmt.Data.Repositories.IRepositories;
using CustomerMgmt.Models.Model;
using CustomerMgmt.Service.IService;

namespace CustomerMgmt.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
           
                _customerRepository = customerRepository;
          
        }

        public void createCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
            _customerRepository.Commit();
        }

        public void SaveCustomer()
        {
            try
            {
                _customerRepository.Commit();
            }
            catch { throw; }
        }

    }
}