using EasyTable.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EasyTable.Data
{
    public class EasyTableDbContext : DbContext
    {
        public EasyTableDbContext(DbContextOptions<EasyTableDbContext> options) : base(options) { }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.UnitOfMeasure)
                .HasConversion<string>();

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Recipe>()
                .HasOne(r => r.Category)
                .WithMany(c => c.Recipes)
                .HasForeignKey(r => r.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Recipe)
                .WithMany(r => r.RecipeIngredients)
                .HasForeignKey(ri => ri.RecipeId);

            modelBuilder.Entity<RecipeIngredient>()
                .HasOne(ri => ri.Product)
                .WithMany(p => p.RecipeIngredients)
                .HasForeignKey(ri => ri.ProductId);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Table)
                .WithMany(t => t.Orders)
                .HasForeignKey(o => o.TableId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Recipe)
                .WithMany(r => r.OrderItems)
                .HasForeignKey(oi => oi.RecipeId)
                .IsRequired();

            modelBuilder.Entity<Table>()
                .HasIndex(t => t.TableNumber).IsUnique();

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Name).IsUnique();
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.Code).IsUnique();

            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name).IsUnique();

            modelBuilder.Entity<Recipe>()
                .HasIndex(r => r.Name).IsUnique();
            modelBuilder.Entity<Recipe>()
                .HasIndex(r => r.Code).IsUnique();

            modelBuilder.Entity<Role>()
                .HasIndex(r => r.RoleName).IsUnique();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username).IsUnique();

            modelBuilder.Entity<Product>()
                .Property(p => p.CurrentStockQuantity).HasColumnType("decimal(10,3)");
            modelBuilder.Entity<Product>()
                .Property(p => p.PurchasePrice).HasColumnType("decimal(10,2)");

            modelBuilder.Entity<Recipe>()
                .Property(r => r.SellingPrice).HasColumnType("decimal(10,2)");

            modelBuilder.Entity<RecipeIngredient>()
                .Property(ri => ri.QuantityRequired).HasColumnType("decimal(10,3)");

            modelBuilder.Entity<Order>()
                .Property(o => o.TotalPrice).HasColumnType("decimal(10,2)");
            modelBuilder.Entity<Order>()
                .Property(o => o.DiscountAmount).HasColumnType("decimal(10,2)");

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.Quantity).HasColumnType("decimal(10,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}