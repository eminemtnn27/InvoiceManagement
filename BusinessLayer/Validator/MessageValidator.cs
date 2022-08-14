using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Validator
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.User.Name).NotEmpty().MinimumLength(3);
            RuleFor(x => x.User.Email).NotEmpty().MinimumLength(3);
            RuleFor(x => x.Messages).NotEmpty().MinimumLength(3);
            RuleFor(x => x.Subject).NotEmpty().MinimumLength(2);            
        }
    }
}
