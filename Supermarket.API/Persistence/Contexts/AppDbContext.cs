using Microsoft.EntityFrameworkCore;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Persistence.Contexts
{
  public class AppDbContext : DbContext
  {
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.Entity<Category>().ToTable("Categories");
      builder.Entity<Category>().HasKey(p => p.Id);
      builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
      builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(30);
      builder.Entity<Category>().HasMany(p => p.Products).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);
      //https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/
    }
  }
}