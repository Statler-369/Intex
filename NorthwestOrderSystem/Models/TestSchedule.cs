using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.Models
{
    public class TestSchedule
    {
        [Key]
        public int primaryKey { get; set; }

        public OrderDetails orderDetails { get; set; }
        public Assay assay { get; set; }
    }
}