using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("AssayEquipment")]
    public class AssayEquipment
    {
        [Key, Column(Order = 1)]
        [Required]
        public int AssayID { get; set; }

        [Key, Column(Order = 2)]
        [Required]
        public int EquipmentID { get; set; }
    }
}