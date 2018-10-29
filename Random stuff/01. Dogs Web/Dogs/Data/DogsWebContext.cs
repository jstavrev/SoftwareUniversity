using Dogs.Data.DBModels;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace Dogs.Data
{
    public class DogsWebContext : DbContext
    {
        public DogsWebContext(DbContextOptions<DogsWebContext> options) : base(options)
        {
        }

        public DbSet<Dog> Dogs { get; set; }
    }
}
