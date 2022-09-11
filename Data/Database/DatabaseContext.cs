namespace VoteSystem.Data.Database
{
    using Microsoft.EntityFrameworkCore;
    using VoteSystem.Entity;

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Account> Users { get; set; }
        public DbSet<Election> Elections { get; set; }
    }
}