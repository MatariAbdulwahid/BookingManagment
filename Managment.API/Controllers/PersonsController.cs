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
    public class PersonsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PersonsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Persons
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CPerson>>> GetPersons()
        {
            return await _context.Persons.ToListAsync();
        }

        // GET: api/Persons/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CPerson>> GetCPerson(int id)
        {
            var cPerson = await _context.Persons.FindAsync(id);

            if (cPerson == null)
            {
                return NotFound();
            }

            return cPerson;
        }

        // PUT: api/Persons/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCPerson(int id, CPerson cPerson)
        {
            if (id != cPerson.Id)
            {
                return BadRequest();
            }

            _context.Entry(cPerson).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CPersonExists(id))
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

        // POST: api/Persons
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CPerson>> PostCPerson(CPerson cPerson)
        {
            _context.Persons.Add(cPerson);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCPerson", new { id = cPerson.Id }, cPerson);
        }

        // DELETE: api/Persons/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CPerson>> DeleteCPerson(int id)
        {
            var cPerson = await _context.Persons.FindAsync(id);
            if (cPerson == null)
            {
                return NotFound();
            }

            _context.Persons.Remove(cPerson);
            await _context.SaveChangesAsync();

            return cPerson;
        }

        private bool CPersonExists(int id)
        {
            return _context.Persons.Any(e => e.Id == id);
        }
    }
}
