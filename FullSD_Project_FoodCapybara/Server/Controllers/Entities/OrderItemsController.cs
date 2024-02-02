using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FullSD_Project_FoodCapybara.Server.Data;
using FullSD_Project_FoodCapybara.Shared.Domain;
using FullSD_Project_FoodCapybara.Server.IRepository;

//used as a base controller to copy and paste the rest of the entityControllers

namespace FullSD_Project_FoodCapybara.Server.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderItemsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        // GET: api/OrderItems
        [HttpGet]
        public async Task<IActionResult> GetOrderItems()
        {
            var orderitems = await _unitOfWork.OrderItems.GetAll();
            return Ok(orderitems);
        }

        // GET: api/OrderItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderItem(int id)
        {
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.Id == id);

            if (orderitem == null)
            {
                return NotFound();
            }

            return Ok(orderitem);
        }

        // PUT: api/OrderItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderItem(int id, OrderItem orderitem)
        {
            if (id != orderitem.Id)
            {
                return BadRequest();
            }
;
            _unitOfWork.OrderItems.Update(orderitem);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await OrderItemExists(id))
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

        // POST: api/OrderItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderItem>> PostOrderItem(OrderItem orderitem)
        {
            if (_unitOfWork.OrderItems == null)
            {
                return Problem("Entity set 'ApplicationDbContext.OrderItems'  is null.");
            }
            await _unitOfWork.OrderItems.Insert(orderitem);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetOrderItem", new { id = orderitem.Id }, orderitem);
        }

        // DELETE: api/OrderItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderItem(int id)
        {
            if (_unitOfWork.OrderItems == null)
            {
                return NotFound();
            }

            var orderitem = await _unitOfWork.OrderItems.Get(q => q.Id == id);
            if (orderitem == null)
            {
                return NotFound();
            }

            await _unitOfWork.OrderItems.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> OrderItemExists(int id)
        {
            var orderitem = await _unitOfWork.OrderItems.Get(q => q.Id == id);
            return orderitem != null;
        }
    }
}
