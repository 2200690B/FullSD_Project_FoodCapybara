using FullSD_Project_FoodCapybara.Server.Data;
using FullSD_Project_FoodCapybara.Server.IRepository;
using FullSD_Project_FoodCapybara.Server.Models;
using FullSD_Project_FoodCapybara.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace FullSD_Project_FoodCapybara.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Food> _foods;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<OrderItem> _orderitems;
        private IGenericRepository<Payment> _payments;
        private IGenericRepository<Restaurant> _restaurants;
        private IGenericRepository<Review> _reviews;
        private IGenericRepository<Staff> _staffs;

        private UserManager<ApplicationUser> _userManager;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IGenericRepository<Customer> Customers
            => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Food> Foods
            => _foods ??= new GenericRepository<Food>(_context);
        public IGenericRepository<Order> Orders
            => _orders ??= new GenericRepository<Order>(_context);
        public IGenericRepository<OrderItem> OrderItems
            => _orderitems ??= new GenericRepository<OrderItem>(_context);
        public IGenericRepository<Payment> Payments
            => _payments ??= new GenericRepository<Payment>(_context);
        public IGenericRepository<Restaurant> Restaurants
            => _restaurants ??= new GenericRepository<Restaurant>(_context);
        public IGenericRepository<Review> Reviews
            => _reviews ??= new GenericRepository<Review>(_context);
        public IGenericRepository<Staff> Staffs
            => _staffs ??= new GenericRepository<Staff>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        //to intercept changes made to entities before saving them to the database
        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            string user = "System";

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach ( var entry in entries )
            {
                ((Order)entry.Entity).OrderDate = DateTime.Now;
                ((Payment)entry.Entity).PaymentDateTime = DateTime.Now;
                ((Review)entry.Entity).ReviewDateTime = DateTime.Now;
                if (entry.State == EntityState.Added)
                {
                    ((Order)entry.Entity).OrderDate = DateTime.Now;
                    ((Payment)entry.Entity).PaymentDateTime = DateTime.Now;
                    ((Review)entry.Entity).ReviewDateTime = DateTime.Now;
                }
            }

            /*foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }*/

            await _context.SaveChangesAsync();
        }
    }
}
