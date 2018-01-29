using InventoryManager.Service.Contracts;
using InventoryManager.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
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
        public ActionResult AddClothes(RegisterClothesViewModel model, HttpPostedFileBase uploadFile)
        {
            string directory = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();

            if (uploadFile != null && uploadFile.ContentLength > 0)
            {
                var fileName = Path.GetFileName(uploadFile.FileName);
                var photoUrl = Path.Combine(directory, fileName);
                model.PictureUrl = photoUrl;
                uploadFile.SaveAs(Path.Combine(directory, fileName));

                this.clothesService.AddClothes(model);
            }


            return RedirectToAction("Index", "Home");
        }
    }
}