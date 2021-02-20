using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(8).WithMessage(Messages.UserPassword);
            RuleFor(u => u.FirstName).NotEmpty().WithMessage(Messages.UserFristName);
            RuleFor(u => u.LastName).NotEmpty().WithMessage(Messages.UserLastName);
            RuleFor(u => u.Email).EmailAddress(). WithMessage(Messages.UserEmail);
        }

        private bool StartsWith(string arg)
        {
            return arg.StartsWith("@");
             
        }
    }
}
