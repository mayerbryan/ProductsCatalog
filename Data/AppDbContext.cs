using Microsoft.EntityFrameworkCore;
using ProductsCatalog.Models;

namespace ProductsCatalog.Data{
    public class AppDbContext : DbContext {

        public DbSet<ProductModel> Product { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options) 
    => options.UseSqlite("DataSource=app.db;Cache=Shared");

    }
}