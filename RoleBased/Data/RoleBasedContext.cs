using Microsoft.EntityFrameworkCore;
using RoleBased.Data.Configurations;

namespace RoleBased.Data;

public class RoleBasedContext : DbContext
{
    public RoleBasedContext() { }
    public RoleBasedContext(DbContextOptions<RoleBasedContext> options) : base(options) { }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Profile> Profiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfig());
        modelBuilder.ApplyConfiguration(new ProfileConfig());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
}
