using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator:AbstractValidator<CarImage>
    {
        CarImageValidator()
        {
            RuleFor(i => i.CarId).NotEmpty();

        }
        
    }
}
