using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Validators
{
    public class MyCustomValidator : ValidationAttribute
    {
        private string StringValueMustNotContain;

        public MyCustomValidator(string str)
        {
            StringValueMustNotContain = str;
        }

        public override bool IsValid(object value)
        {
            if (value == null) return false;

            string str = value.ToString();
            return !str.ToLower().Contains(StringValueMustNotContain);
        }
    }
}