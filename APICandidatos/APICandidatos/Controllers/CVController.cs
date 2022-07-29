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
    public class CVController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CVController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CV
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CV>>> GetCV()
        {
            if (_context.CV == null)
            {
                return NotFound();
            }
            var programacandidatosBDContext = _context.CV.Include(c => c.IdCandidatoCvNavigation);
            return await programacandidatosBDContext.ToListAsync();
        }

        // GET: api/CV/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CV>> GetCV(int id)
        {
            if (id == null || _context.CV == null)
            {
                return NotFound();
            }

            var cV = await _context.CV
                .Include(c => c.IdCandidatoCvNavigation)
                .FirstOrDefaultAsync(m => m.IdCV == id);

            if (cV == null)
            {
                return NotFound();
            }

            return cV;
        }

        // PUT: api/CV/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<IActionResult> PutCV(int id, [Bind("IdCV,Nome,Localizacao,Educacao,ExpProfissional,Competencias,Interesses,IdCandidatoCv")] CV cV)
        {
            if (id != cV.IdCV)
            {
                return NotFound();
            }
            try
            {
                _context.Update(cV);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CVExists(cV.IdCV))
                {
                    return NotFound("Cv não encontrado");
                }
                else
                {
                    throw;
                }
            }
            return (IActionResult)cV;
        }

        // POST: api/CV
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CV>> PostCV(CV cV)
        {
            if (_context.CV == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CV'  is null.");
            }
            _context.CV.Add(cV);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCV", new { id = cV.IdCV }, cV);
        }

        // DELETE: api/CV/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCV(int id)
        {
            if (_context.CV == null)
            {
                return NotFound();
            }
            var cV = await _context.CV.FindAsync(id);
            if (cV != null)
            {
                _context.CV.Remove(cV);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool CVExists(int id)
        {
            return (_context.CV?.Any(e => e.IdCV == id)).GetValueOrDefault();
        }
    }
}
