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
    public class ReviewsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext_context;
        private readonly IUnitOfWork _unitOfWork;

        //Refactored
        //public ReviewsController(ApplicationDbContextcontext)
        public ReviewsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context
            _unitOfWork = unitOfWork;
        }


        // GET: api/Reviews
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Review>>>GetReviews()
        public async Task<IActionResult> GetReviews()
        {
            //Refactored
            //return await _context.Reviews.ToListAsync();
            var reviews = await _unitOfWork.Reviews.GetAll();
            return Ok(reviews);
        }

        // GET: api/Reviews/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Review>>GetReview(int id)
        public async Task<IActionResult> GetReview(int id)
        {
            //Refactored
            //var review = await _context.Reviews.FindAsync(id);
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);

            if (review == null)
            {
                return NotFound();
            }

            //Refactored
            return Ok(review);
        }

        // PUT: api/Reviews/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReview(int id, Review review)
        {
            if (id != review.Id)
            {
                return BadRequest();
            }

            //Refactored
            //_context.Entry(review).State = EntityState.Modified;
            _unitOfWork.Reviews.Update(review);

            try
            {
                //Refactored
                //await _context.SaveChangesAsync();
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!ReviewExists(id))
                if (!await ReviewExists(id))
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

        // POST: api/Reviews
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Review>> PostReview(Review review)
        {
            //Refactored
            //if (_context.Reviews == null)
            if (_unitOfWork.Reviews == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Reviews'  is null.");
            }
            //_context.Reviews.Add(review);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Reviews.Insert(review);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetReview", new { id = review.Id }, review);
        }

        // DELETE: api/Reviews/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            //Refactored
            //if (_context.Reviews == null)
            if (_unitOfWork.Reviews == null)
            {
                return NotFound();
            }

            //Refactored
            //var review = await _context.Reviews.FindAsync(id);
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);
            if (review == null)
            {
                return NotFound();
            }

            //Refactored
            //_context.Reviews.Remove(review);
            //await _context.SaveChangesAsync();
            await _unitOfWork.Reviews.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        //Refactored
        //private bool ReviewExists(int id)
        private async Task<bool> ReviewExists(int id)
        {
            //Refactored
            //return _context.Reviews.Any(e => e.Id == id);
            var review = await _unitOfWork.Reviews.Get(q => q.Id == id);
            return review != null;
        }
    }
}
