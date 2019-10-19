using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Shop.DAL.Entitys;
using System.IO;

namespace Shop.DAL
{
    // Enable-Migrations
    // Add-Migration init
    // Update-Database
    public class ShopOnlineContext : IdentityDbContext
    {
        public ShopOnlineContext(DbContextOptions<ShopOnlineContext> options) : base(options)
        {
               
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Advertise> Advertises { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<GroupProduct> GroupProducts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Entitys.Shop> Shops { get; set; }
        public virtual DbSet<Support> Supports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ShopOnlineContext>
    {
        public ShopOnlineContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // nuget : Microsoft.Extensions.configuration.FileExtensions
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)  // nuget : Microsoft.Extensions.configuration.Json
                .AddEnvironmentVariables()  // requires Microsoft.Extensions.Configuration.EnvironmentVariables
                .Build();


            var builder = new DbContextOptionsBuilder<ShopOnlineContext>();
            var connectionString = configuration.GetConnectionString("SqlServerConnection");//SqlServerConnection là name của ConnectionStrings trong file json
            builder.UseSqlServer(connectionString);

            return new ShopOnlineContext(builder.Options);
        }

        
    }
}
