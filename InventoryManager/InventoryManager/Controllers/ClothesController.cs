using InventoryManager.Service.Contracts;
using InventoryManager.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace InventoryManager.Controllers
{
    public class ClothesController : Controller
    {
        private readonly IClothesService clothesService;

        public ClothesController(IClothesService clothesService)
        {
            this.clothesService = clothesService;
        }

        [Authorize]
        public ActionResult AddClothes()
        {

            return this.View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult AddClothes(RegisterClothesViewModel model)
        {
            this.clothesService.AddClothes(model);

            return RedirectToAction("Index", "Home");
        }
    }
}