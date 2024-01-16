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
    public class PaymentsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext_context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public PaymentsController(ApplicationDbContextcontext)
        public PaymentsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/Payments
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Payment>>>GetPayments()
        public async Task<IActionResult> GetPayments()
        {
            //Refactored
            //return await _context.Payments.ToListAsync();
            var payments = await _unitOfWork.Payments.GetAll();
            return Ok(payments);
        }

        // GET: api/Payments/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Payment>>GetPayment(int id)
        public async Task<IActionResult> GetPayment(int id)
        {
            //Refactored
            //var payment = await _context.Payments.FindAsync(id);
            var payment = await _unitOfWork.Payments.Get(q => q.Id == id);

            if (payment == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(payment);
        }

        // PUT: api/Payments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(int id, Payment payment)
        {
            if (id != payment.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(payment).State = EntityState.Modified;
            _unitOfWork.Payments.Update(payment);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!PaymentExists(id))
                if (!await PaymentExists(id))
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

        // POST: api/Payments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Payment>> PostPayment(Payment payment)
        {
            //Refactored
            //if (_context.Payments == null)
            if (_unitOfWork.Payments == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Payments'  is null.");
            }
            //_context.Payments.Add(payment);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Payments.Insert(payment);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPayment", new { id = payment.Id }, payment);
        }

        // DELETE: api/Payments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(int id)
        {
            //Refactored
            //if (_context.Payments == null)
            if (_unitOfWork.Payments == null)
            {
                return NotFound();
            }

            //Refactored
            //var payment = await _context.Payments.FindAsync(id);
            var payment = await _unitOfWork.Payments.Get(q => q.Id == id);
            if (payment == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Payments.Remove(payment);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Payments.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool PaymentExists(int id)
        private async Task<bool> PaymentExists(int id)
        {
            //Refactored
            //return _context.Payments.Any(e => e.Id == id);
            var payment = await _unitOfWork.Payments.Get(q => q.Id == id);
            return payment != null;
        }
    }
}
