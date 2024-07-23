using Microsoft.AspNetCore.Mvc;

namespace CreateViewComponent.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
