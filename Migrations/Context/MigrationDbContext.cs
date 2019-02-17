using Migrations.Domain;
using System.Data.Entity;

namespace Migrations.Context
{
    public class MigrationDbContext : DbContext
    {
        public MigrationDbContext() : base("name=DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<AccountType> AccountTypes { get; set; }

        public DbSet<Account> Accounts { get; set; }
    }
}