using InventoryManager.Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Service.Contracts
{
    public interface IClothesService
    {
        void AddClothes(RegisterClothesViewModel model);
    }
}
