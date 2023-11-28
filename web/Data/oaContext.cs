using web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace web.Data
{
public class oaContext : IdentityDbContext<ApplicationUser>
    {
    public oaContext(DbContextOptions<oaContext> options) : base(options)
    {
    }
    public DbSet<UporabniskiRacun> UporabniskiRacuni { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<UporabniskiRacun>().ToTable("UporabniskiRacun");
    }
}
}