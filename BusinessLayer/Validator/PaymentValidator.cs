using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validations
{
    public class PaymentValidator : AbstractValidator<Payment>
    {
        public PaymentValidator()
        {            
            RuleFor(x => x.BillingSum).NotEmpty().WithMessage("Ödenecek para bilgisi boş olamaz");
            RuleFor(x => x.FlatId).NotEmpty().GreaterThan(0).WithMessage("Ev bilgisi boş olamaz");            
        }
    }
}
