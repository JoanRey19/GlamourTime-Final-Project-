using GlamourTime.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace GlamourTime.Web.Controllers
{
    public class CustomerController1 : Controller
    {
        private readonly HttpClient _httpClient;

        public CustomerController1(IHttpClientFactory httpClientFactory)

        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7290/api");
        }
        public async Task<ActionResult> Index ()
        {
            var response = await _httpClient.GetAsync("api/Customers/lista");
           
            if (response.IsSuccessStatusCode) 
            {
                var content = await response.Content.ReadAsStringAsync();
                var customers = JsonConvert.DeserializeObject<IEnumerable<Customer>>(content);
                return View("Index", customers);
            }

            return View(new List<Customer>());
        }

        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Customer customer) 
        { 
            if (ModelState.IsValid) 
            { 
               var Json = JsonConvert.SerializeObject(customer);
               var content = new StringContent(Json, Encoding.UTF8, "application/json");
               var response = await _httpClient.PostAsync("api/Customers", content);

                if (response.IsSuccessStatusCode) 
                {
                    return RedirectToAction("Index");
                }
                else 
                {
                    var errorContent = await response.Content.ReadAsStringAsync();
                    ModelState.AddModelError(string.Empty, "Error creating customer {errorContent}");
                
                }
                
            }
            return View(customer);
        }
    }
}
