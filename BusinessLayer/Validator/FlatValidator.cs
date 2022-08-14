using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validator
{
    public class FlatValidator : AbstractValidator<Flat>
    {
        public FlatValidator()
        {            
            RuleFor(x => x.FlatNo).GreaterThan("0").WithMessage("Daire no 0'dan büyük olmalı");
            RuleFor(x => x.BlockNo).GreaterThan("0").WithMessage("Blok no 0'dan büyük olmalı");            
        }
    }
}
