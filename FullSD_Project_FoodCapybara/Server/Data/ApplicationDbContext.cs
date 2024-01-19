using Duende.IdentityServer.EntityFramework.Options;
using FullSD_Project_FoodCapybara.Server.Configuration.Entities;
using FullSD_Project_FoodCapybara.Server.Configuration.Entities.User;


using FullSD_Project_FoodCapybara.Server.Models;
using FullSD_Project_FoodCapybara.Shared.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FullSD_Project_FoodCapybara.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Food> Foods { get; set; }  
        public DbSet<Restaurant> Restaurants { get; set;}
        public DbSet<Customer> Customers { get; set; }
        //addressing decimals in each entities

        //this is a constructor
        public ApplicationDbContext(
            DbContextOptions options, 
            IOptions<OperationalStoreOptions>
            operationalStoreOptions
            ) : base(options, operationalStoreOptions)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Food>()
                .HasOne(c => c.Restaurant)
                .WithMany(u => u.Menu)
                .HasForeignKey(u => u.RestId)
                .IsRequired();


/*          
            
            modelBuilder.ApplyConfiguration(new StaffSeedConfiguration());
                        */
            
            
            
            modelBuilder.Entity<Payment>()
                .Property(p => p.PaymentTotal)
                .HasColumnType("decimal(18, 2)"); // Adjust precision and scale as needed
            
            modelBuilder.Entity<Order>()
                .Property(p => p.OrderPrice)
                .HasColumnType("decimal(18, 2)"); 

            modelBuilder.Entity<Food>()
                .Property(p => p.FoodCost)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Customer>()
                .Property(p => p.CustPayment)
                .HasColumnType("decimal(18, 2)");

            // Add any other configurations or relationships 
            modelBuilder.ApplyConfiguration(new FoodSeedConfiguration());
            modelBuilder.ApplyConfiguration(new RestaurantSeedConfiguration());
            modelBuilder.ApplyConfiguration(new RoleSeedConfiguration());
            modelBuilder.ApplyConfiguration(new UserSeedConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleSeedConfiguration()); //has to come after Role and User as it depends on them (those with FKs are last)

        }
    }
}
