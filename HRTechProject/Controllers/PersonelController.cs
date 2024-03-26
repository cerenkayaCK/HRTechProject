using Microsoft.AspNetCore.Mvc;

namespace HRTechProject.Controllers
{
    public class PersonelController : Controller
    {
        public async Task<IActionResult> Index()
        {            
            return View();
        }
    }
}
