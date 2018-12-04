using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TOOP.Models;

namespace TOOP.Validators
{
    public class MyCustomValidatorProvider : ModelValidatorProvider
    {
        public override IEnumerable<ModelValidator> GetValidators(ModelMetadata metadata, ControllerContext context)
        {
            if (metadata.ModelType == typeof(Insurance))
            {
                return new ModelValidator[] { new InsuranceValidator(metadata, context) };
            }
            return Enumerable.Empty<ModelValidator>();
        }
    }
}