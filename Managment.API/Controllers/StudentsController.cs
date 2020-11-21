using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Managment.Booking;
using Managment.Data;

namespace Managment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CStudent>>> GetStudents()
        {
            return await _context.Students.ToListAsync();
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CStudent>> GetCStudent(int id)
        {
            var cStudent = await _context.Students.FindAsync(id);

            if (cStudent == null)
            {
                return NotFound();
            }

            return cStudent;
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCStudent(int id, CStudent cStudent)
        {
            if (id != cStudent.Id)
            {
                return BadRequest();
            }

            _context.Entry(cStudent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CStudentExists(id))
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

        // POST: api/Students
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CStudent>> PostCStudent(CStudent cStudent)
        {
            _context.Students.Add(cStudent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCStudent", new { id = cStudent.Id }, cStudent);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CStudent>> DeleteCStudent(int id)
        {
            var cStudent = await _context.Students.FindAsync(id);
            if (cStudent == null)
            {
                return NotFound();
            }

            _context.Students.Remove(cStudent);
            await _context.SaveChangesAsync();

            return cStudent;
        }

        private bool CStudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
