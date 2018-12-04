using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class InsurancesSeeder : DropCreateDatabaseAlways<InsuranceContext>
    {
        protected override void Seed(InsuranceContext context)
        {
            base.Seed(context);

            context.Insurances.Add(new Insurance { Name = "Easy", Price = 100 });
            context.Insurances.Add(new Insurance { Name = "Medium", Price = 500 });
            context.Insurances.Add(new Insurance { Name = "Hard", Price = 1000 });
        }
    }
}