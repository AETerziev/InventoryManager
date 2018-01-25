using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Data.Models
{
    public class Clothes
    {
        [Key]
        public int Id { get; set; }

        [StringLength(30, MinimumLength = 2, ErrorMessage = "The name of the merchandise must be between 2 and 30 symbols long")]
        public string Name { get; set; }

        [StringLength(30, MinimumLength = 2, ErrorMessage = "The type of the merchandise must be between 2 and 30 symbols long")]
        public string Type { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Thq quantity of the merchandise must be 0 or higher")]
        public int Quantity { get; set; }

        [StringLength(30, MinimumLength = 2, ErrorMessage = "The name of the merchandise must be between 2 and 30 symbols long")]
        public string Size { get; set; }

        [Range(0.0, double.MaxValue, ErrorMessage = "The Price of the merchandise must be higher than 0.0")]
        public decimal SinglePrice { get; set; }

        
        public string PictureUrl { get; set; }

        [StringLength(100, MinimumLength = 2, ErrorMessage = "The description of the merchandise must be between 2 and 100 symbols long")]
        public string Description { get; set; }


    }
}
