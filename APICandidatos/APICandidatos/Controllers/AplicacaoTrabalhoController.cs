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
    public class AplicacaoTrabalhoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AplicacaoTrabalhoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/AplicacaoTrabalho
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AplicacaoTrabalho>>> GetAplicacaoTrabalho()
        {
          if (_context.AplicacaoTrabalho == null)
          {
              return NotFound();
          }
            return await _context.AplicacaoTrabalho.ToListAsync();
        }

        // GET: api/AplicacaoTrabalho/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AplicacaoTrabalho>> GetAplicacaoTrabalho(int id)
        {
          if (_context.AplicacaoTrabalho == null)
          {
              return NotFound();
          }
            var aplicacaoTrabalho = await _context.AplicacaoTrabalho.FindAsync(id);

            if (aplicacaoTrabalho == null)
            {
                return NotFound();
            }

            return aplicacaoTrabalho;
        }

        // PUT: api/AplicacaoTrabalho/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAplicacaoTrabalho(int id, AplicacaoTrabalho aplicacaoTrabalho)
        {
            if (id != aplicacaoTrabalho.IdApl)
            {
                return BadRequest();
            }

            _context.Entry(aplicacaoTrabalho).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AplicacaoTrabalhoExists(id))
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

        // POST: api/AplicacaoTrabalho
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AplicacaoTrabalho>> PostAplicacaoTrabalho(AplicacaoTrabalho aplicacaoTrabalho)
        {
          if (_context.AplicacaoTrabalho == null)
          {
              return Problem("Entity set 'ApplicationDbContext.AplicacaoTrabalho'  is null.");
          }
            _context.AplicacaoTrabalho.Add(aplicacaoTrabalho);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAplicacaoTrabalho", new { id = aplicacaoTrabalho.IdApl }, aplicacaoTrabalho);
        }

        // DELETE: api/AplicacaoTrabalho/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAplicacaoTrabalho(int id)
        {
            if (_context.AplicacaoTrabalho == null)
            {
                return NotFound();
            }
            var aplicacaoTrabalho = await _context.AplicacaoTrabalho.FindAsync(id);
            if (aplicacaoTrabalho == null)
            {
                return NotFound();
            }

            _context.AplicacaoTrabalho.Remove(aplicacaoTrabalho);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AplicacaoTrabalhoExists(int id)
        {
            return (_context.AplicacaoTrabalho?.Any(e => e.IdApl == id)).GetValueOrDefault();
        }
    }
}
