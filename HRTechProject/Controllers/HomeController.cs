using HRTechProject.Entities;
using HRTechProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HRTechProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HttpClient _httpClient;

        public HomeController(ILogger<HomeController> logger,HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }
        
        public async Task<IActionResult> Index()
        {
            var personeller = await _httpClient.GetFromJsonAsync<List<Personel>>("https://localhost:7063/api/Personeller");
            return View(personeller);
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
