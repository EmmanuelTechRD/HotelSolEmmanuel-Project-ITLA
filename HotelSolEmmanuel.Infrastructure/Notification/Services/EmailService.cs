
using HotelSolEmmanuel.Infrastructure.Base;
using HotelSolEmmanuel.Infrastructure.Notification.Interfaces;
using HotelSolEmmanuel.Infrastructure.Notification.Models;

namespace HotelSolEmmanuel.Infrastructure.Notification.Services
{
    public class EmailService : INotificationService<EmailModel>
    {
        public Task<NotificationResult> Send(EmailModel model)
        {
            throw new NotImplementedException();

        }
    }
}
