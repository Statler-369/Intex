using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("Assay")]
    public class Assay
    {
        [Key]
        [Required]
        public int AssayID { get; set; }

        [Required(ErrorMessage ="A short description (100 characters) is required")]
        [StringLength(100, ErrorMessage ="Keep this within 100 characters")]
        [Display(Name ="Short Description")]
        public string ShortDesc { get; set; }

        [Required(ErrorMessage = "Estimated Assay Cost is required")]        
        [Display(Name = "Assay Cost")]
        public decimal Cost { get; set; }

        [Required(ErrorMessage = "Estimated Assay Price is required")]
        [Display(Name = "Base Price")]
        public decimal BasePrice { get; set; }

        [Required(ErrorMessage = "A detailed description (255 characters) is required")]
        [StringLength(255, ErrorMessage = "Keep this within 255 characters")]
        [Display(Name = "Detailed Description")]
        public string DetailedDesc { get; set; }
    }
}