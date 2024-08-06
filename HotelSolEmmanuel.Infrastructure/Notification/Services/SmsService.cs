using HotelSolEmmanuel.Infrastructure.Base;
using HotelSolEmmanuel.Infrastructure.Notification.Interfaces;
using HotelSolEmmanuel.Infrastructure.Notification.Models;

namespace HotelSolEmmanuel.Infrastructure.Notification.Services
{
    public class SmsService : INotificationService<SmsModel>
    {
        public Task<NotificationResult> Send(SmsModel model)
        {
            throw new NotImplementedException();

        }
    }
}
