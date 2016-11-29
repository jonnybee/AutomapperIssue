using System.Data.Entity;
using System.Diagnostics;

namespace DemoModel
{
    public class DemoContext : DbContext
    {
        public DemoContext() : base("name=DemoContext")
        {
            Database.SetInitializer(new DemoDbInitializer());
            Database.Log = (m) => Debug.Print(m);
        }

        public IDbSet<Country> Country { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CountryMap());
        }
    }
}
