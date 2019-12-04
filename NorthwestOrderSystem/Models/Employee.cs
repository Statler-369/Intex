using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [Required]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage ="Employee first name is Required")]
        [Display(Name ="Employee First Name")]
        [StringLength(255)]
        public string EmpFirstName { get; set; }

        [Required(ErrorMessage = "Employee last name is Required")]
        [Display(Name = "Employee Last Name")]
        [StringLength(255)]
        public string EmpLastName { get; set; }

        [Required(ErrorMessage = "Employee Location is Required")]
        [Display(Name = "Employee Location")]
        [StringLength(255)]
        public string LocationID { get; set; }

        [Required(ErrorMessage = "Employee position is Required")]
        [Display(Name = "Employee Position")]        
        public int PositionID { get; set; }

        [Required(ErrorMessage = "Employee phone number is Required")]
        [Display(Name = "Employee Phone Number")]
        [StringLength(255)]
        public string EmpPhone { get; set; }

        [Required(ErrorMessage = "Employee Email is Required")]
        [Display(Name = "Employee Email Address")]
        [EmailAddress]
        [StringLength(255)]
        public string EmpEmail { get; set; }

        [Required(ErrorMessage = "Employee Street Address is Required")]
        [Display(Name = "Street Address")]
        [StringLength(255)]
        public string EmpAddress { get; set; }

        [Required(ErrorMessage = "Employee City is Required")]
        [Display(Name = "City")]
        [StringLength(255)]
        public string EmpCity { get; set; }

        [Required(ErrorMessage = "Employee State is Required")]
        [Display(Name = "State")]
        [StringLength(255)]
        public string EmpState { get; set; }

        [Required(ErrorMessage = "Employee Zip Code is Required")]
        [Display(Name = "Zip Code")]
        [StringLength(255)]
        public string EmpZip { get; set; }

        [Required(ErrorMessage = "Employee Country is Required")]
        [Display(Name = "Country")]
        [StringLength(255)]
        public string EmpCountry { get; set; }        
    }
}