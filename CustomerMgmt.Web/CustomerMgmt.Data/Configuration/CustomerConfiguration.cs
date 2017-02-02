
using CustomerMgmt.Models.Model;
using System.Data.Entity.ModelConfiguration;

namespace CustomerMgmt.Data.Configuration
{
    public class CustomerConfiguration: EntityTypeConfiguration<Customer>
    {
        public CustomerConfiguration()
        {

            ToTable("Customers");
            Property(c => c.FirstName).IsRequired();
            Property(c => c.LastName).IsRequired();
            Property(c => c.DateOfBirth).IsOptional();
            Property(c => c.Email).IsRequired();
            Property(c => c.Company);
            Property(c => c.Address).IsOptional();

        }
    }
}

