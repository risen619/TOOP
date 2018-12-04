using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Resources;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Validators;

namespace WebApplication1.Models
{
    public class Order
    {
        public int Id { get; set; }
        
        public Insurance Insurance { get; set; }
        
        public string Customer { get; set; }
    }

    public class OrderViewModel
    {
        [ScaffoldColumn(false)]
        public Insurance Insurance { get; set; }

        [Required]
        [Display(Name = "CustomerEmail", ResourceType = typeof(Resources.Resources))]
        [MyCustomValidator("lmfao")]
        [DataType(DataType.EmailAddress)]
        public string Customer { get; set; }
    }
}