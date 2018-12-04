using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        [Display(Name = "Customer")]
        [DataType(DataType.Text)]
        public string Customer { get; set; }
    }
}