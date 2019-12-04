using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        [Required(ErrorMessage ="Input the LT number")]
        [Display(Name ="Compound LT Number")]
        public int CompoundLT { get; set; }

        [Required(ErrorMessage = "Input the description")]
        [Display(Name = "Compound Description")]
        [StringLength(255, ErrorMessage ="Limit the description to 255 charcters")]
        public string CompoundDesc { get; set; }

    }
}