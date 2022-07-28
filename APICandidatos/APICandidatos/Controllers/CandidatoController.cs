﻿using System;
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
    public class CandidatoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CandidatoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Candidato
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Candidato>>> GetCandidato()
        {
          if (_context.Candidato == null)
          {
              return NotFound();
          }
            return await _context.Candidato.ToListAsync();
        }

        // GET: api/Candidato/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Candidato>> GetCandidato(int id)
        {
          if (_context.Candidato == null)
          {
              return NotFound();
          }
            var candidato = await _context.Candidato.FindAsync(id);

            if (candidato == null)
            {
                return NotFound();
            }

            return candidato;
        }

        // PUT: api/Candidato/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCandidato(int id, Candidato candidato)
        {
            if (id != candidato.IdCandidato)
            {
                return BadRequest();
            }

            _context.Entry(candidato).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidatoExists(id))
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

        // POST: api/Candidato
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Candidato>> PostCandidato(Candidato candidato)
        {
          if (_context.Candidato == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Candidato'  is null.");
          }
            _context.Candidato.Add(candidato);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCandidato", new { id = candidato.IdCandidato }, candidato);
        }

        // DELETE: api/Candidato/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCandidato(int id)
        {
            if (_context.Candidato == null)
            {
                return NotFound();
            }
            var candidato = await _context.Candidato.FindAsync(id);
            if (candidato == null)
            {
                return NotFound();
            }

            _context.Candidato.Remove(candidato);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CandidatoExists(int id)
        {
            return (_context.Candidato?.Any(e => e.IdCandidato == id)).GetValueOrDefault();
        }
    }
}
