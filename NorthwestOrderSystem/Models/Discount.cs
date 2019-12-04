using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("Discount")]
    public class Discount
    {
        [Key]
        [Required]
        public int DiscountID { get; set; }

        [Required(ErrorMessage ="Discount amount is required")]
        [Display(Name ="Discount Amount")]
        public float DiscountAmount { get; set; }

        [StringLength(255, ErrorMessage ="Keep the description to 255 characters")]
        [Display(Name ="Discount Description")]
        public string DiscountDescription { get; set; }
    }
}