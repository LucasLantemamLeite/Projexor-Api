using Microsoft.EntityFrameworkCore;
using Projexor.Data.Mapping;
using Projexor.Domain.Entity;

namespace Projexor.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<UserAccount> UserAccounts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserAccountMap).Assembly);
    }
}