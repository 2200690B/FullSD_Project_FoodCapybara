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

namespace FullSD_Project_FoodCapybara.Server.Controllers.Entities
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext_context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public FoodsController(ApplicationDbContextcontext)
        public FoodsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/Foods
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Food>>>GetFoods()
        public async Task<IActionResult> GetFoods()
        {
            //Refactored
            //return await _context.Foods.ToListAsync();
            var Foods = await _unitOfWork.Foods.GetAll(includes: q => q.Include(x => x.Restaurant));
            return Ok(Foods);

        }

        // GET: api/Foods/5
        [HttpGet("{id}")]
        //Refactored
        public async Task<ActionResult<Food>>GetFood(int id)
        //public async Task<IActionResult> GetFood(int id)
        {
            //Refactored
            //var food = await _context.Foods.FindAsync(id);
            var food = await _unitOfWork.Foods.Get(q => q.Id == id);

            if (food == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(food);
        }

        // PUT: api/Foods/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFood(int id, Food food)
        {
            if (id != food.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(food).State = EntityState.Modified;
            _unitOfWork.Foods.Update(food);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!FoodExists(id))
                if (!await FoodExists(id))
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

        // POST: api/Foods
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Food>> PostFood(Food food)
        {
            //Refactored
            //if (_context.Foods == null)
            if (_unitOfWork.Foods == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Foods'  is null.");
            }
            //_context.Foods.Add(food);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Foods.Insert(food);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetFood", new { id = food.Id }, food);
        }

        // DELETE: api/Foods/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFood(int id)
        {
            //Refactored
            //if (_context.Foods == null)
            if (_unitOfWork.Foods == null)
            {
                return NotFound();
            }

            //Refactored
            //var food = await _context.Foods.FindAsync(id);
            var food = await _unitOfWork.Foods.Get(q => q.Id == id);
            if (food == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Foods.Remove(food);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Foods.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool FoodExists(int id)
        private async Task<bool> FoodExists(int id)
        {
            //Refactored
            //return _context.Foods.Any(e => e.Id == id);
            var food = await _unitOfWork.Foods.Get(q => q.Id == id);
            return food != null;
        }
    }
}
