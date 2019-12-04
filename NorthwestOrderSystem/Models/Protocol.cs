using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("Protocol")]
    public class Protocol
    {
        [Key, Column(Order = 1)]
        [Required]
        public int AssayID { get; set; }

        [Key, Column(Order = 2)]
        [Required]
        public int StepNumber { get; set; }

        [Required(ErrorMessage ="Step Description is required")]
        [Display(Name ="Step Description")]
        [StringLength(255, ErrorMessage ="Keep the description to 255 charcters")]
        public string StepDesc { get; set; }
    }
}