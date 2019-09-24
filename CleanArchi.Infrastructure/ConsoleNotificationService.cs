using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CleanArchi.Application.Interfaces;
using CleanArchi.Application.Notifications.Models;

namespace CleanArchi.Infrastructure
{
    public class ConsoleNotificationService : INotificationService
    {
        public Task SendAsync(Message message)
        {
            Console.WriteLine($"Message To ({message.From}). Subject ({message.Subject}). Body: {message.Body}");
            return Task.CompletedTask;
        }
    }
}
