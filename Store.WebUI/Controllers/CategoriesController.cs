using Microsoft.AspNetCore.Mvc;

namespace Store.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
