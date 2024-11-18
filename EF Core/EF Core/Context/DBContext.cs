using EF_Core.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core.Context;

public class DBContext : DbContext
{
    public DbSet<Baskets> Baskets { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<Products> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=STORE;Trusted_Connection=True;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }
}
