using Microsoft.EntityFrameworkCore;
using NET106.Shared.Models;

namespace NET106.Shared.Context;

public class DatabaseContext : DbContext
{
    public DatabaseContext() { }
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options) { }
    public DbSet<School> Schools { get; set; }
    public DbSet<Branch> Branchs { get; set; }
    public DbSet<Subjects> Subjects { get; set; }
    public DbSet<Students> Students { get; set; }
    public DbSet<Class> Classs { get; set; }
    public DbSet<Point> Points { get; set; }
}