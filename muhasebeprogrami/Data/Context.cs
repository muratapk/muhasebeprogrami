using Microsoft.EntityFrameworkCore;
using muhasebeprogrami.Models;

namespace muhasebeprogrami.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {
        }
       public DbSet<Sehir> sehirs { get; set; }
       public DbSet<Unvan> unvans { get; set; }
       public DbSet<Kasaba> kasabas { get; set; }
    }
}
