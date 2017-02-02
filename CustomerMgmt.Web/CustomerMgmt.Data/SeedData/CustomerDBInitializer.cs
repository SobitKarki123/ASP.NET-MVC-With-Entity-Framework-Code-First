using CustomerMgmt.Models.Model;
using System.Data.Entity;

namespace CustomerMgmt.Data.SeedData
{
    public class CustomerDBInitializer : DropCreateDatabaseIfModelChanges<CustomerEntities>
    {
        protected override void Seed(CustomerEntities context)
        {
            //context.Commit();

            context.Customers.Add(new Customer()
            {
                FirstName = "test1",
                LastName = "test1",
                DateOfBirth = "test1",
                Email = "test1",
                Company = "test1",
                Address = "test1"
            });
            context.Customers.Add(new Customer()
            {

                FirstName = "test2",
                LastName = "test2",
                DateOfBirth = "test2",
                Email = "test2",
                Company = "test2",
                Address = "test2"
            });
            context.Customers.Add(new Customer()
            {

                FirstName = "test3",
                LastName = "test3",
                DateOfBirth = "test3",
                Email = "test3",
                Company = "test3",
                Address = "test3"
            });

            context.Customers.Add(new Customer()
            {

                FirstName = "test4",
                LastName = "test4",
                DateOfBirth = "test4",
                Email = "test4",
                Company = "test4",
                Address = "test4"
            });
            context.Customers.Add(new Customer()
            {

                FirstName = "test5",
                LastName = "test5",
                DateOfBirth = "test5",
                Email = "test5",
                Company = "test5",
                Address = "test5"
            });

            context.Customers.Add(new Customer()
            {

                FirstName = "test6",
                LastName = "test6",
                DateOfBirth = "test6",
                Email = "test6",
                Company = "test6",
                Address = "test6"
            });


            base.Seed(context);
        }
    }
}