using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Exception
{
    public class ClothingStoreValidationException:ApplicationException
    {
        public List<ValidationFailure> ValidationFailures { get; set; }
        public ClothingStoreValidationException(List<ValidationFailure> validationFailures)
            : base("Validation Exception")
        {
            ValidationFailures = validationFailures;
        }

    }
}
