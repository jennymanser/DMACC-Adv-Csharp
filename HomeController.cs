using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppLastName.Models;

namespace FirstResponsiveWebAppLastName.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index(UserModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Result", model);
            }
            return View(model);
        }

        public IActionResult Clear()
        {
            return RedirectToAction("Index");
        }
    }
}