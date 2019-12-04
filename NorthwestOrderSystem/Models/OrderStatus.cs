using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("OrderStatus")]
    public class OrderStatus
    {
        [Key]
        [Required]
        public int OrderStatusID { get; set; }

        [Display(Name ="Status Description")]
        public string StatusDesc { get; set; }
    }
}