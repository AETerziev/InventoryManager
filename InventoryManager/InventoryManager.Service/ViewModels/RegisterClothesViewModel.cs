using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using InventoryManager.Data.Models;

namespace InventoryManager.Service.ViewModels
{
   public class RegisterClothesViewModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required]
        [Display(Name = "Size")]
        public string Size { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal SinglePrice { get; set; }

        [Required]
        [Display(Name = "Picture")]
        public string Picture { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        public static Expression<Func<RegisterClothesViewModel,Clothes>> Create
        {
            get
            {
                return u => new Clothes()
                {
                    Name = u.Name,
                    Type = u.Type,
                    Quantity=u.Quantity,
                    Size=u.Size,
                    SinglePrice=u.SinglePrice,
                    PictureUrl=u.Picture,
                    Description=u.Description
                };
            }
        }

    }
}
