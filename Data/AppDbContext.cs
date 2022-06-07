using Microsoft.EntityFrameworkCore;
using ProductsCatalog.Models;


namespace ProductsCatalog.Data{
    public class AppDbContext : DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }

        public DbSet<ProductModel> Product { get; set; }

        public DbSet<UserModel> User { get; set; }

    }
}