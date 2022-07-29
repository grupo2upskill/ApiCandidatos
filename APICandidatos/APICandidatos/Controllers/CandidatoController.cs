using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICandidatos.Controllers
{
    public class CandidatoController : Controller
    {
        // GET: CandidatoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CandidatoController/Details/5
        public ActionResult Details(int id)
        {
<<<<<<< Updated upstream
            return View();
        }

        // GET: CandidatoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CandidatoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
=======
          if (_context.Candidato == null)
          {
              return NotFound();
          }       
          return await _context.Candidato.ToListAsync();
        }

        // GET: api/Candidato/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Candidato>> GetCandidato(int? id)
        {
            if (id == null || _context.Candidato == null)
            {
                return NotFound();
            }
            var candidato = await _context.Candidato
               .FirstOrDefaultAsync(m => m.IdCandidato == id);
            if (candidato == null)
            {
                return NotFound();
            }

            return candidato;
        }

        // PUT: api/Candidato/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCandidato(int id, [Bind("IdCandidato,Nome,Email,Telefone,Morada,DataNasc,LinkedIn,Facebook,FileCV")] Candidato candidato)
>>>>>>> Stashed changes
        {
            try
            {
<<<<<<< Updated upstream
                return RedirectToAction(nameof(Index));
=======
                _context.Update(candidato);
                await _context.SaveChangesAsync();
>>>>>>> Stashed changes
            }
            catch
            {
<<<<<<< Updated upstream
                return View();
            }
        }

        // GET: CandidatoController/Edit/5
        public ActionResult Edit(int id)
=======
                if (!CandidatoExists(candidato.IdCandidato))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return (IActionResult)candidato;
        }

        // POST: api/Candidato
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Candidato>> PostCandidato([Bind("IdCandidato,Nome,Email,Telefone,Morada,MSSQL_DroppedLedgerColumn_IdCV_6391BEEC1FF44B4DADB858C1623BE4F9,DataNasc,MSSQL_DroppedLedgerColumn_Foto_8FC802CAF17540BBA6D015DD768153C4,LinkedIn,Facebook,ledger_start_transaction_id,ledger_end_transaction_id,ledger_start_sequence_number,ledger_end_sequence_number,FileCV")] Candidato candidato)
>>>>>>> Stashed changes
        {
            return View();
        }

        // POST: CandidatoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
<<<<<<< Updated upstream
            catch
            {
                return View();
=======
            var candidato = await _context.Candidato.FindAsync(id);
            if (candidato != null)
            {
                _context.Candidato.Remove(candidato);
>>>>>>> Stashed changes
            }
        }

<<<<<<< Updated upstream
        // GET: CandidatoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
=======
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
>>>>>>> Stashed changes
        }

        // POST: CandidatoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
