using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using FormUI.Models;
using WindowsFormsApp1;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace FormUI.Data
{
    public partial class SimpleWarehousContext : DbContext
    {
        public SimpleWarehousContext()
        {
        }

        public SimpleWarehousContext(DbContextOptions<SimpleWarehousContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Adresses { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyRole> CompanyRole { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<Product> Produts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Warehous> Warehouses { get; set; }
        public virtual DbSet<WarehousProduct> WarehouseProducts { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddUserSecrets(typeof(Program).Assembly)
                    .Build().GetConnectionString("SimpleWarehous")
                    );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Entity<OrderItem>()
                .HasKey(o => new { o.OrderId, o.ProductId });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
