using APIDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace APIDemo {
  public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
    }

    public DbSet<Plant> Plants { get; set; }
  }
}