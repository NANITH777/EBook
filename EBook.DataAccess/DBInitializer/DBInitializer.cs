using EBook.Data;
using EBook.Models;
using EBook.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.DataAccess.DBInitializer
{
    public class DBInitializer : IDBInitializer
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;


        public DBInitializer(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db)
            {
                _roleManager = roleManager;
                _userManager = userManager;
                _db = db;
            }
        public void Initialize()
        {
            // Migrations if they are not applied
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                   _db.Database.Migrate();
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
               
            }


            // Create roles if they are not applied
            if (!_roleManager.RoleExistsAsync(SD.Role_Customer).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Customer)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Employee)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Company)).GetAwaiter().GetResult();


                // if roles are not created, then we will create Admin user as well
                _userManager.CreateAsync(new ApplicationUser
                {
                    UserName = "nanith@sakarya.edu.tr",
                    Email = "b201200576@sakarya.edu.tr",
                    Name = "Nanith",
                    PhoneNumber = "05346060000",
                    StressAdress = "Serdivan",
                    State = "Türkiye",
                    PostalCode = "54054",
                    City = "Sakarya"
                }, "Admin@7755").GetAwaiter().GetResult();

                ApplicationUser user = _db.ApplicationUsers.FirstOrDefault
                    (u => u.Email == "nanith@sakarya.edu.tr");
                _userManager.AddToRoleAsync(user, SD.Role_Admin).GetAwaiter().GetResult();
            }
            return;

        }

    }
}
