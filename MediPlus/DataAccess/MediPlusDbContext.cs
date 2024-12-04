using MediPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace MediPlus.DataAccess
{
    public class MediPlusDbContext : DbContext
    {
        public DbSet<SliderItem> sliderItems { get; set; }
        public DbSet<ServiceItem> serviceItems { get; set; }
        public DbSet<Department> departments { get; set; }
        public MediPlusDbContext(DbContextOptions options) : base(options) { }
    }
}
