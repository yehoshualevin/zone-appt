using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using qfbackend1.Models;

namespace qfbackend1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeSlotsController : ControllerBase
    {
        private readonly QFJContext _context;

        public TimeSlotsController(QFJContext context)
        {
            _context = context;
        }

        // GET: api/TimeSlots
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TimeSlot>>> GetTimeSlots()
        {
          if (_context.TimeSlots == null)
          {
              return NotFound();
          }
            return await _context.TimeSlots.ToListAsync();
        }

        // GET: api/TimeSlots/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TimeSlot>> GetTimeSlot(int id)
        {
          if (_context.TimeSlots == null)
          {
              return NotFound();
          }
            var timeSlot = await _context.TimeSlots.FindAsync(id);

            if (timeSlot == null)
            {
                return NotFound();
            }

            return timeSlot;
        }


        // POST: api/TimeSlots
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TimeSlot>> PostTimeSlot(TimeSlot timeSlot)
        {
          if (_context.TimeSlots == null)
          {
              return Problem("Entity set 'QFJContext.TimeSlots'  is null.");
          }
            _context.TimeSlots.Add(timeSlot);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTimeSlot", new { id = timeSlot.Id }, timeSlot);
        }

        // DELETE: api/TimeSlots/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTimeSlot(int id)
        {
            if (_context.TimeSlots == null)
            {
                return NotFound();
            }
            var timeSlot = await _context.TimeSlots.FindAsync(id);
            if (timeSlot == null)
            {
                return NotFound();
            }

            _context.TimeSlots.Remove(timeSlot);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TimeSlotExists(int id)
        {
            return (_context.TimeSlots?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
