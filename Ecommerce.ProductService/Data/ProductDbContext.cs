using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.ProductService.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 1, Name = "Protein Powder", Quantity = 20, Price = 80, PhotoName = "protein_powder.jpg", About = "Net weight: 2.26kg. Use 2 scoops per serving, add 250-400ml of water. Serving has 24g of protein." });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 2, Name = "Dumbbell Set", Quantity = 10, Price = 80, PhotoName = "dumbbell_set.jpg", About = "2.5kg plates, 1.5kg plates, 1kg plates and 0.5kg plates dumbbell set." });
            modelBuilder.Entity<ProductModel>().HasData(new ProductModel { Id = 3, Name = "Basketball", Quantity = 20, Price = 40, PhotoName = "basketball.jpg", About = "Size 7, NBA official." });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ProductModel> Products { get; set; }
    }
}
