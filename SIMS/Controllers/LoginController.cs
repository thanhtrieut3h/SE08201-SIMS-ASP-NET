using Microsoft.AspNetCore.Mvc;
using SIMS.Interfaces;
using SIMS.Models;

namespace SIMS.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userService;
        public LoginController(IUserService service)
        {
            _userService = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(); // hien thi 1 giao dien ra ngoai trinh dien
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // khong co loi nhap du lieu
                string username = model.Username.ToString().Trim();
                string password = model.Password.ToString().Trim();
                var user = await _userService.LoginUserAsync(username, password);
                if (user != null)
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
