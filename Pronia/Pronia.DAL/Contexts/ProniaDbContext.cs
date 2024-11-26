using Microsoft.EntityFrameworkCore;
using Pronia.DAL.Models;

namespace Pronia.DAL.Contexts;

public class ProniaDbContext : DbContext
{
    public DbSet<SliderItem> SliderItems { get; set; }
    public ProniaDbContext(DbContextOptions<ProniaDbContext> opt) : base(opt) { }
}