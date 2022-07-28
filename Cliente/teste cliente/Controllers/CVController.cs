using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using teste_cliente.Models;

namespace teste_cliente.Controllers
{
    public class CVController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<CV> cvList = new List<CV>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7118/api/CV"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cvList = JsonConvert.DeserializeObject<List<CV>>(apiResponse);
                }
            }
            return View(cvList);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Get(int id)
        {
            CV cv = new CV();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7118/api/CV" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cv = JsonConvert.DeserializeObject<CV>(apiResponse);
                }
            }
            return View(cv);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Models.CV cv)
        {
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    StringContent content = new StringContent(JsonConvert.SerializeObject(cv), Encoding.UTF8, "application/json");
                    using (var response = await httpClient.PostAsync("https://localhost:7118/api/CV", content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        cv = JsonConvert.DeserializeObject<CV>(apiResponse);
                    }
                }
                return View(cv);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int obj)
        {
            CV cv = new CV();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7118/api/CV" + obj))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cv = JsonConvert.DeserializeObject<CV>(apiResponse);
                }
               // return View(cv);

            }
            return View(cv);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CV cv)
        {
            CV c = new CV();
            if (ModelState.IsValid)
            {
                using (var httpClient = new HttpClient())
                {
                    //var content = new MultipartFormDataContent();
                    //content.Add(new StringContent(cv.IdCV.ToString()), "IdCV");
                    //content.Add(new StringContent(cv.Nome), "Nome");
                    //content.Add(new StringContent(cv.Localizacao), "Localizacao");
                    //content.Add(new StringContent(cv.Educacao), "Educacao");
                    //content.Add(new StringContent(cv.ExpProfissional), "ExpProfissional");
                    //content.Add(new StringContent(cv.Competencias), "Competencias");
                    //content.Add(new StringContent(cv.Interesses), "Interesses");

                    StringContent content = new StringContent(JsonConvert.SerializeObject(cv), Encoding.UTF8, "application/json");
                    using (var response = await httpClient.PutAsync("https://localhost:7118/api/CV" + cv.IdCV, content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        ViewBag.Result = "Success";
                        c = JsonConvert.DeserializeObject<CV>(apiResponse);
                    }

                }
                return View(c);
            }
            return RedirectToAction("Index"); 
        }

        [HttpGet]
        public async Task<IActionResult> Details(int obj)
        {
            CV cv = new CV();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7118/api/CV" + obj))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    cv = JsonConvert.DeserializeObject<CV>(apiResponse);
                }

            }
            return View(cv);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:7118/api/CV" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
