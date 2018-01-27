using InventoryManager.Service.Contracts;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManager.Service.ViewModels;
using InventoryManager.Data.Models;
using InventoryManager.Data;

namespace InventoryManager.Service
{
    public class ClothesService : IClothesService
    {
        private readonly ApplicationDbContext dbContext;

        public ClothesService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void AddClothes(RegisterClothesViewModel model)
        {
            var clothes = new Clothes()
            {
                Name = model.Name,
                Type = model.Type,
                Quantity = model.Quantity,
                Size = model.Size,
                SinglePrice = model.SinglePrice,
                PictureUrl = model.Picture,
                Description = model.Description
            };
            this.dbContext.Clothes.Add(clothes);
            this.dbContext.SaveChanges();
        }
    }
}
