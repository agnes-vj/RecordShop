using Microsoft.AspNetCore.Mvc;

namespace RecordShop.Controllers
{
    public class AlbumsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
