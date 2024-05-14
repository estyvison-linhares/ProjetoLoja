using Microsoft.EntityFrameworkCore;
using ProjetoLoja.Models;

namespace ProjetoLoja.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
            
        }

        public DbSet<ProductSupplier> ProductSuppliers { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
