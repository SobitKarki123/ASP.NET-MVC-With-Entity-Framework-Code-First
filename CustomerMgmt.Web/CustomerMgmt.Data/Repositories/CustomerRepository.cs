
using CustomerMgmt.Data.Repositories.IRepositories;
using CustomerMgmt.Data.Infrastructure;
using CustomerMgmt.Models;
using CustomerMgmt.Models.Model;

namespace CustomerMgmt.Data.Repositories
{
    public class CustomerRepository: RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository()
            : base() { }
        
    }
}