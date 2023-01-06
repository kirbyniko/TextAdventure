using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureLibrary;

namespace AdventureMaker.Models
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
            optionsBuilder.UseSqlServer("Server=LocalHost\\MSSQLLocalDB;Initial Catalog=AdventureGame;User ID = test; password = 1234;");
        }
    }

    public class BulkPurchaseDBContextFactory : IDesignTimeDbContextFactory<AdventureGameDBContext>

    {

        public AdventureGameDBContext CreateDbContext(string[] args)

        {

            var optionsBuilder = new DbContextOptionsBuilder<AdventureGameDBContext>();

            optionsBuilder.UseSqlServer("Server=LocalHost\\MSSQLLocalDB;Initial Catalog=AdventureGame;User ID = test; password = 1234;");

            return new AdventureGameDBContext(optionsBuilder.Options);

        }

    }
}
