using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    public class OrderHistory
    {
        //This is for the Index page in the Customer Controller.
        public SalesOrder salesOrder { get; set; }
        [Display(Name ="Order Status")]
        public string orderStatus { get; set; }
    }
}