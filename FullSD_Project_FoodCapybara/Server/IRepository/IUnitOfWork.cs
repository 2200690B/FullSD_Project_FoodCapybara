using FullSD_Project_FoodCapybara.Shared.Domain;
using System.Drawing;

namespace FullSD_Project_FoodCapybara.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        // Has save method
        Task Save(HttpContext httpContext);
        IGenericRepository<Customer> Customers{ get; }
        IGenericRepository<Food> Foods { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<OrderItem> OrderItems { get; }
        IGenericRepository<Payment> Payments { get; }
        IGenericRepository<Restaurant> Restaurants { get; }
        IGenericRepository<Review> Reviews{ get; }
        IGenericRepository<Staff> Staffs { get; }

    }
}
