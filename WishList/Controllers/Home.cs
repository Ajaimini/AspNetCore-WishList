using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
