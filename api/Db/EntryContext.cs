using Microsoft.EntityFrameworkCore;

namespace yapt.Db
{
    public class EntryContext : DbContext
    {
        public EntryContext(DbContextOptions<EntryContext> options)
               : base(options)
        { }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<User> User { get; set; }

    }
}