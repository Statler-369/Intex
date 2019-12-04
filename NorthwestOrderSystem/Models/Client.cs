using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        [Required]
        public int ClientID { get; set; }
        
        [Required(ErrorMessage = "Company ID is required")]
        [Display(Name ="Company ID")]
        [StringLength(10, ErrorMessage ="Limit Company ID to 10 characters")]
        public string CompanyID { get; set; }

        [Required(ErrorMessage = "Client First Name is required")]
        [Display(Name = "Client First Name")]
        [StringLength(255, ErrorMessage = "Limit Client first name to 255 characters")]
        public string ClientFirstName { get; set; }

        [Required(ErrorMessage = "Client Last Name is required")]
        [Display(Name = "Client Last Name")]
        [StringLength(255, ErrorMessage = "Limit Client last name to 255 characters")]
        public string ClientLastName { get; set; }

        [Required(ErrorMessage = "Client Phone Number is required")]
        [Display(Name = "Client Phone Number")]        
        public string ClientPhoneNumber { get; set; }

        [Required(ErrorMessage = "Client Email is required")]
        [Display(Name = "Client Email")]
        [StringLength(255, ErrorMessage = "Limit Client email address to 255 characters")]
        [EmailAddress]
        public string ClientEmail { get; set; }
        
        [Display(Name = "Client Position")]
        [StringLength(255, ErrorMessage = "Limit Client position to 255 characters")]
        public string Position { get; set; }

    }
}