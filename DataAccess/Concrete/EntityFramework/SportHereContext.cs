using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class SportHereContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"(localdb)\MSSQLLocalDB;Database=SportHere;Trusted_Connection=true");
        }
        public DbSet<Move> Moves { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Program> Programs { get; set; }
    }
}
