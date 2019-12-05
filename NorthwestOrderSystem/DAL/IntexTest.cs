using NorthwestOrderSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NorthwestOrderSystem.DAL
{
    public class IntexTestContext : DbContext
    {
        public IntexTestContext()
            : base("IntexTestContext")
        {

        }

        public DbSet<Assay> Assays { get; set; }
        public DbSet<AssayEquipment> AssayEquipments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Company> Companies { get; set; }        
        public DbSet<Compound> Compounds { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }

        public System.Data.Entity.DbSet<NorthwestOrderSystem.Models.TestSchedule> TestSchedules { get; set; }
    }
}