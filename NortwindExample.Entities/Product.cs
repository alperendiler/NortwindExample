using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NortwindExample.Entities
{

    public class Product
    {
        [HiddenInput(DisplayValue=false)]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Required]
        public int CategoryID { get; set; }

    }
}
