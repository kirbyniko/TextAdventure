using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureLibrary 
{
    public class AdventureGameDBContext : DbContext
    {
        public DbSet<TestTable> testtable { get; set; }
        public AdventureGameDBContext(DbContextOptions<AdventureGameDBContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AdventureGameDB;Integrated Security=True;");
        }
    }

    public class BulkPurchaseDBContextFactory : IDesignTimeDbContextFactory<AdventureGameDBContext>

    {

        public AdventureGameDBContext CreateDbContext(string[] args)

        {

            var optionsBuilder = new DbContextOptionsBuilder<AdventureGameDBContext>();

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AdventureGameDB;Integrated Security=True;");

            return new AdventureGameDBContext(optionsBuilder.Options);

        }

    }
}
