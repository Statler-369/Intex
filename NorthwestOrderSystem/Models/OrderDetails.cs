using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("OrderDetails")]
    public class OrderDetails
    {
        [Key, Column(Order = 1)]
        [Required]
        public int OrderID { get; set; }

        [Key, Column(Order = 2)]
        [Required]
        public int CompoundLT { get; set; }

        [Key, Column(Order = 3)]
        [Required]
        public int CompoundSequenceNumber { get; set; }
        
        [Required]
        public int AssayID { get; set; }

        [Required(ErrorMessage ="Enter Quantity in miligrams")]
        [Display(Name ="Quantity in miligrams")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Enter Date arrived")]
        [Display(Name = "Date Arrived")]
        public DateTime DateArrived { get; set; }

        [Required(ErrorMessage = "Enter Employee who received the order")]
        [Display(Name = "Employee")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage ="Enter Compound Appearance")]
        [Display(Name ="Appearance")]
        public string Appearance { get; set; }

        [Required(ErrorMessage = "Enter actual weight")]
        [Display(Name = "Actual Weight")]
        public decimal ActualWeight { get; set; }

        [Required(ErrorMessage = "Enter molecular mass")]
        [Display(Name = "Molecular Mass")]
        public decimal MolecularMass { get; set; }

        [Required(ErrorMessage = "Enter client estimated weight")]
        [Display(Name = "Client Estimated Weight")]
        public decimal ClientEstimatedWeight { get; set; }
        
        [Display(Name = "Maximum Tolerated Dose (MTD)")]
        public decimal MaxToleratedDose { get; set; }
        
        [Display(Name = "Scheduled Test Date")]
        public DateTime ScheduledTestDate { get; set; }
    }
}