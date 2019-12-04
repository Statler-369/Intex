using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        [Required(ErrorMessage = "Please enter your company ID")]
        [Display(Name ="Company ID")]
        [StringLength(10, ErrorMessage = "Limit the company ID to 10 characters")]
        public string CompanyID { get; set; }

        [Required(ErrorMessage ="Please enter the account password")]
        [Display(Name = "Password")]        
        [StringLength(25, ErrorMessage ="Limit the password length to 25 characters")]
        public string CompanyPassword { get; set; }

        [Display(Name = "Company Name")]
        [StringLength(255, ErrorMessage = "Limit the name length to 255 characters")]
        public string CompanyName { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(255, ErrorMessage = "Limit the street address to 255 characters")]
        public string CompanyAddress { get; set; }

        [Display(Name = "Zip Code")]        
        public int CompanyZip { get; set; }

        [Display(Name = "City")]
        [StringLength(255, ErrorMessage = "Limit the city to 255 characters")]
        public string CompanyCity { get; set; }

        [Display(Name = "State")]
        [StringLength(255, ErrorMessage = "Limit the state to 255 characters")]
        public string CompanyState { get; set; }

        [Display(Name = "Country")]
        [StringLength(255, ErrorMessage = "Limit the country to 255 characters")]
        public string CompanyCountry { get; set; }

    }
}