using EBook.Data;
using EBook.DataAccess.Repository;
using EBook.DataAccess.Repository.IRepository;
using EBook.Models;
using EBook.Models.ViewModels;
using EBook.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EBook.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UserController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        
        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<ApplicationUser> objUserList = _db.ApplicationUsers.Include(u=>u.Company).ToList();
            return Json(new  { data = objUserList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
