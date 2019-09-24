using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CleanArchi.Application.Interfaces;
using CleanArchi.Application.Notifications.Models;
using MediatR;

namespace CleanArchi.Application.Employee.Commands.CreateEmployee
{
    public class EmployeeCreated : INotification
    {
        public string EmployeeId { get; set; }

        public class EmployeeCreatedHandler : INotificationHandler<EmployeeCreated>
        {
            private readonly INotificationService _notification; 

            public EmployeeCreatedHandler(INotificationService notification)
            {
                _notification = notification;
            }

            public async Task Handle(EmployeeCreated notification, CancellationToken cancellationToken)
            {
                await _notification.SendAsync(new Message()
                {
                    To = "Admin",
                    Subject = "Employee Created",
                    Body = $"EmployeeId {notification.EmployeeId}",
                });
            }
        }

    }
}
