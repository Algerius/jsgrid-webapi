using JSGridWebAPISample.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace JSGridWebAPISample.DAL
{

    public class DataContext: DbContext {
        public DataContext()
            : base()
        {
        }

        public DbSet<Client> Client { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}