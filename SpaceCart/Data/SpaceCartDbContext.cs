using Microsoft.EntityFrameworkCore;
using SpaceCart.Data.Configurations;
using SpaceCart.Models.Database;

namespace SpaceCart.Data
{
    public class SpaceCartDbContext : DbContext
    {
        public SpaceCartDbContext():base()
        {
        }

        public SpaceCartDbContext(DbContextOptions<SpaceCartDbContext> options)
                    : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments{ get; set; }
        public DbSet<Purchase> Purchases{ get; set; }
        public DbSet<PurchaseProduct> PurchaseProducts{ get; set; }
        public DbSet<Rate> Rates{ get; set; }
        public DbSet<ShoppingCart> ShoppingCarts{ get; set; }
        public DbSet<UserRole> UserRoles{ get; set; }
        public DbSet<Image> Images{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            Seed seed = new Seed();
            seed.SeedData(builder);

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new PurchaseConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new PurchaseProductConfiguration());
            builder.ApplyConfiguration(new RateConfiguration());
            builder.ApplyConfiguration(new ShoppingCartConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ImageConfiguration());
        }
    }
}
