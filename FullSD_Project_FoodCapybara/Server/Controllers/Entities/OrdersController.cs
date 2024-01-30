using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FullSD_Project_FoodCapybara.Server.IRepository;
using FullSD_Project_FoodCapybara.Shared.Domain;

namespace FullSD_Project_FoodCapybara.Server.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // a service or class reseponsible for managing unit of work pattern
        //(coordinating the data acces operations across multiple repositories)
        private readonly IUnitOfWork _unitOfWork;

        //injects an instance of IUnitOfWork
        public OrdersController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/Orders
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Order>>>GetOrders()
        public async Task<IActionResult> GetOrders()
        {
            //Refactored
            //return await _context.Orders.ToListAsync();
            var orders = await _unitOfWork.Orders.GetAll();
            return Ok(orders);
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Order>>GetOrder(int id)
        public async Task<IActionResult> GetOrder(int id)
        {
            //Refactored
            //var order = await _context.Orders.FindAsync(id);
            var order = await _unitOfWork.Orders.Get(q => q.Id == id);

            if (order == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(order);
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(order).State = EntityState.Modified;
            _unitOfWork.Orders.Update(order);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!OrderExists(id))
                if (!await OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        //public async Task<ActionResult<Order>> PostOrder(Order order)
        public async Task<ActionResult<Order>> PostOrder(List<OrderItem> orderItems)    //takes a list of CartItem objects as the payload in the request body
        {
            // Create an order and order items based on the received cartItems
            var order = new Order
            {
                // Set other properties of the order...
                OrderItems = orderItems.Select(item => new OrderItem
                {
                    FoodID = item.FoodID,
                    OIQuantity = item.OIQuantity
                }).ToList()
            };

            if (_unitOfWork.Orders == null) //shopping cart might expect orders to be non-null
            {   //(Problem)returns an HTTP 500 Internal Server Error status code
                return Problem("Entity set 'ApplicationDbContext.Orders'  is null.");
            }
            await _unitOfWork.Orders.Insert(order);     // Inserts the newly created order into the database using the IUnitOfWork interface
            await _unitOfWork.Save(HttpContext);        // Saves changes to the database

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);   //CreatedAtAction)Returns a 201 Created status code along with details of the created order
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            //Refactored
            //if (_context.Orders == null)
            if (_unitOfWork.Orders == null)
            {
                return NotFound();
            }

            //Refactored
            //var order = await _context.Orders.FindAsync(id);
            var order = await _unitOfWork.Orders.Get(q => q.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Orders.Remove(order);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Orders.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool OrderExists(int id)
        private async Task<bool> OrderExists(int id)
        {
            //Refactored
            //return _context.Orders.Any(e => e.Id == id);
            var order = await _unitOfWork.Orders.Get(q => q.Id == id);
            return order != null;
        }
    }
}
