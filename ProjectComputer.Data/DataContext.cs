using Microsoft.EntityFrameworkCore;
using ProjectComputer.Core.Entities;
namespace ProjectComputer.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<Renting> Listrentin { get; set; }
        public DbSet<Computer> computers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }
       
    }
}
