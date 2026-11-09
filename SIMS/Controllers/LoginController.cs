using Microsoft.AspNetCore.Mvc;
using SIMS.Models;

namespace SIMS.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // hien thi 1 giao dien ra ngoai trinh dien
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // khong co loi nhap du lieu
                string username = model.Username.ToString().Trim();
                string password = model.Password.ToString().Trim();
                if (username.Equals("admin") && password.Equals("12345"))
                {
                    // chuyen sang trang dashboard
                    return RedirectToAction("Index", "Dashboard");
                }
                ViewData["InvalidAccount"] = "your account invalid";
            }
            return View(model); // co loi tra lai giao dien form login
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
