using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CleanArchi.Application.Interfaces;
using MediatR;
using CleanArchi.Domain.Entities;

namespace CleanArchi.Application.Employee.Commands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest
    {


        public string Name { get; set; }


        public class Handler : IRequestHandler<CreateEmployeeCommand, Unit>
        {

            private readonly ICleanArchiDbContext _context;
            private readonly IMediator _mediator;

            public Handler(ICleanArchiDbContext context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Unit> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
            {
                var entity = new Domain.Entities.Employee()
                {
                    Name = request.Name,
                };

                _context.Employees.Add(entity);

                await _context.SaveChangesAsync(cancellationToken);

                await _mediator.Publish(new EmployeeCreated() {EmployeeId = entity.Id}, cancellationToken);

                return Unit.Value;
            }
        }


    }
}
