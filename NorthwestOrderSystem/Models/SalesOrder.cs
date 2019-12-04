using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("SalesOrder")]
    public class SalesOrder
    {
        [Key]
        [Required]
        public int OrderID { get; set; }

        [Display(Name ="Order Status")]
        public int OrderStatusID { get; set; }

        [Display(Name ="Payment ID")]   
        public int PaymentID { get; set; }

        [Required(ErrorMessage ="Company ID is required")]
        [Display(Name ="Company ID")]
        public string CompanyID { get; set; }

        [Display(Name ="Other Comments")]
        public string OrderComments { get; set; }
        
        [Display(Name ="Expedite")]
        public bool Expedite { get; set; }

        [Display(Name ="Total Price")]
        public decimal TotalPrice { get; set; }

        [Display(Name ="Quoted Price")]
        public decimal QuotedPrice { get; set; }

        [Display(Name ="Due Date")]
        public DateTime OrderDueDate { get; set; }
    }
}