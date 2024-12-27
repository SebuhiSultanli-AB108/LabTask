using E_commerce.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_commerce.DAL.Context;

public class E_comDbContext : DbContext
{
    public E_comDbContext(DbContextOptions options) : base(options) { }

    DbSet<Order> Orders { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}