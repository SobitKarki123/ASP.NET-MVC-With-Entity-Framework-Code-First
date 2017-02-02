using CustomerMgmt.Data.Configuration;
using CustomerMgmt.Data.SeedData;
using CustomerMgmt.Models.Model;
using System.Data.Entity;


namespace CustomerMgmt.Data
{
    public class CustomerEntities: DbContext
    {
        public CustomerEntities() : base("CustomerEntities") {
            Database.SetInitializer(new CustomerDBInitializer());
        }

        public DbSet<Customer> Customers { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerConfiguration());
        }

    }
}