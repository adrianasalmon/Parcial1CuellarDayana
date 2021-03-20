using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Producto.Models
{
    public class Product
    {
        [Key]
        [Required]
        [StringLength(99999,ErrorMessage ="The field {0} must contain between {1} and {99999} characters",MinimumLength =1)]
        public int ProductID { get; set; }


        [Required]
        [StringLength(30, ErrorMessage = "The field {0} must contain between {3} and {30} characters", MinimumLength = 3)]
        public string Description { get; set; }

       
        [Required]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
        

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime LastBuy { get; set; }

    }
}