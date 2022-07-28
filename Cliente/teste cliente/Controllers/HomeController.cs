
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using teste_cliente.Models;

namespace teste_cliente.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            List<Models.OfertaEmprego> ofertaEmpregoList = new List<Models.OfertaEmprego>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5167/api/OfertaEmprego"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ofertaEmpregoList = JsonConvert.DeserializeObject<List<Models.OfertaEmprego>>(apiResponse);
                }
            }
            return View(ofertaEmpregoList);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}