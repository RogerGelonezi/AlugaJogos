using Microsoft.EntityFrameworkCore;
using AlugaJogos.Model;

namespace AlugaJogos.Persistence
{
    public class ProductContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Model.Product> Products { get; set; }
        public DbSet<ProductFile> ProductFiles { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductPropertie> ProductProperties { get; set; }
        public DbSet<ProductVideo> ProductVideos { get; set; }
        public DbSet<Propertie> Properties { get; set; }
        public DbSet<PropertieDefaultOptions> PropertieDefaults { get; set; }
        public DbSet<PropertieGroup> PropertieGroups { get; set; }
        
        public ProductContext()
        {
            // this.Database.EnsureCreated();
        }

        public ProductContext(DbContextOptions<ProductContext> options)
               : base(options)
        {
            // this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AlugaJogos.Products;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration<Propertie>(new PropertieConfiguration());
        }
    }
}
