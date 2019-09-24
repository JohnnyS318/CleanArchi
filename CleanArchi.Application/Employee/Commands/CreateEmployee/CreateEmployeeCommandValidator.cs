using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CleanArchi.Application.Employee.Commands.CreateEmployee
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(x => x.Name).MaximumLength(50).NotEmpty();
        }
    }
}
