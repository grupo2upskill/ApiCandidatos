using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using teste_cliente.Models;

namespace teste_cliente.Controllers
{
    public class OfertaEmpregoController : Controller
    {
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
        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Get(int id)
        {
            OfertaEmprego ofertaEmprego = new OfertaEmprego();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5167/api/OfertaEmprego/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ofertaEmprego = JsonConvert.DeserializeObject<OfertaEmprego>(apiResponse);
                }
            }
            return View(ofertaEmprego);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(Models.OfertaEmprego ofertaEmprego)
        {
            if (ModelState.IsValid)
           {
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(ofertaEmprego), Encoding.UTF8, "application/json");
                    using (var response = await httpClient.PostAsync("http://localhost:5167/api/OfertaEmprego/", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ofertaEmprego = JsonConvert.DeserializeObject<Models.OfertaEmprego>(apiResponse);
                    }
                }
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            Models.OfertaEmprego ofertaEmprego = new Models.OfertaEmprego();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5167/api/OfertaEmprego/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ofertaEmprego = JsonConvert.DeserializeObject<Models.OfertaEmprego>(apiResponse);

                }
                return View(ofertaEmprego);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Models.OfertaEmprego ofertaEmprego)
        {
            Models.OfertaEmprego o = new Models.OfertaEmprego();

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(ofertaEmprego), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("http://localhost:5167/api/OfertaEmprego/" + ofertaEmprego.IdOferta, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    o = JsonConvert.DeserializeObject<Models.OfertaEmprego>(apiResponse);
                }
                return RedirectToAction("Index");
            }
            return View(o);
        }


        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            Models.OfertaEmprego ofertaEmprego = new Models.OfertaEmprego();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5167/api/OfertaEmprego/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ofertaEmprego = JsonConvert.DeserializeObject<Models.OfertaEmprego>(apiResponse);

                }
                return View(ofertaEmprego);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:5167/api/OfertaEmprego/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("Index");
        }

    }
}

