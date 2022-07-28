using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APICandidatos.Data;
using APICandidatos.Model;

namespace APICandidatos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaEmpregoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OfertaEmpregoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/OfertaEmprego
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OfertaEmprego>>> GetOfertaEmprego()
        {
          if (_context.OfertaEmprego == null)
          {
              return NotFound();
          }
            return await _context.OfertaEmprego.ToListAsync();
        }

        // GET: api/OfertaEmprego/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OfertaEmprego>> GetOfertaEmprego(int id)
        {
          if (_context.OfertaEmprego == null)
          {
              return NotFound();
          }
            var ofertaEmprego = await _context.OfertaEmprego.FindAsync(id);

            if (ofertaEmprego == null)
            {
                return NotFound();
            }

            return ofertaEmprego;
        }

        // PUT: api/OfertaEmprego/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutOfertaEmprego(OfertaEmprego ofertaEmprego)
        {
           
            _context.Entry(ofertaEmprego).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OfertaEmpregoExists(ofertaEmprego.IdEmpresa))
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

        // POST: api/OfertaEmprego
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OfertaEmprego>> PostOfertaEmprego(OfertaEmprego ofertaEmprego)
        {
          if (_context.OfertaEmprego == null)
          {
              return Problem("Entity set 'ApplicationDbContext.OfertaEmprego'  is null.");
          }
            _context.OfertaEmprego.Add(ofertaEmprego);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOfertaEmprego", new { id = ofertaEmprego.IdOferta }, ofertaEmprego);
        }

        // DELETE: api/OfertaEmprego/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOfertaEmprego(int id)
        {
            if (_context.OfertaEmprego == null)
            {
                return NotFound();
            }
            var ofertaEmprego = await _context.OfertaEmprego.FindAsync(id);
            if (ofertaEmprego == null)
            {
                return NotFound();
            }

            _context.OfertaEmprego.Remove(ofertaEmprego);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OfertaEmpregoExists(int id)
        {
            return (_context.OfertaEmprego?.Any(e => e.IdOferta == id)).GetValueOrDefault();
        }
    }
}
