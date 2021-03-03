using Business.Constants;
using Core.Entities.Concrete;
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
            //RuleFor(u => u.PasswordHash).NotEmpty();
            //RuleFor(u => u.PasswordHash).MinimumLength(8).WithMessage(Messages.UserPassword);
            //RuleFor(u => u.FirstName).NotEmpty().WithMessage(Messages.UserFristName);
            //RuleFor(u => u.LastName).NotEmpty().WithMessage(Messages.UserLastName);
            //RuleFor(u => u.Email).EmailAddress(). WithMessage(Messages.UserEmail);
        }

    }
}
