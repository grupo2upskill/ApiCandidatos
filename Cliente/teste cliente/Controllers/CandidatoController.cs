using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text;


namespace teste_cliente.Models
{
    public class CandidatoController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Candidato> candidatoList = new List<Candidato>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5167/api/Candidato"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    candidatoList = JsonConvert.DeserializeObject<List<Candidato>>(apiResponse);
                }
            }

            return View(candidatoList);
        }
        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Get(int id)
        {
            Candidato candadito = new Candidato();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5167/api/Candidato/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    candadito = JsonConvert.DeserializeObject<Candidato>(apiResponse);
                }
            }
            return View(candadito);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Models.Candidato candidato, IFormFile file)
        {

             //if (Request.Form.Files.Count > 0)
             //{
             //    file = Request.Form.Files.FirstOrDefault();
             //    var dataStream = new MemoryStream();
             //    file.CopyToAsync(dataStream);
             //    candidato.Foto = dataStream.ToArray();
             //}

            using (var httpClient = new HttpClient())
            {

                StringContent content = new StringContent(JsonConvert.SerializeObject(candidato), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("http://localhost:5167/api/Candidato/", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    candidato = JsonConvert.DeserializeObject<Candidato>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Candidato candidato = new Candidato();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5167/api/Candidato/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    candidato = JsonConvert.DeserializeObject<Candidato>(apiResponse);
                }
            }
            return View(candidato);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Models.Candidato candidato, IFormFile file)
        {
            //if (Request.Form.Files.Count > 0)
            //{
            //    file = Request.Form.Files.FirstOrDefault();
            //    var dataStream = new MemoryStream();
            //    file.CopyToAsync(dataStream);
            //    candidato.Foto = dataStream.ToArray();
            //}
            Candidato c = new Candidato();
            
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(candidato), Encoding.UTF8, "application/json");
                    using (var response = await httpClient.PutAsync("http://localhost:5167/api/Candidato/" +candidato.IdCandidato, content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ViewBag.Result = "Success";
                        c = JsonConvert.DeserializeObject<Candidato>(apiResponse);
                    }

                }
            
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            Candidato candidato = new Candidato();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5167/api/Candidato/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    candidato = JsonConvert.DeserializeObject<Candidato>(apiResponse);

                }
                return View(candidato);
            }
        }

            [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:5167/api/Candidato/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
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

