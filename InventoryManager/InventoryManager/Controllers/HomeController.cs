using InventoryManager.Data;
using InventoryManager.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InventoryManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ApplicationUserManager userManager;

        public HomeController(ApplicationDbContext dbContext, ApplicationUserManager userManager)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
        }
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Add()
        {
            //this.dbContext.Roles.Add(new IdentityRole() { Name = "Admin" });
            //this.dbContext.SaveChangesAsync();
            ViewBag.Message = "Your application description page.";

            return View();
        }
    }
}