using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PRScapstone.Models;

namespace PRScapstone.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly PRSDbContext _context;

        public RequestsController(PRSDbContext context)
        {
            _context = context;
        }

        // GET: api/Requests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Request>>> GetRequests()
        {
            return await _context.Requests.ToListAsync();
        }

        // GET: api/Requests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Request>> GetRequest(int id)
        {
            var request = await _context.Requests.FindAsync(id);

            if (request == null)
            {
                return NotFound();
            }

            return request;
        }
        [HttpGet("reviews/{userId}")]
        public async Task<ActionResult<IEnumerable<Request>>> GetReviews(int userId)
        {
            // Get all requests in "REVIEW" status that are not owned by the user with the specified ID
             return await _context.Requests
                .Where(r => r.Status == "REVIEW" && r.UserId != userId)
                .ToListAsync();

           
        }

        // PUT: api/Requests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754


        [HttpPut("review/{id}")]
        public async Task<ActionResult<IEnumerable<Request>>> Reviews(int id)
        {
            // Get the request by ID
            Request request = _context.Requests.FirstOrDefault(r => r.Id == id);

            // Check if the total of the request is less than or equal to $50
            if (request.Total <= 50)
            {
                // If so, set the status directly to "APPROVED"
                request.Status = "APPROVED";
            }
            else
            {
                // Otherwise, set the status to "REVIEW"
                request.Status = "REVIEW";
            }

            // Update the status of the request in the database
            _context.SaveChanges();

            // Return a success message
            return Ok(new { message = "Request updated successfully." });
        }
        [HttpPut("approve/{id}")]
        public async Task<IActionResult> Approve(int id)
        {
            // Get the request by ID
            Request request = _context.Requests.FirstOrDefault(r => r.Id == id);

            // Set the status of the request to "APPROVED"
             request.Status = "APPROVED";

            // Update the status of the request in the database
            _context.SaveChanges();

            // Return a success message
           return Ok(new { message = "Request updated successfully." });
        }
        [HttpPut("reject/{id}")]
        public async Task<IActionResult> Reject(int id)
        {
            // Get the request by ID
            Request request = _context.Requests.FirstOrDefault(r => r.Id == id);

            // Set the status of the request to "REJECTED"
            request.Status = "REJECTED";

            // Update the status of the request in the database
            _context.SaveChanges();

            // Return a success message
            return Ok(new { message = "Request updated successfully." });
        }


        [HttpPut("{id}")]

        public async Task<IActionResult> PutRequest(int id, Request request)
        {
            if (id != request.Id)
            {
                return BadRequest();
            }

            _context.Entry(request).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RequestExists(id))
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

        // POST: api/Requests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Request>> PostRequest(Request request)
        {
            _context.Requests.Add(request);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRequest", new { id = request.Id }, request);
        }

        // DELETE: api/Requests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequest(int id)
        {
            var request = await _context.Requests.FindAsync(id);
            if (request == null)
            {
                return NotFound();
            }

            _context.Requests.Remove(request);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RequestExists(int id)
        {
            return _context.Requests.Any(e => e.Id == id);
        }
    }
}
