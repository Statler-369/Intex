using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("Position")]
    public class Position
    {
        [Key]
        [Required]
        public int PositionID { get; set; }

        [Required(ErrorMessage ="Position Description is required")]
        [Display(Name ="Position")]
        public string PositionDesc { get; set; }
    }
}