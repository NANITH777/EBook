using Microsoft.AspNetCore.Mvc;

namespace EBook.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
