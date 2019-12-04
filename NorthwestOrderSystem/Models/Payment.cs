using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        [Required(ErrorMessage ="Input Payment ID")]
        [Display(Name ="Payment ID")]
        public int PaymentID { get; set; }

        [Required(ErrorMessage = "Input Payment Amount")]
        [Display(Name = "Payment Amount")]
        public decimal PaymentAmount { get; set; }

        [Required(ErrorMessage = "Input Payment Date")]
        [Display(Name = "Payment Date")]
        public DateTime PaymentDate { get; set; }

        [Required(ErrorMessage = "Input Payment Type")]
        [Display(Name = "Payment Type")]
        public string PaymentType { get; set; }
    }
}