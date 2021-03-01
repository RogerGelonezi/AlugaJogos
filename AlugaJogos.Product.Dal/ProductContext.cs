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
        public DbSet<ProductProperty> ProductProperties { get; set; }
        public DbSet<ProductVideo> ProductVideos { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyDefaultOption> PropertieDefaults { get; set; }
        public DbSet<PropertyGroup> PropertieGroups { get; set; }
        
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
            // optionsBuilder.UseSqlServer("Data Source=ROGER-EUMESMO\\SQLROGER;Initial Catalog=AlugaJogos.Products;Persist Security Info=True;User ID=sa;Password=freakzoid");
            optionsBuilder.UseSqlServer("Data Source=192.168.56.1;Initial Catalog=AlugaJogos.Products;Persist Security Info=True;User ID=sa;Password=#Rogerio123");
            base.OnConfiguring(optionsBuilder);
        } // ROGER-EUMESMO\\SQLROGER

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration<Property>(new PropertieConfiguration());
            builder.ApplyConfiguration<PropertyGroup>(new PropertieGroupConfiguration());
        }
    }
}
