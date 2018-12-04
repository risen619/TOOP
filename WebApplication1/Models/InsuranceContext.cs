using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TOOP.Models
{
    public class InsuranceContext : DbContext
    {
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}