using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;
using teste_cliente.Model;


namespace teste_cliente.Models
{
    public class EmpresaController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Empresa> empresaList = new List<Empresa>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5167/api/Empresa"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    empresaList = JsonConvert.DeserializeObject<List<Empresa>>(apiResponse);
                }
            }

            return View(empresaList);
        }
        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Get(int id)
        {
            Empresa empresa = new Empresa();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5167/api/Empresa/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    empresa = JsonConvert.DeserializeObject<Empresa>(apiResponse);
                }
            }
            return View(empresa);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


                [HttpPost]
                public async Task<IActionResult> Create(Model.Empresa empresa)
                {
                    if (ModelState.IsValid)
                    {
                        using (var httpClient = new HttpClient())
                        {
                            StringContent content = new StringContent(JsonConvert.SerializeObject(empresa), Encoding.UTF8, "application/json");
                            using (var response = await httpClient.PostAsync("http://localhost:5167/api/Empresa/", content))
                            {
                                string apiResponse = await response.Content.ReadAsStringAsync();
                                empresa = JsonConvert.DeserializeObject<Empresa>(apiResponse);
                            }
                        }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


/*

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
                */
    }
}

