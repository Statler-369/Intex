using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("Equipment")]
    public class Equipment
    {
        [Key]
        [Required]
        public int EquipmentID { get; set; }

        [Display(Name ="EquipmentDesc")]
        public string EquipmentDesc { get; set; }
    }
}