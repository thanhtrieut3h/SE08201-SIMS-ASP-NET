using Microsoft.AspNetCore.Mvc;
using SIMS.Models;

namespace SIMS.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewData["age"] = 20;
            ViewData["name"] = "Teo";
            var product = new ProductViewModel { Id = 1, Name = "Iphone", Price = 200.89f };
            // truyen du lieu model ra view
            return View(product);
        }
    }
}
