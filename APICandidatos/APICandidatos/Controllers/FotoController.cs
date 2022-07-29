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
    public class FotoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FotoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Foto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Foto>>> GetFoto()
        {
          if (_context.Foto == null)
          {
              return NotFound();
          }
            return await _context.Foto.ToListAsync();
        }

        // GET: api/Foto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Foto>> GetFoto(int id)
        {
          if (_context.Foto == null)
          {
              return NotFound();
          }
            var foto = await _context.Foto.FindAsync(id);

            if (foto == null)
            {
                return NotFound();
            }

            return foto;
        }

        // PUT: api/Foto/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFoto(int id, Foto foto)
        {
            if (id != foto.Id)
            {
                return BadRequest();
            }

            _context.Entry(foto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FotoExists(id))
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

        // POST: api/Foto
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Foto>> PostFoto(Foto foto)
        {
          if (_context.Foto == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Foto'  is null.");
          }
            _context.Foto.Add(foto);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFoto", new { id = foto.Id }, foto);
        }

        // DELETE: api/Foto/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFoto(int id)
        {
            if (_context.Foto == null)
            {
                return NotFound();
            }
            var foto = await _context.Foto.FindAsync(id);
            if (foto == null)
            {
                return NotFound();
            }

            _context.Foto.Remove(foto);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FotoExists(int id)
        {
            return (_context.Foto?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
