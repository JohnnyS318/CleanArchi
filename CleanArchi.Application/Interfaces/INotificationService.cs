using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CleanArchi.Application.Notifications.Models;

namespace CleanArchi.Application.Interfaces
{
    public interface INotificationService
    {
        Task SendAsync(Message message);
    }
}
