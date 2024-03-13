using EBook.Data;
using EBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace EBook.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) 
        {
            _db=db;
        }
        public IActionResult Index()
        {
            //pour afficher la list des categories
            List<Category> objetCategoryList= _db.Categories.ToList();
            return View();
        }
    }
}
