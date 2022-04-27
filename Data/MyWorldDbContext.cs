using Microsoft.EntityFrameworkCore;

class MyWorldDbContext : DbContext
{
    public MyWorldDbContext(DbContextOptions<MyWorldDbContext> options) : base(options)
    {
        
    }

    public DbSet<Cake> Cake { get; set; }
}