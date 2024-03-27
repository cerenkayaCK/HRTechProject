using HRTechProject.Data;
using HRTechProject.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRTechProject.Controllers
{
    public class PersonelController : Controller
    {
        public PersonelController()
        {
            
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
