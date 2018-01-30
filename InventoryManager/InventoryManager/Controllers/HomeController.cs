using InventoryManager.Data;
using InventoryManager.Models;
using InventoryManager.Service.Contracts;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
namespace InventoryManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ApplicationUserManager userManager;
        private readonly IClothesService clothesService;

        public HomeController(ApplicationDbContext dbContext, ApplicationUserManager userManager, IClothesService clothesService)
        {
            this.dbContext = dbContext;
            this.userManager = userManager;
            this.clothesService = clothesService;
        }
        public ActionResult Index()
        {
            var model = this.clothesService.GetAllClothes();
            var json = JsonConvert.SerializeObject(model);
            ViewBag.Response = json;
            return View(model);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Add()
        {
            //this.dbContext.Roles.Add(new IdentityRole() { Name = "Admin" });
            //this.dbContext.SaveChangesAsync();
            return View();
        }
    }
}